# Iterate Through a Code Block Using the for Statement in C#

The `for` loop statement is one of the most fundamental structures in any programming language. It is distinct from the `foreach` construct because it allows for the direct manipulation of iteration throughout an array.

## Use Cases

Knowing when, where, and what situations to use either construct is essential when considering how they will be implemented.

Compare these two example:
```cs
// `for` construct: modified to write names backwards
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// `foreach` construct: cannot be modified, only forwards
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
```

As we can see, it is possible to modify how, where, and what we do when iterating throughout an array with a `for` loop construct. However, we are limited in doing so with a `foreach` construct.

It should also be noted that it is not possible to directly modify the data within an array, utilizing `foreach` constructs.
```cs
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
```

As you will get this error:
```
Cannot assign to name because it is a 'foreach iteration variable'
```

To overcome this limitation, we can combine the two constucts to form a solution like this:
```cs
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
        break;
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
```
```
Alex
Eddie
Sammy
Michael
```

**Note**: The `break` keyword can be used to exit the looping statement without having to iterate through all the elements of the array.

## Incrementing and Decrementing
Another unique trait of `for` loops is that you can change the way in which you iterate throughout the array by modifying the third arguement in the looping condition.
```cs
// Increments of three:
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
```
```
0
3
6
9
```

```cs
// Decrements of one:
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
```
```
10
9
8
7
6
5
4
3
2
1
0
```

## Learning Outcomes

In this section, I was able to gain a proficient understanding of how to increment and decrement `for` loops in order to access and output various kinds of data at different intervals. Below is a *coding challenge* that I completed in order to internalize the information I had learned about implementing and understanding the behavior of the `for` looping construct.

```cs
/* Fizzbuzz Challenge!
    Goal: Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
    Specifications:
        - When the current value is divisible by 3, print the term Fizz next to the number.
        - When the current value is divisible by 5, print the term Buzz next to the number.
        - When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
*/

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else
        Console.WriteLine(i);
}
```
```
1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
.
.
.
```