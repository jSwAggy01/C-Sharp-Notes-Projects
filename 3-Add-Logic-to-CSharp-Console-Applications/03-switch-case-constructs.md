# Branch the Flow of Code Using the switch-case Construct in C#

Sometimes when `if-elseif-else` statements aren't optimal, you can instead use alternative **switch-case constructs**, of which fall into two categories:
1. Switch Statements
2. Switch Expressions

## Switch Statements

**Switch statements** are kind of like `if-elseif-else` statements save for the fact that the former can be written more elegantly, improve readability, and decrease the amount of lines of code needed to perform the same function(s) as the latter.

The syntax of which, goes something like this:
```cs
switch (fruit)
{
    case "apple":
        cost = 5;
        break;
    case "banana":
        cost = 2;
        break;
    case "cherry":
        cost = 1;
        break;
    default:
        cost = 0;
        break;
}
```

In this example, `fruit` is the variable that is used as the comparison during the `case` calls, followed by whatever you want your code to do. At the end, a `break` keyword is required to denote the end of every switch section. Additonally, you can add a `default` condition, which is functionally equivalent to an `else` statement. And of course, a switch construct is declared utilizing a `switch` keyword. And depending on how you format the syntax, will determine the type of switch-case construct that is declared.

**Notes**:
- Switch sections must always end with a `break` or `return` keyword, otherwise the compiler will generate an error.
- It doesn't matter where the `default` branch is positioned within the section (unlike an `else` statement).
- It also doesn't matter if a `default` branch is excluded altogether.

## Switch Expressions

**Switch expressions** are functionally equivalent to switch statements, but unlike the redundant syntax of `switch` and `if-elseif-else` statements, **switch expressions** can be written with even more clarity, less lines of code, and further elegance.

An expression equivalent to the previous example would be:
```cs
cost = fruit switch
{
    "apple" => 5,   // Case 1
    "banana" => 2,  // Case 2
    "cherry" => 1,  // Case 3
    _ => 0,         // Default
};
```

Observe that the new syntax concisely eliminates the redundancy of having to declare the same keywords over-and-over.

## Comparing all Three: (A) if-elseif-else v. (B) switch statements v. (C) expressions

```cs
// SKU = Stock Keeping Unit.
// SKU value format: <product #>-<2-letter color code>-<size code>
using System.Data.SqlTypes;

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

/* Exhibit A: if-elseif-else statements, ol' reliable */
if (product[0] == "01")
    type = "Sweat shirt";
else if (product[0] == "02")
    type = "T-Shirt";
else if (product[0] == "03")
    type = "Sweat pants";
else
    type = "Other";

if (product[1] == "BL")
    color = "Black";
else if (product[1] == "MN")
    color = "Maroon";
else
    color = "White";

if (product[2] == "S")
    size = "Small";
else if (product[2] == "M")
    size = "Medium";
else if (product[2] == "L")
    size = "Large";
else
    size = "One Size Fits All";

/* Exhibit B: switch statements, clean but redundant */
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

/* Exhibit C: switch expressions, clean and elegant */
type = product[0] switch
{
    "01" => "Sweat shirt",
    "02" => "T-shirt",
    "03" => "Sweat pants",
    _ => "Other",
};

color = product[1] switch
{
    "BL" => "Black",
    "MN" => "Maroon",
    _ => "White",
};

size = product[2] switch
{
    "S" => "Small",
    "M" => "Medium",
    "L" => "Large",
    _ => "One Size Fits All",
};

Console.WriteLine($"Product: {size} {color} {type}");
```

**Note:** It's up to the team or individual developer to decide which method would be more readable.