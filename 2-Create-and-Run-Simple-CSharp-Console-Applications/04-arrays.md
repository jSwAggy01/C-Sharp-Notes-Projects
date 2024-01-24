# Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#

Arrays are essentially special variables that can hold multiple elements and types of data.

## Basics

### Declaring an Array

```cs
string[] fraudulentOrderIDs = new string[3];
```

The `[]` is the syntax used to declare the array variable type. Which is then followed by the variable name `fraudulentOrderIDs` and the `new` operator which specifies a new instance of an array in the computer's memory. The variable is then declared again along with the number of elements that the array will hold, `[3]`.

### Initializing an Array

```cs
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
```

**Note**: The index of an array always starts at `[0]`.

However, if you try to initialize an additional element `[3]`, that will exceed the capacity of elements in the array and you will get an error that will look similar to this:

```
Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.     
   at Program.<Main>$(String[] args) in C:\Users\someuser\Desktop\CsharpProjects\TestProject\Program.cs:line 6
```

