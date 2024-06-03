# Project Overview

The objective of this project was to construct an application that implements a diverse assortment of selection and iteration statements in order to achieve the design goals of the *Contoso Pets Application*.

<ins>**Source code**</ins>: [here!](FinalProjects/GuidedProject/Starter/Program.cs)

## Specifications

- **Part I**: Perform clean-up, add mock features, build user interface
    1. <ins>Code review</ins>: review the contents of the Program.cs file.
    2. <ins>Sample data</ins>: convert the if-elseif-else structure to switch-case structure that improves readability.
    3. <ins>Menu loop</ins>: enclose the main menu and menu item selection in a loop that iterates until the user enters "exit".
    4. <ins>Menu selections</ins>: write the code for a switch-case structure that establishes separate code branches for each menu option.
    5. <ins>Code branches</ins>: write placeholder within the menu item branches that provides user feedback until app features are developed.
    6. <ins>Verification test</ins>: perform verification tests for the code that you develop in this exercise.
- **Part II**: Build feature to process and output data
    1. <ins>Outer loop</ins>: build the outer loop that iterates through the animals in the ourAnimals array.
    2. <ins>Data check</ins>: write code that checks for existing pet data and displays the pet ID if data exists for a pet.
    3. <ins>Inner loop</ins>: build an inner loop that displays all of the pet characteristics for pets with data assigned.
    4. <ins>Verification test</ins>: perform verification tests for the code that you develop in this exercise.
- **Part III**: Build feature to take in new data
    1. <ins>Calculate petCount</ins>: write code that counts the number of pets in the ourAnimals array that have assigned data.
    2. <ins>Conditional messages</ins>: write code to display message output when petCount is less than maxPets.
    3. <ins>Outer loop</ins>: build a loop structure that will be used for entering new ourAnimals array data.
    4. <ins>Exit criteria</ins>: write code that evaluates the exit condition for the "enter new ourAnimals array data" loop.
    5. <ins>Verification test</ins>: perform verification tests for the code you develop in this exercise.
- **Part IV**: Build feature to read, create, and save new data
    1. <ins>Read and validate species</ins>: build a loop and the inner code structure used to enter and validate the pet species.
    2. <ins>Construct pet ID</ins>: write the code that uses petCount and the species name to construct the petID value.
    3. <ins>Read and validate age</ins>: build a loop and the inner code structure used to enter and validate the pet's age.
    4. <ins>Read and validate physical description</ins>: build a loop and the inner code structure used to enter a physical description of the pet.
    5. <ins>Read and validate personality description</ins>: build a loop and the inner code structure used to enter a description of the pet's personality.
    6. <ins>ead and validate nickname</ins>: build a loop and the inner code structure used to enter a nickname for the pet.
    7. <ins>Verification test</ins>: perform verification tests for the code that you develop in this exercise.

## Sample Output

```
Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Add a new animal friend to the ourAnimals array
 3. Ensure animal ages and physical descriptions are complete
 4. Ensure animal nicknames and personality descriptions are complete        
 5. Edit an animal's age
 6. Edit an animal's personality description
 7. Display all cats with a specified characteristic
 8. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
1

ID #: d1
Species: dog
Age: 2
Nickname: lola
Physical description: medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.
Personality: loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.

ID #: d2
Species: dog
Age: 9
Nickname: loki
Physical description: large reddish-brown male golden retriever weighing about 85 pounds. housebroken.
Personality: loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.

ID #: c3
Species: cat
Age: 1
Nickname: Puss
Physical description: small white female weighing about 8 pounds. litter box 
trained.
Personality: friendly

ID #: c4
Species: cat
Age: ?
Nickname:
Physical description:
Personality:
Press the Enter key to continue.

Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Add a new animal friend to the ourAnimals array
 3. Ensure animal ages and physical descriptions are complete
 4. Ensure animal nicknames and personality descriptions are complete        
 5. Edit an animal's age
 6. Edit an animal's personality description
 7. Display all cats with a specified characteristic
 8. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
2
We currently have 4 pets that need homes. We can mangage 4 more.

Enter 'dog' or 'cat' to begin a new entry
dog
Enter the pet's age or enter ? if unknown
?
Enter a physical description of the pet (size, color, gender, weight, housebroken)

Enter a description of the pet's personality (likes or dislikes, tricks, energy level)

Enter a nickname for the pet
Gerry
Do you want to enter info for another pet (y/n)
n

Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Add a new animal friend to the ourAnimals array
 3. Ensure animal ages and physical descriptions are complete
 4. Ensure animal nicknames and personality descriptions are complete        
 5. Edit an animal's age
 6. Edit an animal's personality description
 7. Display all cats with a specified characteristic
 8. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
1

ID #: d1
Species: dog
Age: 2
Nickname: lola
Physical description: medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.
Personality: loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.

ID #: d2
Species: dog
Age: 9
Nickname: loki
Physical description: large reddish-brown male golden retriever weighing about 85 pounds. housebroken.
Personality: loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.

ID #: c3
Species: cat
Age: 1
Nickname: Puss
Physical description: small white female weighing about 8 pounds. litter box 
trained.
Personality: friendly

ID #: c4
Species: cat
Age: ?
Nickname:
Physical description:
Personality:

ID: d5
Species: dog
Age: ?
Nickname: gerry
Physical description: tbd
Personality: tbd
Press the Enter key to continue.

Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Add a new animal friend to the ourAnimals array
 3. Ensure animal ages and physical descriptions are complete
 4. Ensure animal nicknames and personality descriptions are complete        
 5. Edit an animal's age
 6. Edit an animal's personality description
 7. Display all cats with a specified characteristic
 8. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
3
Challenge Project - please check back soon to see progress.
Press the Enter key to continue.

Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Add a new animal friend to the ourAnimals array
 3. Ensure animal ages and physical descriptions are complete
 4. Ensure animal nicknames and personality descriptions are complete        
 5. Edit an animal's age
 6. Edit an animal's personality description
 7. Display all cats with a specified characteristic
 8. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
exit
```

## Additional Learning Outcomes

During the implementation of this application, I had to decide whether or not to implement `for` or `foreach` looping statements to process the data. The takeaway was to implement the `for` looping structure since the way our data was formatted was in the data structure of **multidimensional arrays**. This segways into the next concept I had to familiarize myself with.

### Multidimensional v. Jagged Arrays

The way I understand it, after having read copius amounts of documentation, is that **multidimensional arrays** are essentially arrays that can have more than one dimension. In the case of this application, a two-dimensional array was declared at the start of the program to store our data.

Line 17:
```cs
// multidimensional array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[8, 6];
```

Here, we can see that a `string[]` array is declared, initialized with the attributes of *8* `string` elements, each with *6* `string` items. The `,` inside of the `[]` represents another dimension you add to the initial one-dimensional array. To help clarify what's actually happening, we can visualize this 2-D **multidimensional array** as a matrix of *m x n* size, where *m = 8* and *n = 6*.

```cs
// 8 elements total, 6 items per element
    0   1   2   3   4   5
0   -   -   -   -   -   -
1   -   -   -   -   -   -
2   -   -   -   -   -   -
3   -   -   -   -   -   -
4   -   -   -   -   -   -
5   -   -   -   -   -   -
6   -   -   -   -   -   -
7   -   -   -   -   -   -
```

From here, the rows represent the *elements* in our 2D array, while the columns represent the *items* in those respective *elements*. It becomes a bit more difficult to visualize these constructs at higher dimensions, so for now let's just conclude with that.

Alternatively, there are similar constructs called **jagged arrays** and although this application did not use them, it's helpful to undestand why. **Jagged arrays** are in essence, arrays containing other arrays. And those arrays can be different sizes, unlike fixed **multidimensional arrays**. There are subtle differences in space and CPU usage, but that is the basic gyst. **Multidimensional arrays** were the better option in this case since our data contained a fixed amount of items.

For more info, visit https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays#jagged-arrays.

## Conclusion

In totality, we:
- designed an application
- built a user interface
- adhered to program specifications
- developed features to enter and validate data
- solved problems logically using applicable C# constructs
- read documentation on how to implement case-specific methods

All of which, demonstrate fundamental skills used in software development.