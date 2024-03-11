# Control Variable Scope and Logic Using Code Blocks in C#

In programming, it is very important to know whether or not you can access certain functionalities of an application, or if you should even be able to.

## Terminology

- **Code blocks** denote the chunks of code that reside in between curly brackets `{...}`.

- **Variable scope** refers to whether or not a variable can be accessed or used within the context in which it is defined.

## Examples

Take these pieces of code for example.
```cs
// Exhibit A: Does work
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

// Exhibit B: Doesn't work
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");
```

The second piece of code, *Exhibit B*, will not compile because the integer `value` exists only within the context of the `if` statement **code block**. Therefore, the last line of code will never execute because `value` is not **in-scope** with where it is declared.

Here's another example:
```cs
// Code sample 1: Doesn't work
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

// Code sample 2: Works
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
```

In this example, *Code sample 1* will generate an error because the compiler will interpret the `flag` arguement as having two possibilities:
```cs
// (1) path when flag = true
int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
```
**AND**
```cs
// (2) path when flag = false
int value;
Console.WriteLine($"Outside the code block: {value}");
```

Since it is possible that the `flag` variable could be **FALSE**, it generates an error during the build process.

*Code sample 2* on the other hand will compile and run flawlessly because the compiler understands that the `true` value in the `if` statement will always be **TRUE**. And so, it interprets that piece of code as having only one logical execution path.

```cs
// (1) path when flag = true, only accessible path, works everytime
int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
```

**Note**: In order for a compiler to compile, all possible decisions that your code can make, have to work in all situations.

***TODO***: Add "100% of the time, it's gotta work, every time." meme gif.

Lastly, we have one final example:
```cs
// Exhibit A: Does work, all variables are in-scope
int number1 = 1;

if (number1 > 0)
{
    int number2 = 8;
    number1 += number2;
}

Console.WriteLine($"First integer value: {number1}");

// Exhibit B: Doesn't work, 2nd integer is not in-scope
int integer1 = 5;

if (integer1 > 0)
{
    int integer2 = 6;
}

integer1 += integer2;
Console.WriteLine($"First integer value: {integer1}");
```
Notice how in *Exhibit B*, `integer2` will only be declared within the `if` statement. However, there is also an attempt to access it after the *code branch*, which cannot be done since the compiler understands that in the given the arguement: `integer1 > 0`, there is a possiblity where this condition is **FALSE** which would mean that the line `integer1 += integer2;` cannot be executed.

**Note**: Remember that ***in-scope*** refers to a variable being consistent/accessible within all of its contexts.