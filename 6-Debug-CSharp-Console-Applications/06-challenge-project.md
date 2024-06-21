# Project Overview

The objective of this challenge project was to utilize the tools of the built-in **Visual Studio Code debugger** as well as the techniques of **exception handling** in order to successfully debug a mock cash register application.

<ins>**Source code**</ins>: [here!](FinalProjects/ChallengeProject/Starter/Program.cs)

## Specifications
- Top-level statements must:
    - Simulate transactions using randomly generated item costs.
    - Generate random values  for `itemCost` in the range `2 - 49`.
    - Simulate 100 transactions.
- Program output must include:
    - Record of 100 attempted transactions.
    - Exception being thrown and caught stating:
        - (A) **"Could not make transaction: InvalidOperationException: Not enough money provided to complete the transaction."**
        - (B) **"Could not make transaction: InvalidOperationException: The till is unable to make change for the cash provided."**
    - An equality between the reported and expected till values.

## Learning Outcomes

Overall, this challenge project really helped me internalize the debugging techniques of C# via:
- Implementing `throw-catch` blocks for exception handling
- Utilizing the **Visual Studio Code debugger** to isolate logic issues
- Configuring the `launch.json` file to support the application

## Problem-Resolution Statement

The `MakeChange` method would `throw` exceptions indicating a failed transaction. However, the `cashTill` would continue to register the transaction into its total. I was able to track down the issue via noticing the discrepency via the console output, and then setting **breakpoints** at the suspected parts of my code to further isolate the issue. All of which, resulted in succesfully identifying the logic issue and modifying the code to resolve it!

```cs
static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
    int changeNeeded = amountPaid - cost;

    // Duplicate values just in case "till is unable to make change"
    int[] cashTillInitialValues = new int[4];
    Array.Copy(cashTill, cashTillInitialValues, 4);

    if (changeNeeded < 0)
    {
        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");
    }

    cashTill[3] += twenties;
    cashTill[2] += tens;
    cashTill[1] += fives;
    cashTill[0] += ones;

    Console.WriteLine("Cashier prepares the following change:");

    while ((changeNeeded > 19) && (cashTill[3] > 0))
    {
        cashTill[3]--;
        changeNeeded -= 20;
        Console.WriteLine("\t A twenty");
    }

    while ((changeNeeded > 9) && (cashTill[2] > 0))
    {
        cashTill[2]--;
        changeNeeded -= 10;
        Console.WriteLine("\t A ten");
    }

    while ((changeNeeded > 4) && (cashTill[1] > 0))
    {
        cashTill[1]--;
        changeNeeded -= 5;
        Console.WriteLine("\t A five");
    }

    while ((changeNeeded > 0) && (cashTill[0] > 0))
    {
        cashTill[0]--;
        changeNeeded -= 1;
        Console.WriteLine("\t A one");
    }

    if (changeNeeded > 0)
    {
        // Cancel transaction and reset till with initial values
        Array.Copy(cashTillInitialValues, cashTill, 4);

        throw new InvalidOperationException("InvalidOperationException: The till is unable to make change for the cash provided.");
    }
}
```