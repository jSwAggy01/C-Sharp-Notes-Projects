# Perform Basic Operations on Numbers in C#

TLDR; arithmetic is pretty much the same as C++ except for some special cases involving string concatentation.

## A Small Demonstration

**Numerical values** (only):
```cs
// Good!
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
```

```
19
```

**Mixed values** (string + int):
```cs
// Okay.
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
```

Here, the entire output converts all the variables into a string.
```
Bob sold 7 widgets.
```

However valid, this generally isn't considered ***good practice*** due to more advanced cases such as this:
```cs
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
```

```
Bob sold 77 widgets.
```

We expect `14` but due to the C# compiler concatenating everthing into a string, we get `77`, which is not the value we intended.

To resolve this, we must add `()` in the same way we would when specifying *PEMDAS* operations.

And so now, this works:
```cs
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
```

```
Bob sold 14 widgets.
```

**Note**: This is what would generally be considered "best practice."

## Decimals

Likewise, integer arithmetic should not be confused with decimal arithmetic. And as with C++, you must be sure to specify decimal arithmetic.

This can be done using the `m` suffix in the following fashions:
```cs
decimal decimalQuotient1 = 7.0m / 5;
decimal decimalQuotient2 = 7 / 5.0m;
decimal decimalQuotient3 = 7.0m / 5.0m;

Console.WriteLine($"(1) Decimal quotient: {decimalQuotient}");
Console.WriteLine($"(2) Decimal quotient: {decimalQuotient}");
Console.WriteLine($"(3) Decimal quotient: {decimalQuotient}");
```

All of which, yield:
```
(1) Decimal quotient: 1.4
(2) Decimal quotient: 1.4
(3) Decimal quotient: 1.4
```

**Note**: Used in any other manner, results in an error or inaccurate value.

You can also literally cast decimal arithmetic by prefixing `(decimal)` before the numerical variable to achieve the same result:

```cs
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
```

```
1.4
```

## Modulo, my old friend

And as you know, the modulo operator `%` is also a reappearing arithmetic operator.
```cs
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
```

```
Modulus of 200 / 5 : 0
Modulus of 7 / 5 : 2
```

**Note**: Don't forget that PEMDAS still applies.

## Incrementing and Decrementing

Last but not least, good ol' incrementing and decrementing.

For your review, the operations are:
```cs
int value = 1;

// Noraml increment:
value = value + 1;
Console.WriteLine("First increment: " + value);

// Addition assignment:
value += 1;
Console.WriteLine("Second increment: " + value);

// Increment operator:
value++;
Console.WriteLine("Third increment: " + value);

// Normal decrement:
value = value - 1;
Console.WriteLine("First decrement: " + value);

// Subtraction assignment:
value -= 1;
Console.WriteLine("Second decrement: " + value);

// Decrement operator:
value--;
Console.WriteLine("Third decrement: " + value);
```

```
First increment: 2
Second increment: 3
Third increment: 4
First decrement: 3
Second decrement: 2
Third decrement: 1
```

And also, remember that you can use the increment and decrement operators before or after the variable:
```cs
int value = 1;
value++;                                    // Increment
Console.WriteLine("First: " + value);       // Increment
Console.WriteLine($"Second: {value++}");    // Output first, increment after
Console.WriteLine("Third: " + value);       // Increment
Console.WriteLine("Fourth: " + (++value));  // Increment first, output after
```

```
First: 2
Second: 2
Third: 3
Fourth: 4
```

**Note:** Be sure to recognize the difference between `value++` and `++value`.
