# Perform Operations on Arrays Using Helper Methods in C#

When working on any kind of development project, it's important try to be efficient with your code so that you don't spend more time than you need to on creating functionality from scratch. Likewise, we can utilize built-in helper methods to help us achieve these goals.

## Array Helper Methods

Here are some examples in which I implemented various array helper methods to organize and process item IDs, as well as formatting input by reversing and separating data within a string.

```cs
/* Array methods: Sort() and Reverse() */
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```
```
Sorted...
-- A11     
-- A13     
-- B12     
-- B14     

Reversed...
-- B14     
-- B12     
-- A13     
-- A11
```

```cs
/* Array Methods: Clear() and Resize() */
string[] pallets = { "B14", "A11","B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```
```
Clearing 2 ... count: 4
--
--
-- B12
-- A13

Resizing 6 ... count: 6
--
--
-- B12
-- A13
-- C01
-- C02

Resizing 3 ... count: 3
--
--
-- B12
```

```cs
/* String-char methods: ToCharArray(), Reverse(), Split(), and Join(,) */
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
```
```
3,2,1,c,b,a
3
2
1
c
b
a
```

## Coding Challenges

After studying and observing how these functions behaved, I was tasked with completing *coding challenges* in order to internalize the learning outcomes. Below are the exercises I completed that demonstrated proficient understanding of how to use helper methods when working with `char` and `string` arrays.

```cs
/* Code challenge 1: Reverse every word in a sentence */
string pangram = "The quick brown fox jumps over the lazy dog";

// 1: Save string into an array
char[] pangramArray = pangram.ToCharArray();

// 2: Reverse the array using Reverse()
Array.Reverse(pangramArray);

// 3: Save char array into a string
string reversedPangram = new string(pangramArray);

// 4: Split that string into an array of strings by spaces
string[] reversedPangramWords = reversedPangram.Split(' ');

// 5: Output that array of strings in reverse
for (int i = reversedPangramWords.Length - 1; i >= 0; i--)
{
    Console.Write(i >= 0 ? reversedPangramWords[i] + ' ' : "\n");
}
```
```
ehT kciuq nworb xof spmuj revo eht yzal god
```

```cs
/* Code Challenge 2: Sort elements within a string */
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// 1. Split the string into an array of strings by ','
string[] orders = orderStream.Split(',');

// 2. Sort the array using Array.Sort()
Array.Sort(orders);

// 3. Insert an error message for invalid order IDs
foreach (var order in orders)
{
    Console.WriteLine(order.Length != 4 ? $"{order}\t- Error" : $"{order}");
}
```
```
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
```

## Learning Outcomes

In this section, I was able to get a gauge of how to effectively use array helper methods as well as break down a complex problem into tangible steps in order to solve the problem incrementally.

This allowed me to really understand how to approach tackling complicated technical and logistical issues through decomposing the larger problem into actionable processes that can then be efficiently implemented.