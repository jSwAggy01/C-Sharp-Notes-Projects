# Create and throw exceptions in C# console applications

When creating your own applications, it's important that your program knows how to handle unexpected or undesired behavior. Likewise, the practice of creating a throwing exceptions when your program doesn't run as intended is a proactive way to handle such situations.

## Creating Exceptions

Some common types of exceptions include but are not limited to:
- `ArguementException`: when a method is called with an invalid arguement
- `InvalidOperationException`: when a methods is called with an invalid operation
- `NotSupportedException`: when an operation or feature is not supported
- `IOException`: when an input/output operation fails
- `FormatException`: when the format of a string or data is incorrect

Furthermore, exceptions are implemented in the following form:

```cs
ArgumentException invalidArgumentException = new ArgumentException();
```

## Throwing Customized Exceptions

You can also create and throw your own customized exceptions in a similar fashion:

```cs
ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
throw invalidArgumentException;
```

Notice how a personal message has been added to customize the exception.

An exception can also be created and thrown in one line:

```cs
throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");
```

### In general:
- Methods should throw an exception when they can't complete their intended purpose.
- Exceptions should only ever be thrown, not returned as a value or parameter.
- Don't throw `System.Exception`, `System.SystemException`, `System.NullReferenceException`, or `System.IndexOutOfRangeException` intentionally from your own source code.
- Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use `Debug.Assert` instead.

## Re-throwing Exceptions

Exceptions can also be re-thrown to be handled further up the call stack.

```cs
catch (Exception ex)
{
    // handle or partially handle the exception
    // ...

    // re-throw the original exception object for further handling down the call stack
    throw;
}
```

You can also create a new exception that wraps around a preexisting exception as follows:

```cs
catch (Exception ex)
{
    // handle or partially handle the exception
    // ...

    // create a new exception object that wraps the original exception
    throw new ApplicationException("An error occurred", ex);
}
```

## <ins>Coding Challenge</ins>: Creating and throwing exceptions

The code below demonstrates the use of creating, throwing, customizing, and handling different kinds of exceptions.

```cs
/* Coding Challenge: Creating and throwing exceptions */
using System.Data;

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred during 'Workflow1'.\n{ex.Message}");
}

static void Workflow1(string[][] userEnteredValues)
{

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.\n");
        }
        catch (Exception ex)
        {
            if (ex is FormatException)
            {
                Console.WriteLine($"'Process1' encountered an issue, process aborted.\n{ex.Message}\n");
            }
            else
            {
                throw;
            }
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);
            int calculatedValue = 4 / valueEntered;
        }
        catch (FormatException)
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
        catch (DivideByZeroException)
        {
            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
        }
    }
}
```