# Perform Basic String Formatting in C#

Fomatting for aesthetic's sake.

## Escape Sequences

`\` - an *escape character sequence* instruction to the runtime

For example,
```cs
Console.WriteLine("Hello\nWorld!");     // Adds a new line
Console.WriteLine("Hello\tWorld!");     // Adds a tab
```

yields:
```
Hello
World!
Hello   World!
```

Escape sequences are also useful when you want to add symbols that would otherwise confuse the compiler.

**C#**
```cs
// Symbols such as:
Console.WriteLine("Hello \"World\"!");      // quotation marks
Console.WriteLine("c:\\source\\repos");     // back slashes
```

**Output**
```
Hello "World"!
c:\source\repos
```

## Verbatim String Literals

As the name suggests, *verbatim string literals* `@"..."` will keep all special symbols, characters, as well as whitespace without the need for escape sequences.

For example,
```cs
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
```

produces:
```
c:\source\repos    
        (this is where your code goes)
```

In addition, escape sequences can also be used to add encoded characters.

**C#**
```cs
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");     // Kon'nichiwa World
```

**Output**
```
こんにちは World!
```

And, the two can also be combined to produce something like this:

**C#**
```cs
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
```

**Output**
```
Generating invoices for customer "Contoso Corp" ...

Invoice: 1021            Complete!
Invoice: 1022            Complete!

Output Directory:
c:\invoices

日本の請求書を生成するには：
    c:\invoices\app.exe -j
```

**Note**: Not all consoles support unicode characters.

## Combining Strings Using Concatenation

String concatenation is pretty much like the concatenation of variables and symbols if you can recall *Automata and Formal Languages*. It's essentially appending things to the back of other things.

For example,
```cs
string firstName = "Bob";                       // 1st variable
string message = "Hello " + firstName + "!";    // 2nd variable + 1st variable?
Console.WriteLine(message);                     // Output
```

yields:
```
Hello Bob!
```

This will also produce the same output:
```cs
string firstName = "Bob";                               // 1st variable
string greeting = "Hello";                              // 2nd variable
string message = greeting + " " + firstName + "!";      // Extra variable?
Console.WriteLine(message);                             // Output
```

```
Hello Bob!
```

But akin to "useless symbols" in *Automata and Formal Languages*, it is generally considered bad practice because we used an extra or **intermediate** variable to hold the entire display message.
```cs
string message = greeting + " " + firstName + "!";      // Extra variable? (Intermediate variable)
```

When we could have easily just did this:
```cs
string firstName = "Bob";                               // 1st variable
string greeting = "Hello";                              // 2nd variable
Console.WriteLine(greeting + " " + firstName + "!");    // Output
```

```
Hello Bob!
```

Of which, is much cleaner and more human-friendly to read.

## Combining Strings Using Interpolation

String interpolation is almost like vebatim string concatenation.

For example,
```cs
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
```

can more concisely be written like this:
```cs
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
```

to produce the same result.
```
Hello Bob!
```

Except in this manner, we are more efficient by not having to type in the `+` signs to explicitly concatenate everything in the output.

This technique is called an **string interpolation**, which is constructed by adding the `$` prefix in front of `"..."`, in which we can then use `{...}` within the string literal.

Additionally, you can also use **verbatim literals** with **string interpolation**, as demonstrated below:
```cs
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

```
C:\Output\First-Project\Data
```

**Note**: The `$` symbol allows you to reference the *interpolation expression* `projectName`, while the `@` symbol allows you to use a **verbatim literal string** that enables `\` to be an unescaped character.