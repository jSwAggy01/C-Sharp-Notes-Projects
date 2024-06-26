# Foundational C# with Microsoft Certification Exam - Study Guide

This study guide contains all the questions (184 total) and corresponding answers from every section's and module's knowledge check. I'm well aware that the test is open-note (and only 80 questions). Nonetheless, I've made this study guide to serve as a reference point for all the concepts and trivia that I was tested on during my completion of this course.

## Table of Contents

1. [Basics](#1-basics---write-your-first-code-using-c) - literal and variable values, string formatting, arithmetic *(21 questions)*
2. [Fundamentals](#2-fundamentals---create-and-run-simple-c-console-applications) - methods, decision logic, arrays, loops, readable code *(30 questions)*
3. [Logic](#3-logic---add-logic-to-c-console-applications) - booleans, code blocks, switch-cases, more loops *(22 questions)*
4. [Variables](#4-variables---work-with-variable-data-in-c-console-applications) - data types, conversion techniques, helper methods, formatting (42 questions)
5. [Methods](#5-methods---create-methods-in-c-console-applications) - parameters, return values *(17 questions)*
6. [Debugging](#6-debugging---debug-c-console-applications) - VSCode debugger, exception handling *(52 questions)*

## 1. **Basics** - Write Your First Code Using C#

### **<ins>Section 1.1</ins>**:

[(return to *Table of Contents*)](#table-of-contents)

1. **What is the difference between `Console.Write` and `Console.WriteLine`?**

- `Console.Write` prints the output on a new line.
- `Console.WriteLine` prints the output on a new line.
- `Console.WriteLine` appends a new line after the output.

```
Correct! `Console.WriteLine` prints the output on the existing line and appends a new line after it.
```

2. **What is the primary job of the compiler?**

- The compiler primarily locates spelling mistakes in your code.
- The compiler primarily executes your code.
- The compiler primarily converts your code into an executable format that the computer can understand.

```
Correct! The primary job of the compiler is to convert your code into a format that the computer can understand.
```

3. **Which of the following statements is true about C#?**

- C# is case insensitive.
- Console is a method, and `WriteLine()` is a class.
- You use double quotation marks to create a literal string.

```
Correct! You can create a literal string in C# using double quotation marks.
```

4. **What is wrong with this line of code? `Console.WriteLine("What is wrong with me?") `**

- The L in WriteLine should be lower-case.
- It's missing a semi-colon at the end

```
Correct! The semi-colon must be used at the end of a code statement.
```

- The string should use single-quotes.

### **<ins>Section 1.2</ins>**:

5. **Which of the following variable names should or must be avoided?**

- $DATA

```
Correct. The $ can't be used in a variable name. Furthermore, you shouldn't use all uppercase characters for a variable name.
```

- registrationComplete
- flag

6. **What is the problem with this line of code: `var message;`**

- `var` isn't a data type.
- Use of `var` keyword without initializing the variable.

```
Correct! A `var` data type must have an initialized value.
```

- A variable named message should always be a string.

7. **Which of the following is the output of `Console.WriteLine(34.40M);`?**

- `34.40M`
- `34.4`
- `34.40`

```
Correct! Using the decimal literal M or m denotes a decimal data type. Decimal values include the values after the decimal point when displayed.
```

8. **Which of the following lines of code creates a variable correctly?**

- `int x = 12.3 m;`
- `decimal x = 12.3 m;`

```
Correct! The assignment correctly matches the declared data type.
```

- `bool x = 'False';`

### **<ins>Sections 1.3</ins>**:

9. **Which of the following escape sequences should be used to add double quotes to a literal string in C# code?**

- '`\q`'
- '`\'`'
- '`\"`'

```
Correct. `\"` displays double quotes!
```

10. **Which of the following lines of code correctly uses string interpolation assuming that the variable value is a string?**

- '`Console.WriteLine(@"My value: {value}");`'
- '`Console.WriteLine($"My value: {value}");`'

```
Correct! The $ symbol denotes an interpolated string and the value in the curly braces is displayed.
```

- '`Console.WriteLine(@"My value: [value]");`'

11. **Unicode characters were embedded in the C# strings for a console application to present a greeting message in Thai. However, the message is only displayed as question mark characters. What is a possible cause?**

- A missing \u escape sequence for Unicode characters.
- The wrong Unicode characters were used.
- The user's console doesn't support Unicode characters.

```
Correct. The console in many environments may not support the full range of Unicode characters. As a result, Unicode characters may appear as question marks due to encoding mismatches.
```

12. **Which of the following lines of code appends a single \ to the string directory?**

- '`directory = directory + "\";`'
- '`directory = directory + '\';`'
- '`directory = directory + @"\";`'

```
Correct. The `@` symbol creates a verbatim string where it's unnecessary to escape the `\`.
```

### **<ins>Section 1.4</ins>**:

13. **Which of the following lines of code will output the text Windows 11?**

- `Console.WriteLine("Windows " + 7 + 4);`
- `Console.WriteLine($"Windows {1 + 1}");`
- `Console.Write("Windows " + 1 + 1);`

```
Correct! The integer values are implicitly casted as a string, resulting in the text 'Windows 11'
```

14. **What is the value of the following result? int result = 3 + 1 * 5 / 2;**

- 10
- 5

```
Correct.
```

- 6

15. **What will be the result of the following line of code? Console.WriteLine(5 / 10);** 

- 0.5
- 0

```
Correct.
```

- 1

16. **Which of the following lines of code uses the addition assignment operator?**

- `value += 5;`

```
Correct.
```

- `value++;`
- `value = value + 5;`

### **<ins>Section 1.5</ins>**:

17. **What does the following code accomplish? `var value = (int) dividend / (int) divisor;`**

- Casts the operands to truncate the result.

```
Correct. The operands are casted to the int data type that will create an implicitly typed int result.
```

- Declares an explicitly typed int variable.
- Casts the operands to prevent truncating the result.

18. **What does the `$` symbol do when used in a string in C#?**

- It allows you to use string interpolation to include variables in the string.

```
Correct! The `$` symbol allows you to use string interpolation to include variables in the string.
```

- It indicates that the string is a regular expression.
- It indicates that the string is a verbatim string literal.

19. **What is wrong with the following code? `int sophiaSum;` `Console.WriteLine("Sophia: " + sophiaSum);`**

- `sophiaSum` isn't initialized before use.

```
Correct. You must set a variable to a value before you can reference the value from the variable.
```

- `sophiaSum` isn't implicitly typed to a string.
- `sophiaSum` should use the var keyword.

### **<ins>Section 1.6</ins>**:

20. **Suppose `decimal gradePointAverage = 3.99872831m;`. What is the value of `(int) gradePointAverage`?**

- 3.99
- 4
- 3

```
Correct! The result is 3 because when you cast a decimal to an int, the decimal is truncated without rounding.
```

21. **In the following code `decimal x = 7 / 5;` why does x = 1?**

- Using the decimal data type truncates the fraction.
- Dividing two integers performs integer division.

```
Correct! Performing integer division will yield an integer result.
```

- This line of code has an error.

## 2. **Fundamentals** - Create and Run Simple C# Console Applications

[(return to *Table of Contents*)](#table-of-contents)

### **<ins>Section 2.1</ins>**:

22. **Which area of the Visual Studio Code user interface is used to write code?**

- Explorer.
- Extensions.
- Editor.

```
Correct! The Editor is the main area where developers write code.
```

23. **Which of the following tools is required to run command line interface commands such as dotnet run?**

- Visual Studio Code.
- C# Dev Kit.
- The .NET SDK.

```
Correct! The .NET SDK is required in order to run .NET command line interface commands such as dotnet run.
```

### **<ins>Section 2.2</ins>**:

24. **How do you find information on the .NET classes and methods you are using?**

- .NET Class Library.
- Developer websites.
- .NET Class Library, Google search, and developer websites.

```
Correct! This answer hits the big 3: .NET Class Library, Google search, and developer websites. These tools are the best way to find information on .NET classes and methods.
```

25. **Which of the following represents the correct way to create a class instance?** 

- `Random dice = new Random.Next();`.
- `Random dice = new Random();`.

```
Correct! Defining the type and including the new operator is the correct way to create a class instance.
```

- `String dice = new Random();`.

26. **A developer creates an instance of the Random class named coins. Which of the following code lines can they use to call the `Next()` method?**

- `int money = new coins.Next();`.
- `int money = Random.Next();`.
- `int money = coins.Next();`.

```
Correct! This statement uses your instance of the Random class, coins, to return a random number.
```

27. **What is a return value?**

- It's a value type returned by a method.

```
Correct! This is the correct definition of a return value.
```

- An argument in a method call is referred to as a return value inside the method.
- It's a string value.

28. **What are method parameters?**

- Variables that are used inside a method.

```
Correct! Method parameters are variables used inside the method. The method definition specifies the names and types of any parameters that are required. When a caller invokes the method, the calling statement provides concrete values, called arguments, for each parameter.
```

- Values returned by a method.
- Variables that are passed into a method by the calling statement.

29. **What is an overloaded method?**

- A method that returns a value type.
- A method with more than five parameters.
- It is a method that supports several implementations of the method, each with a unique method signature.

```
Correct! This is the correct definition of an overloaded method.
```

30. **How does IntelliSense help developers?**

- IntelliSense can help developers write code more quickly.

```
Correct! IntelliSense can catch misspelling, incorrect usage, and suggest corrections. These things speed up the coding process.
```

- IntelliSense helps developers refactor their code.
- IntelliSense can change the "theme" of an IDE.

31. **What is an object?**

- A memory address.
- A stateless class.
- An instance of a class.

```
Correct! An object represents the instantiation of a class.
```

32. **Which of the following statements is true?**

- The .NET Class Library always defines overloaded methods for every method.
- The .NET Class Library contains definitions for data types used in C#.

```
Correct! The .NET Class Library is where information for C# data types can be found.
```

- The .NET Class Library includes so many classes that it actually increases development time.

33. **Which of the following symbols represent the method invocation operator required to execute a method?**

- `.`
- `{}`
- `()`

```
Correct! The open and close parentheses are required for executing a method. The parentheses are also used when passing arguments to a method.
```

### **<ins>Section 2.3</ins>**:

34. **What is a code block?**

- A .NET Class Library.

- Lines of code that should be treated as a single unit.

```
Correct! A code block is defined by curly braces `{ }`. It collects lines of code that should be treated as a single unit.
```

- A block of code that is blocked from being accessed.

35. **What is a Boolean statement or expression?** 

- A modulus expression.

- An ordinal term.

- Code that returns either true or false.

```
Correct! A Boolean expression is any code that returns a Boolean value, either true or false.
```

36. **Given that int x = 5, which of the following Boolean expressions is valid and evaluates to true?** 

- `x < 5`.
- `x > 5`.
- `x `==` 5`.

```
Correct! Since x is equal to 5, using the C# equality operator `==` in the expression evaluates to true.
```

37. **Which of the choices below is not a valid operator in C#?** 

- `%%`.

```
Correct! The double percentage-sign symbol `%%` isn't a valid C# operator.
```

- `&&`.
- `||`.

38. **The following answer choices describe if statement syntax. Which of the descriptions is correct?** 

- The Boolean expression evaluated by an if statement is optional.
- An else statement can't be placed before an else if statement.

```
Correct! An else can't be placed before an else if statement.
```

- The else statement is required when an if statement includes an else if.

### **<ins>Section 2.4</ins>**:

39. **What is an array?** 

- A string variable.
- A sequence of individual data elements accessible through a single variable name.

```
Correct. An array data structure with a single name and multiple data locations.
```

- A .NET Class Library.

40. **Which of these is a correct example of creating an array and initializing it?** 

`string[] myarray = new string[3];` `myarray = "test1";` `myarray = "test2";` `myarray = "test3";`.

`string[] myarray = string[3];` `myarray[0] = test1;` `myarray[1] = test2;` `myarray[2] = test3;`.

`int[] myarray = new int[3];` `myarray[0] = 1;` `myarray[1] = 2;` `myarray[2] = 3;`.

```
Correct! The array myarray is declared correctly and the code statements used to assign values to the array elements specify the array index locations.
```

41. **Which of the following can be used to access the third element in an array?** 

- `myArray[3]`.
- `myArray[2]`.

```
Correct! Indexes are zero-based, so an index of two returns the third element in an array.
```

- `myArray{3}`.

41. **Which of the following choices describes the correct way to create a new integer array with three elements?** 

- `int[] myArray = new int[3];`.

```
Correct! This is the correct way to create an array with three elements.
```

- `int[] myArray = new int[2];`.
- `int myArray = new int[3];`.

43. **Which of the following `foreach` statements is syntactically correct?** 

- ``foreach` (int value in values)`.

```
Correct! This `foreach` statement is defined using valid syntax.
```

- ``foreach` (int value of values)`.
- ``foreach` (int value with values)`.

### **<ins>Section 2.5</ins>**:

44. **Which of the following is an example of correct camel case formatting of a variable name?** 

- `UserOption`.
- `user Option`.
- `userOption`.

```
Correct! This is the correct way to use camel case for a variable.
```

45. **Which of the following demonstrates recommended guidelines for naming a variable?** 

- `my-string`.
- `initialMessage$`.
- `initialMessage`.

```
Correct! This is the appropriate camel case for a variable name and the name is descriptive.
```

46. **Which of the following is a bad reason to use a code comment?** 

- To describe the high-level intent of the code.
- To explain how a new C# keyword works.

```
Correct! Comments should not be used for this reason.
```

- To temporarily comment out a line of code while evaluating a feature in a different way.

47. **Which of the following statements about using whitespace in code is true?** 

- Reducing the amount of whitespace will improve code performance (execution speed).
- Whitespace should be used every two or three lines to separate code lines.
- Whitespace should be used judiciously to improve the readability of your code.

```
Correct! Whitespace should be used to improve core readability.
```

### **<ins>Section 2.6</ins>**:

48. **A developer writes an application that uses a `foreach` loop to iterate through an array containing 20 elements. After the application is complete, the developer learns that the array must be updated to include 40 elements. The application needs to examine all 40 array elements. Which of the following items describes the required code update?** 

- Create a second `foreach` loop that iterates through the additional items.
- No changes are required to the `foreach` loop.

```
Correct! A `foreach` loop will iterate through all of the elements in an array.
```

- Place the original `foreach` loop inside the code block of a second `foreach` loop that iterates twice.

49. **A developer is working on a nested `foreach` structure that iterates through all of an application's data arrays. The first array contains the names of locations where water samples were collected. The remaining arrays contain the test results for the samples collected from each named location. Which of the following statements about how the arrays should be processed is correct?** 

- Each of the arrays containing samples can be processed by the outer loop, the inner loop will be used to verify the location.
- The order in which the arrays are processed doesn't matter since the application has to process all of the data.
- The outer loop must process the array containing locations, the inner loop must process the arrays containing samples.

```
Correct! The outer loop will iterate through the locations. The code block of the outer loop will be used to select the samples array for each location, and then process the sample in the inner `foreach` loop.
```

### **<ins>Section 2.7</ins>**:

50. **A developer is working on a nested `foreach` structure that iterates through the application's array data. The first array contains the names of 10 geographic regions. The remaining arrays are based on the 10 regions. Each regional array contains the population of cities that have a population over one million. The population values in the regional arrays go from largest to smallest. The application sums the 25 most populated cities in each region. How should the developer ensure that only the 25 largest populations are added to the sum?** 

- The developer should insert a "marker value" into the population arrays. The "marker value" should be added at index position 25. When the marker value is detected, the application should stop adding values to the sum.

- The developer should check the index number of the current array element inside the `foreach` code block. The application should stop adding values to the sum when the index number reaches 25.

- The developer should increment a counter inside the `foreach` code block. The application should stop adding values to the sum when the counter reaches 25.

```
Correct! The developer should use a counter that increments inside the `foreach` loop.
```

51. **A developer is working with two other developers to update a collection of applications. The developers will use code comments during the update process. Which of the following describes an appropriate use of code comments?** 

- When updates are made, the developers use line and block comments to identify each individual code update.
- When updates are made, the developers leave all existing code comments intact. New comments are added to indicate when old comments no longer apply.
- When updates are made, the developers summarize changes using block comments.

```
Correct! Using a block comment to summarize the changes implemented during an update is a good use of code comments. A single block comment at the top of the files that contain updates is often sufficient.
```

## 3. **Logic** - Add Logic to C# Console Applications

[(return to *Table of Contents*)](#table-of-contents)

### **<ins>Section 3.1</ins>**:

52. **Which of the following lines of code is a valid use of the conditional operator?**

- `int bonus = amount >= 100? 10: 5;`.

```
Correct! This code line shows the correct syntax for a conditional operator ?:.
```

- `int bonus = amount >= 100: 10? 5;`.
- `int bonus = amount >= 100? 10, 5;`.

53. **Which line of code uses logical negation?** 

- `Console.WriteLine(!value);`.

```
Correct! Adding the ! operator (the "not-operator") before a conditional expression forces your code to reverse its evaluation of the operand. When logical negation is applied, the evaluation produces true if the operand evaluates to false and false if the operand evaluates to true.
```

- `Console.WriteLine(value != false);`.
- `Console.WriteLine(a != b);`.

54. **Which of the following lines of code is a valid use of the conditional operator?** 

- `int value = amount >= 10? 10: 20;`.

```
Correct! The syntax for a conditional operator is "? (value 1) : (value 2)".
```

- `int value = amount >= 10: 10? 20;`.
- `int value = amount >= 10? 10| 20;`.

### **<ins>Section 3.2</ins>**:

54. **A developer writes some code that includes an if statement code block. They initialize one integer variable to a value of 5 above (outside) of the code block. They initialize a second integer variable to a value of 6 on the first line inside of the code block. The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. On the second line inside the code block, they assign the sum of the two values to the first variable. On the first line after the code block, they write code to display the value of the first integer. What is the result when the code statement used to display the first integer is executed?**

- No error is generated and the integer value is displayed. The value displayed is the sum of the first and second integer.

```
Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.
```

- No error is generated and the integer value is displayed. The value displayed is the initialized value from above the code block.
- An error is generated because the first variable isn't in-scope after the code block.

55. **Which of the following statements is true about showing/removing the curly braces for code blocks associated with an if statement?**

- The curly braces can't be removed from the code block for else if and else statements.

- If the curly braces are removed from the code blocks of an if-elseif-else, the white space must also be removed.
- Always choose a style that improves readability.

```
Correct! Code readability should always be a consideration when deciding whether to remove the curly braces from the code blocks associated with an if statement.
```

56. **A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 1 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 8. The second code line inside the code block is used to assign the sum of the two integer values to the first variable. The first code line after the code block is used to display the value of the first integer variable. What is the result when the code is executed?**

- No error is generated and the integer value 9 is displayed.

```
Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.
```

- No error is generated and the integer value 1 is displayed.
- An error is generated because the first variable is not in-scope after the code block.

57. **A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 5 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 6. The first code line after the code block is used to add the second integer value to the value of the first integer. The second code line after the code block is used to display the value of the first integer. What is the result when they run the code?**

- No error is generated and the integer value 11 is displayed.
- An error is generated by the code line used to display the integer value.
- A build error is generated by the code line used to sum the two integers.

```
Correct! A build error is generated by the code that sums the two integers. The error tells you that the second variable does not exist in the current context. The second variable is not in-scope outside the code block.
```

### **<ins>Section 3.3</ins>**:

58. **A developer writes the code to implement a switch-case construct. What is the purpose of the break keyword?**

- The break keyword tells the runtime to continue evaluating other cases in the switch construct.
- The break keyword tells the runtime to stop evaluating case patterns and prevents execution of other cases in the switch construct.

```
Correct! The break keyword redirects code execution and prevents one switch section continuing into the next section.
```

- The break keyword tells the runtime to exit the application.

59. **A developer writes the code to implement a switch-case construct that evaluates a variable against many possible matching values. They include the default keyword as part of their switch-case construct. What is the purpose of the default keyword?**

- The default keyword supplies the default value for the variable if the variable hasn't been initialized.
- The default keyword acts as the matching value when none of the supplied case values is a match.

```
Correct. If there's no matching case value labels, the optional default label is used as the matching value.
```

- The default keyword supplies a default actions code block that is always executed regardless of the matching case value

60. **Which of the following statements about the switch-case construct is true?**

- A single switch section can have multiple case labels.

```
Correct!
```

- A switch construct must include a default switch section.
- The colon at the end of the case label is optional.

61. **What is the purpose of a default case in a switch statement?**

- It's used to specify the condition for the switch statement.
- It's used to end the switch statement.
- It's used to execute a block of code if no case matches the expression.

```
Correct! The default case executes when no other case matches the switch expression.
```

62. **What happens if a break statement (or alternative keyword that prevents "fall-through") is omitted in a switch case?**

- The default case will execute.
- The impacted case sections will be removed by the compiler.
- The compiler will generate an error.

```
Correct! Only one switch section is allowed to be executed. If you forget the break keyword (or, optionally, the return keyword) the compiler will generate an error.
```

### **<ins>Section 3.4</ins>**:

63. **Which of the following for statements is correct?** 

- `for (int x = 20: x < 80: x++)`
- `for (int j = 0; j < 80; j + 1)`
- `for (int counter = 20; counter < 80; counter++)`

```
Correct!
```

64. **Which of the following statements should be used to exit out of a for loop before the iteration has completed?** 

- `exit;`
- `break;`

```
Correct! The break keyword can be used to jump out of a for loop when a desired condition is met.
```

- `return;`


### **<ins>Section 3.5</ins>**:

65. **Which of the following correctly describes a behavior of either a `do-while` or `while` iterative statement?** 

- A `do-while` statement executes a code block zero or more times.
- A `while` statement executes a code block at least once.
- A `do-while` statement executes a code block at least once.

```
Correct! The `do-while` iterates through a code block at least one time. Code execution exits the iteration loop once the `while` expression at the end of the code block evaluates to true.
```

66. **A developer needs to capture user input inside a loop. The user enters the keyboard combination `ctrl + Esc` to exit the iteration when they're done entering information. Which is the best iteration statement for this purpose?** 

- `while`
- `for`
- `do-while`

```
Correct! The `do-while` allows the developer to check each entry by the user until they enter the special keyboard combination to exit.
```

67. **A developer needs to iterate through an array of items. The number of items in the array is unknown. The code inside the iteration code block examines each item sequentially to select an item that matches specified criteria. The index number of the selected array element isn't important. The selected item is referenced multiple times within the code block. Which type of iteration statement is best suited for this scenario?** 

- `foreach`

```
Correct! It's possible to use any of these iteration types for the conditions described, but a `foreach` is best suited for this scenario. The `foreach` is easy to implement when the number of array elements is unknown. The `foreach` is a good choice when the index number of the selected array element isn't important. The `foreach` might run faster when the selected item is used multiple times within the code block.
```

- `for`
- `while`

68. **A developer needs to capture a list of items from the user. The user will enter the keyboard combination ctrl + Esc to exit. Which is the best iteration statement for this purpose?** 

- `foreach`
- `do-while`

```
Correct! The `do-while` will allow the code to check each entry by the user until they enter the special keyboard combination to exit.
```

- `while`

### **<ins>Section 3.6</ins>**:

69. **When is it appropriate to use a `switch-case` construct rather than a if-elseif-else construct?** 

- A `switch-case` construct is appropriate when more than 2-3 else if code blocks are required.

```
Correct! When more than 2-3 else if code blocks are required, the code can become difficult to read, and the `switch-case` construct is preferable
```

- A `switch-case` construct is appropriate when the number of case patterns is small.
- A `switch-case` construct is appropriate when the selection statement is inside a loop.

70. **Why should a developer choose a `for` statement rather than a `foreach` statement when processing the contents of a multidimensional array?** 

- `for` statements do a better job of examining each array item separately.
- `foreach` statements do a better job of examining each array item separately.
- `for` statements enable a developer to treat array dimensions separately.

```
Correct! When their code is processing the contents of a multidimensional array, a developer often wants to iterate through the array dimensions separately. The `for` statement provides better support `for` processing array dimensions separately.
```

71. **Why is it important to scope a variable at its lowest necessary level?** 

- It ensures that a variable that's declared outside of a code block, can be accessed inside the code block before it's been assigned a value.
- It ensures that application resources and the security footprint are kept small.

```
Correct. Keeping variables scoped at the lowest necessary level enables better resource management and helps to minimize the attack profile of the application.
```

- It ensures that a variable can be accessed within the lowest level code branches of an application.

### **<ins>Section 3.7</ins>**:

72. **A developer is writing an application in Visual Studio Code. They save changes to their Program.cs file, and then run the `dotnet build` command in the Terminal panel. What information can they find in reported Error and Warning messages?** 

- One or more suggestions for how to fix any syntax issues detected.
- The line number and information about what caused the error.

```
Correct. Error and Warning messages include a description of the issue and the line number where it occurs.
```

- Links to help documentation.

73. **A developer needs to create an iteration statement. Under what condition is a `while` statement a better choice than a `do` statement?** 

- When the expression values evaluated by the iteration statement are unknown prior to the iteration code block.
- When the expression values evaluated by the iteration statement are known prior to the iteration code block.

```
Correct. When the code is able to evaluate the loop expression prior to the loop, a `while` statement allows the code to implement zero iterations.
```

- When the developer creates nested do or `while` loops.

## 4. **Variables** - Work with Variable Data in C# Console Applications

[(return to *Table of Contents*)](#table-of-contents)

### **<ins>Section 4.1</ins>**:

74. **Which choice best represents how bits represent on and off?** 

- Bits are represented using "x" or "o" character.
- Bits are represented using "+bit" or "-bit" notation.
- Bits are binary and represented using "1" or "0" digit.

```
Correct. Bits are represented using the "1" or "0" digit.
```

75. **Which data type has a range of whole numbers between `0` and `65535` in C# code?** 

- `Sbyte`
- `Ushort`

```
Correct, `ushort` represents values `0` to `65535`.
```

- `byte`

76. **Which is the best data type to use to process banking deposits?** 

- `Decimal`

```
Correct. `Decimal`, with ~28-29 digits of precision, has the precision required for many financial applications.
```

- `Float`
- `Double`

77. **In C#, when the new keyword is used to create an instance of a class, where is the memory allocated?** 

- Stack
- Heap

```
Correct. Instances of classes are allocated on the heap when created with the new keyword.
```

- Variable

78. **A piece of code must store whole numeric values between negative and positive `1,000,000`. Which is the best data type to be used?** 

- `float`
- `double`
- `int`

```
Correct. While `float` or `double` would work, their extra precision after the decimal doesn't fit the exact requirement of this scenario.
```

79. **The code for a game needs to store lots of fractional values representing x, y, and z positions in a large 3D space. It will likely need to perform physics calculations for trajectories and so on. Absolute precision isn't required, but it's important that the program runs as efficiently as possible. Which data type is best?** 

- `float`

```
Correct. Unlike int, `float` can store fractional numbers, and unlike `decimal`, `float` doesn't require extra memory to store extra precision that isn't needed in this scenario.
```

- `decimal`
- `int`

80. **Which of the following statements is true?** 

- Reference types are stored in the stack.
- Value types can only store numbers.
- Use the new operator to create a new instance of a reference type and return its address to the variable.

```
Correct. Use the new operator to create a new instance of a reference type and return its address to the variable.
```

### **<ins>Section 4.2</ins>**:

81. **Which is the best technique to convert a `decimal` type to an `int` type in C#?** 

- Cast

```
Correct. decimal to int is a narrowing conversion so cast is the best answer.
```

- Narrowing
- Implicit conversion

82. **Which of the following conversion rounds the value (versus truncate)?** 

- `int cost = (int)3.75m;`
- `int cost = Convert.ToInt32(3.75m);`

```
Correct. Convert.ToInt32() rounds values with fractional precision.
```

- `uint cost = (uint)3.75m;`

83. **Which technique should be used to change `myInput`, a `string` value "2.71828", into a `decimal` variable `myInputDecimal`?** 

- `decimal myInputDecimal = (decimal)(myInput);`
- `decimal myInputDecimal = myInput + 0;`
- `decimal.TryParse(myInput, out myInputDecimal);`

```
Correct. Using `TryParse` (or `Parse()`) is a valid technique.
```

84. **Consider the C# code `bool success = decimal.TryParse(input, out decimal number);`. Which best describes the return type of `decimal.TryParse()`?** 

- `decimal`
- `bool`

```
Correct. `TryParse()` returns a `bool`.
```

- `out`

85. **Which technique results in an error when used to convert a `string` value `4.123456789` into a `decimal`?** 

- `Convert.ToDecimal()`
- `decimal.TryParse()`
- `(decimal)`

```
Correct. It isn't possible to directly cast a `string` into a `decimal` and results in an error.
```

86. **What type of action is being performed when changing a `float` into an `int`?** 

- A narrowing conversion.

```
Correct. Changing a `float` into an `int` is a narrowing conversion, because float can store more precision data compared to `int`.
```

- A widening conversion.
- An illegal conversion.

### **<ins>Section 4.3</ins>**:

87. **Which best describes the code `Array.Sort(pallets);` where `pallets` is a `string` array?** 

- `Sort` represents a cast operation
- `Sort` is an Array method.

```
Correct. `Sort` is an Array method.
```

- `Sort` is used to `sort` array amount of precision.

88. **What best describes the code `Array.Clear(pallets, 0, 2);` where `pallets` is a `string` array?** 

- `Array.Clear(pallets, 0, 2);` removes the data from `2` array elements starting from item `0`.

```
Correct. Clear is a method of arrays that removes (replaces with Null) specific elements in an array.
```

- `Array.Clear(pallets, 0, 2);` removes the data from array element locations `pallets[0]` and `pallets[2]`.
- `Array.Clear(pallets, 0, 2);` removes array elements that are equal to `0` or `2`.

89. **`String.Join("-", myArray);` is an example of a `Join`. Which explanation best fits this example?** 

- Constructs a character array from items in `myArray` connected with `,` (commas).
- Constructs a string from items in `myArray` connected with `-` (dashes).

```
Correct. `String.Join` constructs strings from the elements of `myArray`.
```

- Constructs a string named `myArray` connected with `-` (dashes).

90. **Which method changes the order of items in an `string` array?** 

- `myArray.Resize()`
- `myArray.Clear()`
- `Array.Sort()`

```
Correct. `Array.Sort()` places string array items in ascending order.
```

91. **What is null?** 

- The same as an empty string.
- The same as the value zero.
- A value that indicates a variable points to nothing in memory.

```
Correct. Null isn't the same as an empty string or the value zero.
```

### **<ins>Section 4.4</ins>**:

92. **Which is the output of `Console.WriteLine($"Tax rate: {tax:P1}");`, where tax is defined by `decimal tax =.12051 m;?`** 

- `Tax rate: 12.05%`
- `Tax rate: 12.10%`
- `Tax rate: 12.1%`

```
Correct. tax: P1 rounds the percentage to a single decimal place.
```

93. **Given string `myWords = "Learning C#"`, what is the best output description for `Console.WriteLine(myWords.PadLeft(12));`?** 

- One space is added to the start of the string.

```
Correct. myWords is 11 characters long, adding on space completes the padding to 12.
```

- Four spaces are added to the start of the string.
- 12 spaces are added to the start of the string.

94. **For the C# code `Console.WriteLine("C110".PadLeft(6, '0'));`, which is the expected output?** 

- `C11000`
- `C110000000`
- `00C110`

```
Correct. `.PadLeft(6, '0')` appends zeros to the left side of a string until the string is six characters long.
```

95. **Which format specifier presents a decimal value with the following format to an en-US audience: `12,345.67`** 

- `0:C`
- `0:H`
- `0:N2`

```
Correct. `N2` is the correct format specifier.
```

96. **Which character must be used as a directive to perform string interpolation?** 

- `$`

```
Correct. The $ directive is used to perform string interpolation.
```

- `@`
- `%`

### **<ins>Section 4.5</ins>**:

97. **What is the return value of `myString.IndexOf('C');` where `string myString = "C# Time";`?** 

- `0`

```
Correct. "C" is the first item in myString and matches at position 0.
```

- `1`
- `-1`

98. **What method should be used to search for the first occurrence of a search term in a long string?** 

- `IndexOfAny()`

```
Correct. `IndexOfAny()` returns the first position of an array of char that occurs inside of another string.
```

- `LastIndexOf()`
- `Substring()`

99. **If the code `message = message.Replace("B", "D");` is run, where `string message = "Big Dog";`, what is the new value of message?** 

- `"Big Dog"`
- `"Big Bog"`
- `"Dig Dog"`

```
Correct. "B" is replaced with "D".
```

100. **Which method finds the next index of either the - char, the = char, or the _ char?** 

- `IndexOfAny()`

```
Correct. Use `IndexOfAny()` to retrieve the next index for any of several chars in a string.
```

- `Remove()`
- `IndexOf()`

111. **What is a constant variable?** 

- A magic string or number.
- A variable whose name must match its value.
- A value that once initialized can never be changed.

```
Correct. A constant variable can never be changed, once initialized.
```

### **<ins>Section 4.6</ins>**:

112. **Which choice best describes the purpose of `TryParse()`?** 

- To split sentences into words stored in an array.
- To safely test a cast operation.

```
Correct. `TryParse()` returns a `bool` if (true or false) indicating if a cast can be completed.
```

- To find a substring in a larger string.

113. **For the code `decimal.TryParse(numberString, out myConvert)` when the type of `numberString` is a String. Which best describes the value type for `myConvert` when the `TryParse()` is successful?** 

- A string representing numeric digits.
- A Boolean value.
- A decimal

```
Correct. For decimal.TryParse() the out variable, myConvert is a decimal.
```

### **<ins>Section 4.7</ins>**:

114. **To sort a string array, why is it important to use the `String.Trim()` method on each array element before sorting?** 

- Only string arrays with elements trimmed with `String.Trim()` can sort.
- `String.Trim()` removes leading white space that would sort before numbers and letters.

```
Correct. `String.Trim()` removes both leading and trailing whitespace.
```

- The array sort is noticeably faster using `String.Trim()` on each element.

115. **Both `foreach` and `for` are good choices to iterate small single dimension arrays like {"cat", "fox", "dog", "snake", "eagle"}, but when is it best to use a `for` loop?** 

- When the elements have alphabetical sort order.
- To perform a search on each element in the array.
- To evaluate a specific range of elements.

```
Correct. A `for` is better when index ranges that aren't the first to the last index are required.
```

## 5. **Methods** - Create Methods in C# Console Applications

[(return to *Table of Contents*)](#table-of-contents)

### **<ins>Section 5.1</ins>**:

116. **Suppose there's a method named `ConvertCurrency`. Which of the following lines of code is a valid method signature?** 

- `ConvertCurrency();`
- `ConvertCurrency() { }`
- `void ConvertCurrency(){};`

```
This line is correct. A method signature is created by declaring the return type, followed by the method name, and parentheses containing any input parameters.
```

117. **Suppose there's a method named `Update`. Which of the following correctly calls the method?** 

- `var update;`
- `Update();`

```
This answer is correct! A method is called using its name followed by parentheses.
```

- `void Update();`

118. **Which of the following correctly declares a method?** 

- `DisplayNumbers();`
- `void DisplayNumbers{};`
- `void DisplayNumbers() { }`

```
Correct. A method is declared using the return type, followed by parentheses `()` containing any parameters, and brackets `{}` to contain the method body.
```

119. **Which of the following correctly calls a method?** 

- `GenerateID();`

Correct! Methods are called using the name, followed by parentheses () and a semicolon.

- `void GenerateID() {}`
- `GenerateID;`

120. **Which of the following is true about the `return` keyword?** 

- It's identical to the `break` keyword.
- It terminates the execution of a method.

```
Correct! The return statement terminates execution of its method and returns control to the caller.
```

- It must always be used with a value or expression.

### **<ins>Section 5.2</ins>**:

121. **Which of the following method signatures correctly defines 3 integer parameters?** 

- `void Multiply(int a, b, c)`
- `void Multiply(int a, int b, int c)`

```
Correct! The data type for each parameter is included and parameters are comma separated.
```

- `void Multiply(int a; int b; int c)`

122. **Given the method signature, `void Print(string name, string number = "", bool member = false)`, which of the following options correctly uses named and optional arguments?** 

- `Print("Tony", member: true);`

```
Correct! The optional argument is included using the parameter name followed by a :
```


- `Print(number: "555", member: false)`
- `Print("Tony", false)`

123. **Given the following method signature, void SetHealth(string health), why don't operations inside the method affect the original input string health?** 

- The string data type is pass by value.
- The method code must be incorrect.
- Strings can't be altered once assigned. They can only be overwritten with a new value.

```
Correct! Strings are pass by reference, but they're immutable and can't be altered once assigned.
```

### **<ins>Section 5.3</ins>**:

124. **What data type is returned from the following statement: `return 100 * 0.5;`** 

- An `int` type
- A `decimal` type
- A `double` type

```
`double` is correct. Since an integer literal is being multiplied by a `double`, this line of code returns a `double`.
```

125. **Which type of method doesn't need to include a `return` statement?** 

- `string` methods
- `void` methods

```
`void` is correct! `void` methods don't need to use a return statement.
```

- array methods

126. **Which of the following options correctly returns a string value?** 

- `return "";`

```
Correct! An empty string is a valid string result.
```

- `return 'a';`
- `return 5;`

127. **Which of the following statements is true about the `return` keyword?** 

- It starts a new iteration of a method.
- It terminates the execution of a method.

```
Correct! The `return` statement terminates execution of its method and returns control to the caller.
```

- It must always be used with a value or expression.

128. **Which of the following options is a valid `return` statement?** 

- `return void;`
- `return 5 % 2;`

```
Correct! This statement would return the value of the expression `5 % 2`
```

- `return Console.WriteLine();`

### **<ins>Section 5.4</ins>**:

129. **What is the purpose of defining an optional parameter in a method?** 

- To cause a method to perform a different task.
- To overload a method.
- To simplify the required parameters when a parameter isn't significant to the result.

```
Correct! Optional parameters enable you to pass fewer arguments and accomplish the method task.
```

130. **What is the purpose of pseudo-code?** 

- To provide a design template for the intended code.

```
Correct! Pseudo-code helps to bridge the gap between concept and code.
```

- To safely cast operations performed in methods.
- To develop syntactically correct code.


### **<ins>Section 5.5</ins>**:

131. **A developer wants to create a method that compares two values. Which of the following options is the best data type for the method to return?** 

- A `double` value.
- Nothing, the method should be `void`.
- A `bool` value.

```
Correct! A comparison expression should return true or false.
```

132. **A developer wants to create a method that returns a value in an array. Which of the following options would be a good choice for a method signature?** 

- `string GetValueAtIndex(string[] array, int index)`

```
Correct! This method accepts a string array and an index value and returns a string value.
```

- `bool GetValueAtIndex(string[] array, int index)`
- `int GetValueAtIndex(int index)`


## 6. **Debugging** - Debug C# Console Applications

[(return to *Table of Contents*)](#table-of-contents)

### **<ins>Section 6.1</ins>**:

133. **What is code debugging?** 

- A process to identify code syntax errors during the build process.
- A process to isolate and fix issues in code logic.

```
Correct. Code debugging involves isolating and fixing logic issues in code.
```

- A process to verify that code builds and runs without errors.

134. **Who is responsible for software testing?** 

- Software developers.
- Software testers.
- Both developers and testers.

```
Correct. Software developers and testers share the responsibility for code testing.
```

135. **What happens if an exception isn't managed in code?** 

- The code continues to run without any issue.
- The application generates an error message and closes.

```
Correct. If an exception isn't managed in code, the runtime will display an error message and the application may be terminated.
```

- The code syntax errors are displayed to the user.


136. **What is a debugger?** 

- A software tool used to observe and control the execution flow of a program.

```
Correct. A debugger is a software tool uses an analytical approach to observe and control the execution flow of a program.
```

- A program that generates code automatically based on user input.
- A tool that helps developers write their code faster.

137. **What is the primary benefit of using a debugger?** 

- A debugger helps developers to write code faster.
- A debugger enables developers to watch their application running and follow program execution one line of code at a time.

```
Correct. The primary benefit of using a debugger is watching application code run and following program execution one line of code at a time.
```

- A debugger helps developers to add new features to their application.

138. **What is one of the most important features of a debugger?** 

- Code generation.
- Observation of your program's state.

```
Correct. Observation of your program's state is one of the most important features that come with almost all debuggers.
```

- Automatic bug fixing.

139. **What is the best way to find the root cause of a bug?** 

- Running your app with different data.
- Breadcrumbing a few Console.WriteLine("here") messages in your code.
- Using a debugger.

```
Correct. Using a debugger is the best way to find the root cause of a bug.
```

140. **What is the purpose of catching an exception in C#?** 

- To ignore errors that occur in a program.
- To take corrective action when an error occurs in a program.

```
Correct. The purpose of catching an exception is to take corrective action when an error occurs.
```

- To generate additional errors in a program.

141. **Can a developer access the contents of an exception at runtime?** 

- No, exceptions can never be accessed.
- Yes, exceptions can be accessed and used to take corrective action.

```
Correct. Exceptions are objects that can be accessed. The properties of an exception can be used to help determine corrective action.
```

- Exceptions can be accessed, but not during the application runtime.

142. **What happens when execution of a C# application results in a system error?** 

- The program crashes and closes.
- An exception is created and thrown by the .NET runtime.

```
Correct. The .NET runtime throws an exception when a C# application generates a system error.
```

- The error is silently ignored and the program continues to run.

143. **What is the relationship between the type of exception and the information it contains?**

- The type of exception and the information it contains are unrelated.
- The type of exception determines the information it contains.

```
Correct. The type of exception determines the information it contains.
```

- The information contained in an exception determines the type of exception.

### **<ins>Section 6.2</ins>**:

144. **Which section of the Run menu enables a developer to edit or add launch configurations?** 

- The start and stop applications section.
- The launch configurations section.

```
Correct. The configurations section of the Run menu provides access to edit or add launch configurations in Visual Studio Code.
```

- The install debuggers section.

145. **Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application?** 

- VARIABLES section.
- CALL STACK section.

```
Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application.
```

- WATCH section.

146. **Which button on the Debug toolbar can be used resume normal code execution?** 

- The Pause/Continue button.

```
Correct. The Pause/Continue button on the Debug toolbar can be used to pause execution when the code is running and continue when code execution has been paused.
```

- The Step Over button.
- The Restart button.

147. **Which section of the Run menu enables the developer to set breakpoints on code lines?** 

- The Manage Breakpoints section.
- The Start and stop applications section.
- The Set Breakpoints section.

```
Correct. The Set Breakpoints section of the Run menu enables the developer to set breakpoints on code lines.
```

148. **What capability does the "More" dropdown on the right side of the Debug toolbar provide?** 

- An option to disconnect the debugger.

```
Correct. The "More" dropdown on the right side of the Debug toolbar enables a developer to disconnect the debugger from the current process
```

- An option to edit launch configurations.
- An option to manage breakpoints.

149. **Which of the following can be used to configure and start a debug session?** 

- The Debug toolbar.
- The VARIABLES section of the RUN AND DEBUG view.
- The Run and Debug controls panel.

```
Correct. The Run and Debug controls panel is used to configure and start a debug session from the RUN AND DEBUG view in Visual Studio Code.
```

150. **Which of the following options can be used set a breakpoint in Visual Studio Code?** 

- Left-click in the column to the left of a line number in the code editor.

```
Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking.
```

- Select Toggle Breakpoint on the Edit menu.
- Right-click in the middle of a line of code, and then select Toggle Breakpoint.

151. **How can a developer disable a breakpoint in Visual Studio Code?** 

- Click Remove Breakpoint on the Run menu.
- Right-click the red dot to the left of the line number and select Disable Breakpoint.

```
Correct. A breakpoint can be disabled by right-clicking the red dot that represents a breakpoint and then selecting Disable Breakpoint.
```

- Left-click the red dot to the left of the line number.

152. **What happens when a developer disables a breakpoint in Visual Studio Code?** 

- The breakpoint is removed from the code entirely.
- The breakpoint is skipped over during debugging.

```
Correct. When a breakpoint is disabled, it is skipped over during debugging. In the user interface, the red dot representing the breakpoint is changed to a grey dot.
```

- The breakpoint will only be triggered if dot to the left of the line number is changed to a grey dot.

153. **What is a conditional breakpoint in Visual Studio Code?** 


- A breakpoint that only triggers when a specified condition is met.

```
Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met.
```

- A breakpoint that is triggered every time the code is run.
- A breakpoint that is only visible in the editor and doesn't affect debugging.

154. **How can a developer create a conditional breakpoint in Visual Studio Code?** 

- Left-click in the column to the left of a line number in the code editor.
- Select Toggle Conditional Breakpoint on the Run menu.
- Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.

```
Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint.
```

155. **A developer updates a launch configuration. What is the name attribute used for?** 

- To specify the type of debugger used in a launch configuration.
- To specify the request type of a launch configuration.
- To specify the display name for a configuration.

```
Correct. The name attribute specifies the display name for the configuration. The value assigned to name appears in the controls panel at the top of the RUN AND DEBUG view.
```

156. **A developer is working on a launch configuration. What is the preLaunchTask attribute used for?** 

- To specify the path of the application dll or .NET Core host executable to launch.
- To specify a task to run before debugging your program.

```
Correct. The preLaunchTask attribute specifies a task to run before debugging the program. The task itself can be found in the tasks.json file, which is in the .vscode folder along with the launch.json file. Specifying a prelaunch task of build runs a dotnet build command before launching the application.
```

- To specify the type of console that's used when the application is launched.

157. **What is the console attribute of a launch configuration used for?** 

- Specifies the working directory of the target process.
- Specifies the type of debugger to use for this launch configuration.
- Specifies the type of console that's used when the application is launched.

```
Correct. The console attribute specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole.
```

### **<ins>Section 6.3</ins>**:

158. **Which of the following answer choices lists the C# keywords used for exception handling?**

- `try`, `catch`, and `finally`.
- `try`, `catch`, `finally`, and `throw`.

  ```
  Correct. The `try`, `catch`, `finally`, and `throw` keywords are used for exception handling in C#.
  ```

- `try`, `catch`, and `throw`.

159. **What does the try code block contain?**

- The code that cleans up resources and is executed whether an exception occurs or not.
- The code that throws an exception object.
- The code that may cause an exception.

  ```
  Correct. The try code block contains the guarded code that may cause an exception.
  ```

160. **What is the purpose of the catch code block?**

- To clean up any resources that are allocated in a try block.
- To handle the exception, log it, or ignore it.

  ```
  Correct. The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it.
  ```

- To execute code that may cause an exception.

161. **What is the purpose of the finally block?**

- To execute code that may cause an exception.
- To handle the exception, log it, or ignore it.
- To clean up any resources that are allocated in a try block.

  ```
  Correct. The finally block is often used to clean up any resources that are allocated in a try block. The finally code block contains code that executes whether an exception occurs or not.
  ```


162. **When is an `ArrayTypeMismatchException` exception thrown?**

- An `ArrayTypeMismatchException` exception is thrown when an attempt is made to divide an integral value by zero.
- An `ArrayTypeMismatchException` exception is thrown when an attempt is made to index an array outside the bounds of the array.
- An `ArrayTypeMismatchException` exception is thrown when an attempt is made to store a value of one type in an array of another type.

  ```
  Correct. The `ArrayTypeMismatchException` exception is thrown when an attempt is made to store an element of the wrong type within an array.
  ```

163. **When is a `DivideByZeroException` exception thrown?**

- A `DivideByZeroException` exception is thrown when an attempt is made to divide an integral value by zero.

  ```
  Correct. A `DivideByZeroException` is thrown when trying to divide an integer or Decimal number by zero.
  ```

- A `DivideByZeroException` exception is thrown when an attempt is made to index an array outside the bounds of the array.
- A `DivideByZeroException` exception is thrown when an attempt is made to store a value of one type in an array of another type.

164. **When is an `IndexOutOfRangeException` exception thrown?**

- An `IndexOutOfRangeException` exception is thrown when an attempt is made to divide an integral value by zero.
- An `IndexOutOfRangeException` exception is thrown when an attempt is made to index an array outside the bounds of the array.

  ```
  Correct. An `IndexOutOfRangeException` exception is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.
  ```

- An `IndexOutOfRangeException` exception is thrown when an attempt is made to store a value of one type in an array of another type.

165. **When is an `InvalidCastException` exception thrown?**

- An `InvalidCastException` exception is thrown when an attempt is made to divide an integral value by zero.
- An `InvalidCastException` exception is thrown when an attempt is made to store a value of one type in an array of another type.
- An `InvalidCastException` exception is thrown when attempting an invalid casting or explicit conversion.

  ```
  Correct. An `InvalidCastException` exception is thrown when attempting an invalid casting or explicit conversion.
  ```

166. **When is a `NullReferenceException` exception thrown?**

- A `NullReferenceException` exception is thrown when attempting an invalid casting or explicit conversion.
- A `NullReferenceException` exception is thrown when an attempt is made to store a value of one type in an array of another type.
- A `NullReferenceException` exception is thrown when attempting to access a member on a type whose value is null.

  ```
  Correct. A `NullReferenceException` exception is thrown when attempting to access a member on a type whose value is null.
  ```


167. **What is the name of the base class that all derived exception types inherit from?**

- Object.
- System.
- Exception.

  ```
  Correct. In C#, `System.Exception` is the base class that all derived exception types inherit from.
  ```

168. **Which property of an exception object can be used to determine where an error occurred?**

- InnerException.
- StackTrace.

  ```
  Correct. The `StackTrace` property contains a stack trace that can be used to determine where an error occurred.
  ```

- TargetSite.

169. **What is the recommended approach for catching exceptions in C#?**

- Catch any type of exception without specifying an object argument.
- Catch only the exceptions that your code knows how to recover from.

  ```
  Correct. The recommended approach is to catch only the exceptions that your code knows how to recover from.
  ```

- Catch only the exceptions that are not derived from `System.Exception`.

170. **What is the name of the specific exception type that occurs when attempting to divide by zero in C#?**

- ArithmeticException.
- InvalidCastException.
- DivideByZeroException.

  ```
  Correct. In C#, the specific exception type that occurs when attempting to divide by zero is `DivideByZeroException`.
  ```

### **<ins>Section 6.4</ins>**:

171. **What is the purpose of the `StackTrace` property of an exception object?**

- To track the origin of the exception.

  ```
  Correct. The `StackTrace` property is often used to track the origin of the exception.
  ```

- To configure the properties of the exception.
- To throw the exception object.

172. **Which of the following code lines provides an example of customizing an exception with contextual information?**

- `throw new FormatException();`.
- `ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");`.

  ```
  Correct. This code sample demonstrates how to create an exception object with a custom `Message` property.
  ```

- `ArgumentNullException argumentNullException = new ArgumentNullException();`.

173. **A developer needs to create and throw an exception in a C# application. Which of the following descriptions is correct?**

- The exception type shouldn't match the intended purpose of the exception.
- The exception type that they create depends on the coding issue.

  ```
  Correct. The exception type created depends on the coding issue and should match the intended purpose of the exception as closely as possible.
  ```

- The process for throwing an exception object involves using the `catch` keyword.

174. **When should a method throw an exception?**

- A method should throw an exception when the method can complete its intended purpose.
- A method should throw an exception when the method can't complete its intended purpose.

  ```
  Correct. Methods should throw an exception whenever they can't complete their intended purpose.
  ```

- A method should throw an exception when an exception type matches the intended purpose of the method.

175. **A developer needs to create an exception object that includes a specific `Message` property. Which of the following statements is correct?**

- The `Message` property of an exception is writable.
- The `Message` property shouldn't explain the reason for the exception.
- The `Message` property should explain the reason for the exception.

  ```
  Correct. The `Message` property of an exception should explain the reason for the exception. Since `Message` is a read-only property, it must be assigned when instantiating the exception object.
  ```

### **<ins>Section 6.5</ins>**:

176. **What is the purpose of catching an exception in C#?**

- To ignore the errors that occur in a program.
- To generate other exceptions in a program.
- To take corrective action when an error occurs in a program.

  ```
  Correct. The purpose of catching an exception is to take corrective action when an error occurs.
  ```

177. **What is the relationship between the type of exception and the information it contains?**

- The type of exception and the information it contains are unrelated.
- The type of exception determines the information it contains.

  ```
  Correct. The type of exception determines the information it contains.
  ```

- The information contained in an exception determines the type of exception.

178. **What is a conditional breakpoint in Visual Studio Code?**

- A breakpoint that only triggers when a specified condition is met.

  ```
  Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met.
  ```

- A breakpoint that is triggered every time the code is run.
- A breakpoint that is only visible in the editor and doesn't affect debugging.

179. **When is an `ArgumentOutOfRangeException` exception thrown?**

- An `ArgumentOutOfRangeException` exception is thrown when an attempt is made to index an array outside the bounds of the array.
- An `ArgumentOutOfRangeException` exception is thrown when the value of an argument is outside the allowable range of values as defined by the method.

  ```
  Correct. An `ArgumentOutOfRangeException` exception should only be thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.
  ```

- An `ArgumentOutOfRangeException` exception is thrown when an attempt is made to store a value of one type in an array of another type.

180. **What is the recommended approach for catching exceptions in C#?**

- Catch any type of exception without specifying an object argument.
- Catch only the exceptions that your code knows how to recover from.

  ```
  Correct. The recommended approach is to catch only the exceptions that your code knows how to recover from.
  ```

- Catch only the exceptions that aren't derived from `System.Exception`.

### **<ins>Section 6.6</ins>**:

181. **How can a developer create a conditional breakpoint in Visual Studio Code?**

- Left-click in the column to the left of a line number in the code editor.
- Select Toggle Conditional Breakpoint on the Run menu.
- Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.

  ```
  Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint.
  ```

182. **In a launch configuration file, what is the console attribute used for?**

- Specifies the working directory of the target process.
- Specifies the type of debugger to use for this launch configuration.
- Specifies the type of console that's used when the application is launched.

  ```
  Correct. The `console` attribute specifies the type of console that's used when the application is launched. The options are `internalConsole`, `integratedTerminal`, and `externalTerminal`. The default setting is `internalConsole`.
  ```

183. **Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application?**

- The VARIABLES section.
- The CALL STACK section.

  ```
  Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application.
  ```

- The WATCH section.

184. **Which of the following options can be used to set a breakpoint in Visual Studio Code?**

- Left-click in the column to the left of a line number in the code editor.

  ```
  Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking.
  ```

- Select Toggle Breakpoint on the Edit menu.
- Right-click in the middle of a line of code, and then select Toggle Breakpoint.