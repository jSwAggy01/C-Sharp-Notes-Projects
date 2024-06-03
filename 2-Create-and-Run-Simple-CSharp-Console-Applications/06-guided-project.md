# Project Overview

The objective of this project was to build a **Student Grading Application** that calculates the overall scores of *n* amount of students by averaging their exam scores as well as taking into account the average of their extra credit scores. This project is constructed upon the existing code of the previous guided project.

<ins>**Source code**</ins>: [here!](FinalProjects/GuidedProject/Starter/Starter.cs)

## Specifications

The feature implementations were as follows:
- Use arrays to store student names and assignment scores.
- Use a foreach statement to iterate through the student names as an outer program loop.
- Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
- Use an updated algorithm within the outer loop to calculate the average exam score for each student.
- Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
- Your code must detect extra credit assignments based on the number of elements in the student's scores array.
- Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

## Output

```
Student         Grade

Sophia          95.8    A 
Andrew          91.2    A-
Emma            90.4    A-
Logan           93      A 
Becky           94.8    A 
Chris           93.4    A 
Eric            93.4    A 
Gregor          94.6    A 
Press the Enter key to continue
```

## Conclusion

This project demonstrated fundamental software development principles such as:
- Creating nested `foreach` and `if` statements
- Implementing and processing the contents of `arrays`
- Developing application logic with minimal code updates
- Formatting user display to maximize readability