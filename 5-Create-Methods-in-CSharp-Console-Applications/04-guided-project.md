# Project Overview

The purpose of this project was to construct an application that utlized methods to achieve a logistics task for a school field trip. We successfully broke down the task into smaller, modularized methods to create an organized and readable solution. As well as, effectively utilizing parameters and return types to accomplish this goal.

More technically, we:
- Created `void` and `string[,]` return methods to perform specific tasks
- Utilized methods that accept and require **optional parameters**
- Utilized values returned from methods

<ins>**Source code**</ins>: [here!](FinalProjects/GuidedProject/Program.cs)

## Steps

1. Outline the tasks in pseudo-code
2. Create a method to:
    - Shuffle an array

    ```cs
    void RandomizeAnimals()
    {
        Random random = new Random();

        for (int i = 0; i < pettingZoo.Length; i++)
        {
            int r = random.Next(i, pettingZoo.Length);

            string temp = pettingZoo[i];
            pettingZoo[i] = pettingZoo[r];
            pettingZoo[r] = temp;
        }
    }
    ```

    - Assign a group

    ```cs
    string[,] AssignGroup(int groups = 6)
    {
        string[,] result = new string[groups, pettingZoo.Length/groups];
        int start = 0;

        for (int i = 0; i < groups; i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = pettingZoo[start++];
            }
        }

        return result;
    }
    ```

    - Display the results
    ```cs
    void PrintGroup(string[,] group)
    {
        for (int i = 0; i < group.GetLength(0); i++)
        {
            Console.Write($"Group {i + 1}: ");
            for (int j = 0; j < group.GetLength(1); j++)
            {
                Console.Write($"{group[i, j]}  ");
            }
            Console.WriteLine();
        }
    }
    ```

## Sample Output
```
School A
Group 1: ostriches  pigs  kangaroos
Group 2: alpacas  goats  tortoises
Group 3: capybaras  chickens  emus
Group 4: llamas  iguanas  lemurs
Group 5: geese  rabbits  ponies
Group 6: ducks  sheep  macaws
School B
Group 1: tortoises  llamas  ostriches  ponies  kangaroos macaws
Group 2: emus  alpacas  sheep  lemurs  chickens  geese    
Group 3: iguanas  ducks  pigs  rabbits  goats  capybaras  
School C
Group 1: capybaras  macaws  lemurs  sheep  rabbits  goats emus ponies llamas
Group 2: alpacas  pigs  iguanas  ducks  ostriches  kangaroos  chickens tortoises geese
```

## Learning Outcomes

In conclusion, we were able to build an application that uses a variety of methods to help us achieve a complex task. We effectively broke down the problem into modularized methods to create an effective and well-orgranized solution. We also utilized parameters and return types to add further functionality to our code.