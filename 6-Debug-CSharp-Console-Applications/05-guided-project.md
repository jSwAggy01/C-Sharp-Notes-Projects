# Project Overview

The objective of this project was to review, verify, and test the functions of a cash register program using randomly generated input.

<ins>**Source code**</ins>: [here!](FinalProjects/GuidedProject/Starter/Program.cs)

## Steps

1. **Code Review**: reviewing the contents of the Program.cs file
2. **Initial Testing**: verifying that the `MakeChange` method correctly calculated and balanced transactions
3. **Code Debugging**: isolating and correcting a logic issue using randomly generated data
4. **Verification Test**: verifying that the output is as intended

## Learning Outcomes

Overall, this section taught me how to throw, catch, create, and customize exceptions in tandem with utilizing the built-in VS Code debugger, in order to track and fix bugs and logic errors in programming applications efficiently. Without the use of these tools, debugging unwanted issues in complex programs would be a convoluted endeavor.

## Sample Output

```
The till currently has:
100 in twenties
100 in tens
100 in fives
50 in ones

The till has 350 dollars
Expected till value: 350

Customer is making a $12 purchase   
         Using 1 twenty dollar bills
         Using 0 ten dollar bills   
         Using 0 five dollar bills  
         Using 0 one dollar bills   
Cashier Returns:
         A five
         A one
         A one
         A one
Transaction successfully completed. 
The till has 362 dollars
Expected till value: 362


Customer is making a $26 purchase   
         Using 2 twenty dollar bills
         Using 0 ten dollar bills   
         Using 0 five dollar bills  
         Using 0 one dollar bills   
Cashier Returns:
         A ten
         A one
         A one
         A one
         A one
Transaction successfully completed. 
The till has 388 dollars
Expected till value: 388

. . .

Customer is making a $18 purchase
         Using 1 twenty dollar bills
         Using 1 ten dollar bills
         Using 1 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
         A ten
         A five
Could not complete transaction: InvalidOperationException: The till is unable to make the correct change.
The till has 1400 dollars
Expected till value: 917


Press the Enter key to exit
```