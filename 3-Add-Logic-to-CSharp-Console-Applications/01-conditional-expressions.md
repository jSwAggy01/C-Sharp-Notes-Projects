# Evaluate Boolean Expressions to Make Decisions in C#

## Basics

Decision logic works pretty much the same way you'd expect it to work in any other programming language.

- `==` - equivalent to
- `!=` - inequivalent to
- `>=` - greater than or equal to
- `<=` - less than or equal to
- `>` - greater than
- `<` - less than

You can use these operators to make comparisons in if-related statements or even new-fangled **conditional expressions**.

## Conditional Expressions

A **conditional expression** is a type of comparison that can be made explicitly inside the definition of a variable or declaration of an output statement.

```cs
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;    // This is a conditional expression!
Console.WriteLine($"Discount: {discount}");
```

Note that the conditional operator `?` is used to declare the conditional expression and the `:` is used to declare the `else` value.

The format goes as follows:

<**Evaluate this condition(s)**> `?` <**return this value if TRUE**> `:` <**return this value if FALSE**>.

And so, an example would look something like this,

```cs
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
```

where the output will be *heads* if `flip == 0` is **TRUE** or *tails* if `flip == 0` is **FALSE**.

Here's another example in which the use of **conditional expressions** in *Exhibit A* greatly reduces the amount of lines of code needed to achieve the same result.

```cs
// Exhibit A: Clean, readable, less lines
if (permission.Contains("Admin"))
{
    Console.WriteLine((level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine((level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// Exhibit B: Clean, readable, more lines
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
```

**Note**: Readability and the '*cleaner*' code in this scenario is often subjective to the team or an individual developer's preferences.