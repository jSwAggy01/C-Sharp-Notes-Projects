# Call Methods From the .NET Class Library Using C#

Methods are akin to functions in C++. And in order to utilize them, we have to understand that there is a whole library that contains a method and or class to suite almost all of our programming needs. In this case, that would be the `.NET Class Library`.

**Note**: Should you ever need to find a particular method, the .NET Class Library, Google search, as well as developer forums and websites are all available to you.

## Creating a Class Instance

In order to create a class instance:
1. Define the type
2. Include the `new` operator
```cs
Random dice = new Random();
```

## Some Terminology

**Return value** - a value type returned by a method

**Parameter** - the variable that's being used inside the method

**Argument** - the value that's passed when the method is called

**Overloaded method** - a method that supports several implementations of the method, each with a unique method signature