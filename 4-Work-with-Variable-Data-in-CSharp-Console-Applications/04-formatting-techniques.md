# Format Alphanumeric Data for Presentation in C#

Being able to present data in a clear and organized manner is an important skill for any developer. In this section, I learned how to present data through **composite formatting**, **string interpolation**, **padding and aligning output**, and **normalizing numerical values** such as currency, general numbers, and percentages; all in order to establish a foundational understanding of how to format and display alphanumeric data.

Below are some of the exercises and independent coding challenges that helped me internalize and develop a proficient understanding of how to utilize these techniques.
1. [Composite Formatting](#composite-fomatting)
2. [String Interpolation](#string-interpolation)
3. [Formatting Numbers](#formatting-numbers)
4. [Combining Formatting Techniques](#combining-techniques)
5. [<ins>Exercise</ins>: Displaying an invoice number using string interpolation](#exercise-displaying-an-invoice-number-using-string-interpolation)
6. [Padding and Aligning Output](#padding-and-aligning-output)
7. [<ins>Exercise</ins>: Formatting Output for a Legacy Payment System](#exercise-formatting-output-for-a-legacy-payment-system)
8. [<ins>Code Challenge</ins>: Generating personalized adverisements for clients](#code-challenge-generating-personalized-advertisements-for-clients)

## Composite Fomatting
```cs
/* Composite Formatting */
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}", first, second);
/* Output:
World Hello!
Hello Hello Hello
*/
```

## String Interpolation
```cs
/* String Interpolation */
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
/* Output:
Hello World!
World Hello!     
Hello Hello Hello
*/
```

## Formatting Numbers
```cs
/* Formatting Currency */
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
/* Output:
Price: $123.45 (Save $50.00)
*/
```

```cs
/* Formatting Measurements */
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
/* Output:
Measurement: 123,456.7891 units
*/
```

```cs
/* Formatting Percentages */
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
/*Output:
Tax rate: 36.79%
*/
```

## Combining Formatting Techniques
```cs
/* Combining Formatting Techniques */
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; // inserted
Console.WriteLine(yourDiscount);
/* Output:
You saved $7.56 off the regular $67.55 price.
*/
```

## <ins>Exercise</ins>: Displaying an invoice number using string interpolation 
```cs
/* Exercise: Displaying an invoice number using string interpolation */
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"    Sub Total: {subtotal:C}");
Console.WriteLine($"        Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");
/* Output:
Invoice Number: 1201
    Shares: 25.457 Product 
    Sub Total: $2,750.00   
        Tax: 15.83%        
    Total Billed: $3,185.19
*/
```

## Padding and Aligning Output
```cs
/* Padding and Aligning Output */
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
/* Output:
----Pad this
Pad this----
*/
```

## <ins>Exercise</ins>: Formatting Output for a Legacy Payment System
```cs
/* Exercise: Formatting Output for a Legacy Payment System */
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
/* Output:
1234567890123456789012345678901234567890
769C  Mr. Stephen Ortega       $5,000.00
*/
```

## <ins>Code Challenge</ins>: Generating personalized advertisements for clients
```cs
/* Code Challenge: Generating personalized advertisements for clients */
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.\n");
// -------------------

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage = $"{currentProduct.PadRight(20)}{currentReturn:P2}   {currentProfit:C2}\n{newProduct.PadRight(20)}{newReturn:P2}   {newProfit:C2}";
// -------------------

Console.WriteLine(comparisonMessage);

/* Output:
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be $63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00
Glorious Future     13.13%   $63,000,000.00
*/
```