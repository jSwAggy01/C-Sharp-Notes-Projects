# Add Looping Logic to your Code using the do-while and while Statements in C#

In this section I was tasked with implementing solutions that involved adhering to a set of program requirements, utilizing the looping logic of `do-while`, `while`, `for`, and `foreach` statements. The code below represents my solutions to the given prompts, as well as what the output of the respective programs looked like.

## Code Challenge: `do-while` Implementation

```cs
/*
Requirements:
- You must use either the do-while statement or the while statement as an outer game loop.
- The hero and the monster will start with 10 health points.
- All attacks will be a value between 1 and 10.
- The hero will attack first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.

Output:
Monster was damaged and lost 3 health and now has 7 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 6 health and now has 1 health.
Hero was damaged and lost 2 health and now has 7 health.
Monster was damaged and lost 1 health and now has 0 health.
Hero wins!
*/
Console.WriteLine("\n---Code Challenge---\n");

Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

do
{
    int heroAttackDamage = random.Next(1, 10);
    int monsterAttackDamage = random.Next(1, 10);

    // Hero attacks monster:
    monsterHealth -= heroAttackDamage;
    Console.WriteLine($"Monster was damaged and lost {heroAttackDamage} health and now has {monsterHealth} health.");

    // Monster attacks hero:
    if (monsterHealth > 0)
    {
        heroHealth -= monsterAttackDamage;
        Console.WriteLine($"Hero was damaged and lost {monsterAttackDamage} health and now has {heroHealth} health.");
    }
    else continue;
}
while ((heroHealth > 0) && (monsterHealth > 0));

Console.WriteLine((heroHealth > 0) ? "Hero wins!" : "Hero loses.");
```
```
---Code Challenge---

Monster was damaged and lost 6 health and now has 4 health.
Hero was damaged and lost 7 health and now has 3 health.   
Monster was damaged and lost 2 health and now has 2 health.
Hero was damaged and lost 3 health and now has 0 health.   
Hero loses.
```

## Code Project 1: Integer Input Validation

```cs
/* 
Requirements:
- Your solution must include either a do-while or while iteration.

- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

- Inside the iteration block:
    - Your solution must use a Console.ReadLine() statement to obtain input from the user.
    - Your solution must ensure that the input is a valid representation of an integer.
    - If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
    - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

- Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

Output:
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/
Console.WriteLine("\n---Code Project 1: Integer Input Validation---\n");

string? userInput;
bool validInteger = false;
int integerValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    userInput = Console.ReadLine();
    validInteger = int.TryParse(userInput, out integerValue);

    if (validInteger)
    {
        if ((integerValue > 5) && (integerValue < 10))
        {
            continue;
        }
        else
        {
            Console.WriteLine($"You entered {integerValue}. Please enter a number between 5 and 10.");
            validInteger = false;
            continue;
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
}
while (!validInteger);

Console.WriteLine($"Your input value ({integerValue}) has been accepted.");
```
```
---Code Project 1: Integer Input Validation---

Enter an integer value between 5 and 10
5
You entered 5. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
```

## Code Project 2: String Input Validation
```cs
/* 
Requirements:
- Your solution must include either a do-while or while iteration.

- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

- Inside the iteration block:
    - Your solution must use a Console.ReadLine() statement to obtain input from the user.
    - Your solution must ensure that the value entered matches one of the three role options.
    - Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
    - Your solution should use the ToLower() method on the input value to ignore case.
    - If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.

- Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

Output:
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/
Console.WriteLine("\n---Code Project 2: String Input Validation---\n");

string? userString;
string? userRole;
bool validRole = false;

Console.WriteLine("Enter your role name (Administration, Manager, or User)");

do
{
    userString = Console.ReadLine();
    userRole = userString?.ToLower().Trim();
    if ((userRole == "administrator") || (userRole == "manager") || (userRole == "user"))
    {
        validRole = true;
    }
    else
    {
       Console.WriteLine($"The role name that you entered, \"{userRole}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
}
while (!validRole);

Console.WriteLine($"Your input value ({userString}) has been accepted.");
```
```
---Code Project 2: String Input Validation---

Enter your role name (Administration, Manager, or User)
manage
The role name that you entered, "manage" is not valid. Enter your role name (Administrator, Manager, or User)
admin
The role name that you entered, "admin" is not valid. Enter your role name (Administrator, Manager, or User)
administrator
Your input value (administrator) has been accepted.
```

## Code Project 3: Processing string array content
```cs
/*Code Project 3: Processing string array content

Requirements:
- Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

- Your solution must use the following string array to represent the input to your coding logic:

    `string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };`

- Your solution must include an outer foreach or for loop that can be used to process each string element in the array.
The string variable that you'll process inside the loops should be named `myString`.

- In the outer loop, your solution must use the `IndexOf()` method of the String class to get the location of the first period character in the `myString` variable.
The method call should be similar to: `myString.IndexOf(".")`. If there's no period character in the string, a value of -1 will be returned.

- Your solution must include an inner do-while or while loop that can be used to process the myString variable.
    - In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
    - In the inner loop, your solution must not display the period character.
    - In the inner loop, your solution must use the `Remove()`, `Substring()`, and `TrimStart()` methods to process the string information.

Output:
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/
Console.WriteLine();

int periodLocation = -1;
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf('.');

    // Case 1: Period exists - "I like pizza. I like salad."
    while (periodLocation != -1)
    {
        Console.WriteLine(myString.Remove(periodLocation));
        myString = myString.Substring(periodLocation).TrimStart('.', ' ');
        periodLocation = myString.IndexOf('.');
    }
    
    // Case 2: Period doesn't exist - "I like pizza I like salad" OR "I like pizza. I like salad
    Console.WriteLine(myString);
}
```
```
---Code Project 3: Processing string array content---

I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
```