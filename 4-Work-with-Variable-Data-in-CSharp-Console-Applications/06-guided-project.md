# Project Overview

The objective of this project was to add additional functionality to the *Contoso Pets Application* that we have consistently worked on throughout the entirety of this course. For this section, we did a bit of output formatting, data conversions, and string interpolation. All of which demonstrated industry software engineering practices by being able to implement additional functionality and features to a pre-existing application.

More technically, we practiced our ability to:
- Apply iteration statements to gather data input.
Use data processing.
- Format data output.
- Choose the correct data types and safely convert data types.
- Manipulate number, string and character arrays, as well as add, remove, and sort data.
- Modify and build complex strings from multiple data sources, and format data for display across regions.

<ins>**Source code**</ins>: [here!](FinalProjects/GuidedProject/Starter/Program.cs)

## Specifications

- **Part I**: Build feature to search for specified dog attribute
    - Gather input for the pet characteristic search term
    - Loop through the animals array and identify "dogs"
    - For each dog, combine the physical and personality descriptions to search
    - Search the combined description for the input term match
    - Output the dogs that have a term match
- **Part II**: Build feature to suggest donation data amount
    - Define `suggestedDonation` string
    - Expand the `ourAnimals` array to contain `suggestedDonation` and populate sample data for `suggestedDonation`
    - Ensure all usage of `ourAnimals` array accounts for the added `suggestedDonation` data
    - Output `suggestedDonation` with regional currency symbol ($, €, ¥,... )

## Sample Output

```
Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
1

ID #: d1
Species: dog
Age: 2
Nickname: lola
Physical description: medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.
Personality: loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.Suggested Donation: $85.00

ID #: d2
Species: dog
Age: 9
Nickname: gus
Physical description: large reddish-brown male golden retriever weighing about 85 pounds. housebroken.
Personality: loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.
Suggested Donation: $49.99

ID #: c3
Species: cat
Age: 1
Nickname: snow
Physical description: small white female weighing about 8 pounds. litter box trained.
Personality: friendly
Suggested Donation: $40.00

ID #: c4
Species: cat
Age: 3
Nickname: Lion
Physical description: Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.
Personality: A people loving cat that likes to sit on your lap.
Suggested Donation: $45.00

Press the Enter key to continue

Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
2

Enterone desired dog characterristics to search for
golden

Our dog Nickname: lola is a match!
Physical description: medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.
Personality: loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.
Our dog Nickname: gus is a match!
Physical description: large reddish-brown male golden retriever weighing about 85 pounds. housebroken.
Personality: loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.

Press the Enter key to continue.

Welcome to the Contoso PetFriends app. Your main menu options are:
 1. List all of our current pet information
 2. Display all dogs with a specified characteristic

Enter your selection number (or type Exit to exit the program)
exit
```
