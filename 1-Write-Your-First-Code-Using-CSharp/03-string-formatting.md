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
```cs
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
```cs
c:\source\repos    
        (this is where your code goes)
```

In addition, escape sequences can also be used to add encoded characters.

**C#**
```cs
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");     // Kon'nichiwa World
```

**Output**
```cs
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
```cs
Generating invoices for customer "Contoso Corp" ...

Invoice: 1021            Complete!
Invoice: 1022            Complete!

Output Directory:
c:\invoices

日本の請求書を生成するには：
    c:\invoices\app.exe -j
```

## Combining Strings Using Concatenation

String concatenation is pretty much like concatenation of variable and symbols if you can recall *Automata and Formal Languages*. It's essentially appending things to the back of other things.

For example,
```cs
string firstName = "Bob";                       // First variable
string message = "Hello " + firstName + "!";    // Second variable
Console.WriteLine(message);
```

yields:
```
Hello Bob!
```

This will produce the same output.

**C#**
```cs
string firstName = "Bob";                               // First variable
string greeting = "Hello";                              // Second variable
string message = greeting + " " + firstName + "!";      // Extra variable?
Console.WriteLine(message);
```

**Output**
```
Hello Bob!
```

But akin to "useless symbols" in *Automata and Formal Languages*, it is generally considered bad practice because we used an extra variable to hold the entire display message.
```cs
string message = greeting + " " + firstName + "!";      // Extra variable?
```

When we could have easily just did this.
```cs
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
```

```
Hello Bob!
```