# Review the Principles of Code Debugging and Exception Handling

One of the most important aspects of being a software developer is successfully troubleshooting issues, and some of the most effective ways to do this would be **code debugging** and **exception handling**.

## Code Debugging

**Code debugging** refers to the practice of using tools called **debuggers** to isolate and fix issues in code logic.

**Debuggers** allow you to observe and control the execution path of your code as it runs. This enables you to analyze your code one line at a time, in real time, to see if that line of code runs properly.

In this manner, you can analyze your code methodically, rather than manually outputting random statements throughout your code to observe behavior.

## Exception Handling

On the other hand, **exception handling** refers to the practice of 'correcting' errors that may occur in your program. In short, if your program has an error in it, it will "throw" an exception, and catch it, probably by outputting a specific error message, and then terminating gracefully. However, you can 'correct' this situation by writing a "catch" statement in an attempt to remedy the error (exception), and allowing your program to continue running or outputting an error message and also exiting gracefully.

More technically, an exception is like a variable of which there are many different types, and in which you can access the contents of. The type of exception determines the kind of information that it contains. Using a "catch" block, you can choose how you want to handle the exception.

Thusly, "throwing" and "catching" an exception.