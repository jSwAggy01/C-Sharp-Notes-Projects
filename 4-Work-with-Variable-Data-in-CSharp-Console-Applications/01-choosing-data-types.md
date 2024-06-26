# Choosing the Correct Data Type in Your C# Code

When choosing which data type to implement in your program, it's important to consider the impact that it will have on your computer's resources as well as the data you wish to store in it.

## Value Types v. Reference Types

### Data and Bits

There are many different ways to define data given the context. However, for simplicity, we will define data in terms of software development.

In essence, **data** refers to a value that is stored in the computer's memory as a series of bits. Additionally, a **bit** is a binary switch, represented simply as a `0` or `1`; "off" or "on".

Given this fact, we can use bits to represent just about anything in a computer, since computers can only interpret `0`s or `1`s. Likewise, if we wanted to represent the number `97` using only `0`s and `1`s, we could do something like this to represent it in a computer.

```cs
128     64      32      16      8       4       2       1
---------------------------------------------------------
0       1       1       0       0       0       0       1
```

`64 + 32 + 1 = 97`. Therefore, `01100001` = `97` (ASCII).

Even though you'll likely never need to manually do this conversion, it's important to understand that bits can be used in such a way to represent data.

All of this to say, when choosing a data type, it's important to consider the implications of how it is stored in bits.

### Value v. Reference Types

Now, we can explicitly define the importance of choosing the correct data type for our needs.

For C#, there are two kinds of types:
1. Reference types
2. value types

The difference between the two is pretty simple:
- Variables of **reference type** store references to their data (objects).
- Variables of **value type** directly contain their data.

**Example**:

Think about a house and the address of a house. A house contains you, your family, and your possessions. From the context of computers, your house contains *data*. However, let's say I'm at the post office and I need to know where your house is to send you mail. And so, I don't need to be in front of your house to know where it is, I can simply *reference* your address and send you your mail.

And that's essentially the difference between variables of type **reference** and **value**.

## Integral Types

An **integral type** is a numerical value type that represents whole numbers with no fractions. The two subcategories being: **signed** and **unsigned** integral types, which means an equal set of both positive and negative numbers, and a set of non-negative numbers only, respectively.

Common integral types include: `byte`, `long`, and `int`.

Each type can represent a different set of values. For example, here is a list of integral types and the range of values that they can store.
```
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615
```

Depending on your needs, you should consider what type to use based on the data you are trying to represent, as this will have an impact on your program's performance, and your computer's overall resource consumption.

For more on integral numeric types, visit:
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

## Floating-point Types

A **floating-point** is a simple numerical value type that takes into account **precision**; in this case, the number of value places stored after the decimal point. This is important when considering how the precision will affect the accuracy, per say, in any kind of critical calculation. Additionally, the range of numbers that a particular floating-point type holds is not neccessarily indicative of its precision.

For example,
```cs
Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
```

Here we can see that `decimal` is the most precise floating-point type, whereas `float` and `double` are less precise, but can hold much larger range of values.

**Note**: The range of numbers that a **floating-point** type holds is not necessarily indicative of its precision.

## Reference Types

As stated prior, reference types store a *reference* to their data.

### Integer Reference Types

For example, to declare a reference of type variable, we can do this,
```cs
int[] data;
data = new int[3];
```
or this,
```cs
int[] data = new int[3];
```

Either way, each construct declares an `int` array called `data` of size `3` in memory. Upon compilation, a memory address of the new `int` array is returned, and stored in the variable `data`. Lastly, `int` array's elements default to the value `0` since that is the default value of `int`.

### String Reference Types

With regards to character types, the `string` data type is also inherently a reference type.

What a `string` actually does is store a series of individual characters within a `char` array. However, this stuff happens behind-the-scenes depending on what programming language you are using. In this case, the designers of C# take care of it all behind the scenes.

For example,
```cs
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);
```

You'd think we'd need to declare the `new` operator to declare a reference of type `string`, but in this case, the designers of C# have made it such that we don't have to.

Behind the scenes, however, a new instance of `System.String` is being created and intialized to "Hello World!".

### Quick Summary
```cs
// Value v. Reference Types
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}\n");

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Referenece Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");
/* Output:
--Value Types--
val_A: 2
val_B: 5

--Referenece Types--
ref_A[0]: 5
ref_B[0]: 5
*/
```