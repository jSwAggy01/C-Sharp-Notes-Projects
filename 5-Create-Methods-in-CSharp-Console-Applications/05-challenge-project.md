# Project Overview

The objective of this challenge project was to build a mini game application that could be played by the user via terminal. The project was interactive and dynamic which included random generation of objects as well as a maneuverable character. The objects could be consumed by the character and would affect the player in different ways that would limit or enhance their movement.

This application utilized multiple different methods that either returned values or utilized other methods to make the program much more readable and cleaner, as to avoid boilerplate code.

<ins>**Source code**</ins>: [here!](FinalProjects/ChallengeProject/Starter/Program.cs)

## Specifications

### <ins>Part I</ins>

- Terminate if user...
    1. Resizes window
        - Output "Console was resized. Program exiting."
    2. Enters invalid character
        - Add optional parameter for `Move()` method
        - Parameter used to detect invalid input

### <ins>Part II</ins>

- If player consumes food...
    1. Change player appearance
    2. Redisplay food

### <ins>Part III</ins>

- If player status is...
    1. Stunned
        - Freeze the player temporarily
    2. Happy
        - Increase/decrease the movement speed
        - Add optional parameter to enable increase or decrease
    3. Normal
        - Revert to default speed

## Sample Gameplay

<img src = "../other/5.5-challenge-project.gif" width = "600" height = "705" >

## Conclusion

All in all, we...
- developed features for an application to acheive a design specification
- deciphered existing code to make modifications and additions
- created new methods by adding optional parameters
- broke the problem into modularized steps utilizing a variety of methods

All of which, are core skills for software development.