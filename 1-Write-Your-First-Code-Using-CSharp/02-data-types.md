# Store and Retrieve Data Using Literal and Variable Values in C#

TLDR; a lot of the same data types used in C++ are also used in C#.

For example, outputting literals
```cs
Console.WriteLine('a');         // char
Console.WriteLine("Hello!");    // string
Console.WriteLine(123);         // int
Console.WriteLine(0.25F);       // float
Console.WriteLine(2.625);       // double
Console.WriteLine(12.39816m);   // decimal
Console.WriteLine(true);        // bool
```

yields:
```
a
Hello!
123
0.25
2.625
12.39816
True
```

**Note**: The `F` and `m` are known as a *literal suffix*. They dictate to the compiler the data type you wish to specify.

And the same applies for declaring, initializing and outputting variables:
```cs
char userOption = 'a';
int gameScore = 123;
decimal particlesPerMillion = 12.39816m;
bool answer = false;

Console.WriteLine("Jimmy chose '" + userOption + "' and won " + gameScore + " points.");
Console.WriteLine("Alexandra was '" + answer + "' when she answered " + particlesPerMillion + " moles.");
```

```
Jimmy chose 'a' and won 123 points.
Alexandra was 'False' when she answered 12.39816 moles.
```

`var` is a special data type that creates an implicitly typed local variable when initialized.

Examples:
```cs
var message = "Hello world!";   // Implicitly declares variable of type 'string'
message = 10.703m;              // This line gives an error since strings cannot be reinitialized with non-strings
```

```cs
var message;                    // This line gives an error since "Implicitly typed local variables must be initialized"
```