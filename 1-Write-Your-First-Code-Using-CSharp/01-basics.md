# Write Your First C# Code 

C# is essentially Microsoft's version of C++. It is considered a high-level programming language, whereas C++ is more low-level by today's standards since it has no automatic memory management. This is also save for the fact that the definition for what a low-level programming language is, has changed since its inception in computer science.

## Basic Syntax

C# is very similar to C++ from an object-oriented programming standpoint, save for some syntactical differences.

**C++**
```cpp
int main()
{
    cout << "Hello world!"<< endl;
}
```

**C#**
```cs
Console.WriteLine("Hello world!");
```

**Note**: Both lines of code do the exact same thing of outputting the text and then appending a new line directly after.

## Basic Output

`Console.WriteLine(...)` - appends a new line after the output

`Console.Write(...)` - appends the output to the existing line

For example, the code
```cs
Console.Write("Hello!");
Console.WriteLine("Hello world!");
Console.Write("Hello back!");
```

produces the output:
```
Hello!Hello world!
Hello back!
```

**Note**: `Console` is the class and `WriteLine()` is the method within that class.