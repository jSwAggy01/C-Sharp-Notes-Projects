# Modify the Content of Strings Using Built-In String Data Type Methods in C#

In this section, I learned how to utilize various `string` helper methods such as: `Index()`, `LastIndexOf()`, `IndexOfAny()`, `Remove()`, and `Replace()`. I then constructed a program to extract specific data from HTML code by utilizing a combination of each technique. This allowed me to internalize and understand their implementation, as well as establish conceptual knowledge for how these methods behave.

1. [`IndexOf()`](#indexof-method)
2. [`LastIndexOf()`](#lastindexof-method)
3. [`IndexOfAny()`](#indexofany-method)
4. [`Remove()`](#remove-method)
5. [`Replace()`](#replace-method)
6. [**<ins>Code Challenge</ins>**: Extracting data from HTML](#code-challenge-extracting-data-from-html)

## `IndexOf()` Method
```cs
/* IndexOf() Method */
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
/* Output:
between the tags
*/
```

## `LastIndexOF()` Method
```cs
/* LastIndexOf() Method */
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
/* Output:
set of parentheses
*/
```

## `IndexOfAny()` Method
```cs
/* IndexOfAny() Method */
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
/* Output:
Searching THIS Message: Help (find) the {opening symbols}
Found WITHOUT using startPosition: (find) the {opening symbols}
Found WITH using startPosition 5:  (find) the {opening symbols}
*/
```

## `Remove()` Method
```cs
/* Remove() Method */
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
/* Output:
123455000  3
*/
```

## `Replace()` Method
```cs
/* Replace() Method */
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
/* Output:
This is example data
*/
```

## **<ins>Code Challenge</ins>**: Extracting data from HTML
```cs
/* Code Challenge: Extracting data from HTML */
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string output = "";

/* Your work here */
const string openSpan = "<span>";
const string closeSpan = "</span>";

// (1) Extract the text between 'span' tags
int openingPosition = input.IndexOf(openSpan) + openSpan.Length;
int closingPosition = input.IndexOf(closeSpan);
int length = closingPosition - openingPosition;

quantity = input.Substring(openingPosition, length);
quantity = $"Quantity: {quantity}";

// (2) Remove 'div' tags
const string openDiv = "<div>";
const string closeDiv = "</div>";

output = input.Remove(0, openDiv.Length);
output = output.Remove(output.Length - closeDiv.Length);
output = $"Output: {output}";

// (3) Replace special characters
output = output.Replace("&trade;", "&reg;");
/* ----------------- */

Console.WriteLine(quantity);
Console.WriteLine(output);
/* Output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/
```