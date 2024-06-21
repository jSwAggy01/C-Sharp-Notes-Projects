# Project Overview

In this second part to the *Contoso Pets Application*, I was tasked with independently implementing additional features that ensured data completeness by modifying existing data via the use of selection, decision, and iteration statements. In short, I implemented functionality for features 3 and 4.

<ins>**Source code**</ins>: [here!](FinalProjects/ChallengeProject/Starter/Program.cs)

## Specifications

- **Part I**: Build feature to ensure animal ages and physical descriptions are complete
    - Be enabled inside the appropriate application branch (must not overwrite the code in the code branch for menu option 2).
    - Skip over any animal in the ourAnimals array when the value of pet ID is set to the default value.
    - Display the pet ID value and prompt the user for an updated data value if ourAnimals array data is missing or incomplete.
    - Ensure that a valid numeric value is assigned to animalAge for all animals in the ourAnimals array that have assigned data.
    - Ensure that a valid string is assigned to animalPhysicalDescription for all animals in the ourAnimals array that have assigned data.
    - Enforce the following validation rules for animalAge.
    - It must be possible to convert the value entered to numeric data type.
    - Enforce the following validation rules for animalPhysicalDescription:
        - Values cannot be null.
        - Values cannot have zero characters.
        - Any further restriction is up to the developer.
    - Inform the application user when all data requirements are met, pausing the application to ensure the message can be seen and responded to.
- **Part II**: Build feature to ensure animal nicknames and personality descriptions are complete
    - Be enabled inside the appropriate application branch (must not overwrite the code in the code branch for menu option 2).
    - Skip over any animal in the ourAnimals array when the value of pet ID is set to the value default value.
    - Display the pet ID value and prompt the user for an updated data value if ourAnimals array data is missing or incomplete.
    - Ensure that a valid string is assigned to animalNickname for all animals in the ourAnimals array that have assigned data.
    - Ensure that a valid string is assigned to animalPersonalityDescription for all animals in the ourAnimals array that have assigned data.
    - Enforce the following validation rules for petNickname and petPersonalityDescription:
        - Values cannot be null.
        - Values cannot have zero characters.
        - Any further restriction is up to the developer.
    - Inform the application user when all data requirements are met, pausing the application to ensure the message can be seen and responded to.

## Sample Output

```
Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Add a new animal friend to the ourAnimals array
 3. Ensure animal ages and physical descriptions are complete        
 4. Ensure animal nicknames and personality descriptions are complete
 5. Edit an animal’s age
 6. Edit an animal’s personality description
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

Press the Enter key to continue

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
Enter an age for ID #: c4
1
Enter a physical description for ID #: c4 (size, color, breed, gender, weight, housebroken)
so ugly it's cute, loves to spin around

Age and physical description fields are complete for all of our friends.
Press the Enter key to continue

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
4
Enter a nickname for ID #: c4
snowflake
Enter a personality description for ID #: c4 (likes or dislikes, tricks, energy level) 
loves to curl up in a warm spot

Nickname and personality description fields are complete for all of our friends.       
Press the Enter key to continue

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

## Features Implemented

### **<ins>Feature 3</ins>**: Ensure animal ages and physical descriptions are complete

```cs
case "3":
            // Ensure animal ages and physical descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 2] == "Age: ?")
                    {
                        do
                        {
                            Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();
                        }
                        while (int.TryParse(readResult, out _) == false);

                        ourAnimals[i, 2] = "Age: " + readResult;
                    }
                    if (ourAnimals[i, 4] == "Physical description: " || ourAnimals[i, 4] == "Physical description: tbd")
                    {
                        do
                        {
                            Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)");
                            readResult = Console.ReadLine();

                            if (String.IsNullOrEmpty(readResult) || readResult.TrimStart().Length < 1)
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                        while (validEntry == false);

                        ourAnimals[i, 4] = "Physical description: " + readResult;
                    }
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue");
            readResult = Console.ReadLine();

            break;
```

### **<ins>Feature 4</ins>**: Ensure animal nicknames and personality descriptions are complete

```cs
case "4":
            // Ensure animal nicknames and personality descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 3] == "Nickname: " || ourAnimals[i, 3] == "Nickname: tbd")
                    {
                        do
                        {
                            Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();

                            if (String.IsNullOrEmpty(readResult) || readResult.TrimStart().Length < 1)
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                        while (validEntry == false);

                        ourAnimals[i, 3] = "Nickname: " + readResult;
                    }
                    if (ourAnimals[i, 5] == "Personality: " || ourAnimals[i, 5] == "Personality: tbd")
                    {
                        do
                        {
                            Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                            readResult = Console.ReadLine();

                            if (String.IsNullOrEmpty(readResult) || readResult.TrimStart().Length < 1)
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                        while (validEntry == false);

                        ourAnimals[i, 5] = "Personality: " + readResult;
                    }
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue");
            readResult = Console.ReadLine();

            break;
```

## Learning Outcomes

Designing the solution for feature 3 took quite a bit of time to figure out the logic to translate the user request since I wanted to do further research to figure out what methods I could implement to handle specific test cases, instead of just creating a function from stratch which would take significantly more time. In this manner, I was able to decrease my development time by 40% and get it done within just a couple of hours after having read doucmentation on the appropriate methods to use for my application. Since feature 4 performed a similar function, I simply implemented the same boilerplate code with slight modifications, adjusting for the input, which further improved development time.

## Conclusion

All in all, this challenge project demonstrated:
- logical problem-solving
- input data validation
- user requirements satisfaction
- ability to design, translate, and implement program specifications
- ingenuity for researching solutions by reading documentation to decrease development time

All of which, are fundamental components in the software development process.