# Create C# Methods that Return Values

In this section I learned the fundamental principles of writing methods otherwise known as functions in C#. The gist of the principles are pretty much the same for every language, however in C#, it is not necessary to declare the method before defining it. In this manner, you can use methods inside of other methods no matter what order they are written in. Below are the exercises that helped demonstrate these principles:

1. **Exercises**:
    - [Calculating total price](#exercise-calculating-total-price)
    - [Return numbers from methods](#exercise-return-numbers-from-methods)
    - [Return strings from methods](#exercise-return-strings-from-methods)
    - [Return booleans from methods](#exercise-return-booleans-from-methods)
    - [Return arrays from methods](#exercise-return-arrays-from-methods)
2. **Code Challenge**:
    - [Add methods to make the game playable](#code-challenge-add-methods-to-make-the-game-playable)

## <ins>Exercise</ins>: Calculating total price
```cs
/* Exercise: Calculating total price */
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}
/* Output:
Total: $44.58
*/
```

## <ins>Exercise</ins>: Return numbers from methods
```cs
/* Exercise: Return numbers from methods */
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
/* Output:
$23.73 USD = $557655 VND
$557655 VND = $23.73 USD
*/
```

## <ins>Exercise</ins>: Return strings from methods
```cs
/* Exercise: Return strings from methods */
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i>= 0; i--)
    {
        result += word[i];
    }
    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}
/* Output:
there are snakes at the zoo
ereht era sekans ta eht ooz
*/
```

## <ins>Exercise</ins>: Return booleans from methods
```cs
/* Exercise: Return booleans from methods */
string[] words = {"racecar", "talented", "defied", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}
/* Output:
Is it a palindrome?
racecar: True  
talented: False
defied: False  
tent: False    
tenet: True 
*/
```

## <ins>Exercise</ins>: Return arrays from methods
```cs
/* Exercise: Return arrays from methods */
int target = 30;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine("Change found at postitions:");
    for (int i = 0; i< result.GetLength(0); i++)
    {
        if (result[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result[i, 0]}, {result[i, 1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
/* Output:
Change found at postitions:
0, 3
0, 4
1, 3
1, 4
3, 6
*/
```

## <ins>Code Challenge</ins>: Add methods to make the game playable
```cs
/* Code Challenge: Add methods to make the game playable */
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = SetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? input = "";

    do
    {
        input = Console.ReadLine();
    }
    while (input == null);

    if (input[0] == 'y' || input[0] == 'Y')
    {
        return true;
    }
    return false;
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}

int SetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}
/* Output:
Would you like to play? (Y/N)
y
Roll a number greater than 3 to win!
You rolled a 4
You win!

Play again? (Y/N)
y
Roll a number greater than 2 to win!
You rolled a 6
You win!

Play again? (Y/N)
Y
Roll a number greater than 4 to win!
You rolled a 1
You lose!

Play again? (Y/N)
N
*/
```