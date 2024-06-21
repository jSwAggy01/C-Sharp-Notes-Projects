# Implement exception handling in C# console applications

When your program runs into unexpected behavior, it will generate an **exception**. This exception will then terminate your program if it is not handled correctly. To do so, you must 'catch' these exceptions when they occur. Doing so will allow your program to continue executing all of its code without abnormally crashing. It is important to handle exceptions beacause failing to do so may result in dangerous repercussions (i.e. video game crashing and losing all your progress). There are a couple of techniques to do this and they involve using `try-catch` constructs.

## Exception Handling Techniques

In short, the `try` block will signal whether or not the code that it contains, generates an exception. If the code does generate an exception, control will be sent over to the `catch` block, where the developer can decide what to do with it. Additionally, you can add an optional `finally` block that will always execute whether or not an exception occurs. This can be useful when you need to clean up resources in your program that will cause serious issues if an exception is not caught.

Generally, exception handling is implemented using the following patterns:
- <ins>`try-catch`</ins>: Used to handle individual/different exceptions.
- <ins>`try-finally`</ins>: `Finally` block runs when control leaves the `try` statement.
- <ins>`try-catch-finally`</ins>: Combination of the previous two.

```cs
try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{   
   // Step 5: the system transfers control to the first line of the catch code block
}
```

## Exception Properties

Exceptions are nothing more objects that contain information. Furthermore, all exceptions inherit from a base class `System.Exception`. For example, `InvalidCastException` inherits its properties in this hierarchial fashion:

```
Object
    Exception
        SystemException
            InvalidCastException
```

With this in mind, you can easily access the information of any kind of exception. The following are the properties of the `Exception` class:
- **Data**: The Data property holds arbitrary data in key-value pairs.
- **HelpLink**: The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.
- **HResult**: The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.
- **InnerException**: The InnerException property can be used to create and preserve a series of exceptions during exception handling.
- **Message**: The Message property provides details about the cause of an exception.
- **Source**: The Source property can be used to access the name of the application or the object that causes the error.
- **StackTrace**: The StackTrace property contains a stack trace that can be used to determine where an error occurred.
- **TargetSite**: The TargetSite property can be used to get the method that throws the current exception.

## <ins>Coding Challenge</ins>: Catching Multiple Exceptions

The program below demonstrates the practice of catching multiple different types of exceptions, which in effect, allows the program to continue running to completion without dangerously or abnormally crashing. Processes 1-4 will all produce exceptions and be caught by their self-contained `try-catch` blocks. Since the exceptions are caught as they occur, the program runs to completion at its final line:

```cs
Console.WriteLine("Exiting program.");
```

Since all the exceptions are caught, the corresponding `catch` block at the beginning will never have to execute, but it is good practice to be proactive just in case an exception within your program is unaccounted for :)

```cs
/* Coding Challenge: Catching multiple and specific exceptions */
try
{
    Process1();
    Process2();
    Process3();
    Process4();
}
catch (Exception ex)
{
    Console.WriteLine("An exception was caught. " + ex.Message);
}

Console.WriteLine("Exiting program.");

void Process1()
{
    checked
    {
        try
        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
        }
    }
}

void Process2()
{
    try
    {
        string str = null;
        int length = str.Length;
        Console.WriteLine("String Length: " + length);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null. " + ex.Message);
    }
}

void Process3()
{
    try
    {
        int[] numbers = new int[5];
        numbers[5] = 10;
        Console.WriteLine("Number at index 5: " + numbers[5]);
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range. " + ex.Message);
    }
}

void Process4()
{
    try
    {
        int num3 = 10;
        int num4 = 0;
        int result2 = num3 / num4;
        Console.WriteLine("Result: " + result2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
    }
}
```

```
Error: The number is too large to be represented as an integer. Arithmetic operation resulted in an overflow.
Error: The reference is null. Object reference not set to an instance of an object.
Error: Index out of range. Index was outside the bounds of the array.
Error: Cannot divide by zero. Attempted to divide by zero.
Exiting program.
```