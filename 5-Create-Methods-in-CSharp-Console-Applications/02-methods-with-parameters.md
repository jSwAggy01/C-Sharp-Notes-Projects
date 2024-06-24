# Create C# Methods with Parameters

In this section, I learned about the variable scope of methods, named and optional parameters, as well as the differences between pass by reference and pass by value during method calls.

Below are the exercises I did to demonstrate these principles.

1. **Exercises**:
    - [Using parameters in methods](#exercise-using-parameters-in-methods)
    - [Method variables precede global variables](#exercise-method-variables-precede-global-variables)
    - [Calling methods within methods](#exercise-calling-methods-within-methods)
    - [Pass by value](#exercise-pass-by-value)
    - [Pass by reference (arrays)](#exercise-pass-by-reference-arrays)
    - [Pass by reference (strings)](#exercise-pass-by-reference-strings)
    - [Methods with named arguements and optional parameters](#exercise-methods-with-named-arguements-and-optional-parameters)
2.  **Code Challenge**:
    - [Add a method to display emaill addressess](#code-challenge-add-a-method-to-display-email-addresses)

## <ins>Exercise</ins>: Using parameters in methods
```cs
/* Exercise: Using parameters in methods */
int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;

    if (Math.Abs(newGMT) > 12|| Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
/* Output:
800 -> 2000
1200 -> 0  
1600 -> 400
2000 -> 800
*/
```

## <ins>Exercise</ins>: Method variables precede global variables
```cs
/* Exercise: Method variables precede global variables */
string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}
/* Output:
Jenna, Ayesha, Carlos, Viktor, 
Robert, Vanya,
*/
```

## <ins>Exercise</ins>: Calling methods within methods
```cs
/* Exercise: Calling methods within methods*/
double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}
/* Output:
Circle with radius 12
Area = 452.38896
Circumference = 75.39815999999999 
Circle with radius 24
Area = 1809.55584
Circumference = 150.79631999999998
*/
```

## <ins>Exercise</ins>: Pass by value
```cs
/* Exercise: Pass by value */
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}
/* Output:
inside Multiply method: 3 x 4 = 12
global statement: 3 x 4 = 0
*/
```

## <ins>Exercise</ins>: Pass by reference (arrays)
```cs
/* Exercise: Pass by reference (arrays) */
int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}
/* Output:
1 2 3 4 5 
0 0 0 0 0
*/
```

## <ins>Exercise</ins>: Pass by reference (strings)
```cs
/* Exercise: Pass by reference (strings) */
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
/* Output:
Start: Healthy
Middle: Unhealthy
End: Unhealthy
*/
```

## <ins>Exercise</ins>: Methods with named arguements and optional parameters
```cs
/* Exercise: Methods with named arguements and optional parameters */
string[] guestList = {"Rebecca","Nadia","Noor","Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
/* Output:
Sorry, Tony is not on the guest list

Total RSVPs:
Name: Rebecca,  Party Size: 1,  Allergies: none       
Name: Nadia,    Party Size: 2,  Allergies: Nuts       
Name: Linh,     Party Size: 2,  Allergies: none       
Name: Noor,     Party Size: 4,  Allergies: none       
Name: Jonte,    Party Size: 2,  Allergies: Stone fruit
*/
```

## <ins>Code Challenge</ins>: Add a method to display email addresses
```cs
/* Code Challenge: Add a method to display email addresses */
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string corporateDomain = "contoso.com";
string externalDomain = "hayworth.com";

DisplayEmailAddresses(corporate, corporateDomain);
DisplayEmailAddresses(domainName: externalDomain, employeeList: external);

void DisplayEmailAddresses(string[,] employeeList, string domainName)
{
    for (int i = 0; i < employeeList.GetLength(0); i++)
    {
        string emailAddress = "";
        emailAddress = employeeList[i, 0][..2] + employeeList[i, 1] + "@" + domainName;
        emailAddress = emailAddress.ToLower();
        Console.WriteLine(emailAddress);
    }
}
/* Output:
robavin@contoso.com
sibright@contoso.com   
kisinclair@contoso.com 
aakamath@contoso.com   
sadelucchi@contoso.com 
siali@contoso.com      
viashton@hayworth.com  
codysart@hayworth.com  
shlawrence@hayworth.com
davaldes@hayworth.com  
*/
```
