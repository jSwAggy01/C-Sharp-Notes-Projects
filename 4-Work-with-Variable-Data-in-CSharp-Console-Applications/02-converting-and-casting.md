# Convert Data Types Using Casting and Conversion Techniques in C#

There will be plenty of times you'll have to convert data into some other form in order to perform some kind of scientific calculation or formatting.

## Techniques

### Casting Method

In C#, **casting** is a technique used to convert data types into other data types. This static method should be avoided if precision is important, since it truncates values instead of rounding them.

For example,
```cs
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
```
```
1
2
```

### `ToString()` Method

Another kind of casting would be converting a number to a string.

```cs
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
```
```
57
```

### `Parse()` Helper Method

Most data types also have a built-in `Parse()` method that allows them to convert to the specified data type.

For example,
```cs
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
```
```
12
```

However, `TryParse()` is often preferred because it will explicitly return a boolean value to specify whether or not the value can be converted. `Parse()` on the other hand, will only throw an exception.
```cs
string value1 = "bad";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
```
```
Unhandled exception. System.FormatException: The input string 'bad' was not in a correct format.
```

### `Convert()` Method

This method also converts the given value to a specified data type. The `Convert()` method is best used when precision is important since it rounds instead of truncates.

```cs
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
```
```
1
2
```

### `TryParse()` Method

The `TryParse()` method is often the preferred conversion method for checking to see if a value can be converted into a number.

As can be seen in this example,
```cs
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
```
```
Unable to report the measurement.
```

Since the `string` variable `value` is in fact not numerical, it cannot be converted to an `int`. And therefore, `int.TryParse(value, out result)` will return false. Thusly, executing the `else` statement.

**Note**: Inserting a `_` for the `out` variable will simply discard the output conversion. For example, `int.TryParse(value, out _)` will only return a boolean, excluding the converted output integer.

## Learning Outcomes

In this section, I learned how to convert different kinds of data into other elgible kinds of data via the static **casting** method, **parse** methods and **convert** methods, in order to understand how to format data for different kinds of applications. I also learned how to verify whether or not a given value could be converted to a specified data type, and how to gracefully handle situations where it cannot be converted. Below are some coding challenges I completed that demonstrate these learning outcomes.

```cs
/* Code Challenge 1 
    - Rule 1: If the value is alphabetical, concatenate it to form a message.
    - Rule 2: If the value is numeric, add it to the total.
    - Rule 3: The result should match the following output:
*/
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0;
decimal output = 0.0m;

foreach (var value in values)
{
    // Value is alphabetical
    if (value.All(Char.IsLetter))
    {
        message += value;
    }
    // Value is numerical 
    else if (decimal.TryParse(value, out output))
    {
        total += output;
    }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");
```
```
Message: ABCDEF
Total: 68.3
```

```cs
/* Code Challenge 2
    - Solve for result1: Divide value1 by value2, display the result as an int
    - Solve for result2: Divide value2 by value3, display the result as a decimal
    - Solve for result3: Divide value3 by value1, display the result as a float
*/
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {value1 / Convert.ToInt32(value2)}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {value2 / Convert.ToDecimal(value3)}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {value3 / (float)value1}");
```
```
Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.35833335
```