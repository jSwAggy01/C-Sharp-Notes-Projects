# Create Readable Code with Conventions, Whitespace, and Comments in C#

"You only write code once, but you will read it many times."

"The hardest part of software development is naming things" (Martin Fowler).

Readability is key when it comes to software development since writing code i.e. programming is the easy part. The hard part is maintaining code for which you have no idea what's going on. This is why it is crucial to writing code that can be easily understoon by fellow SWE's especially when working on a team.

## Clean v. Ugly Code

Take a look at this example:

```cs
/* Exhibit A (Ugly code): */

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a  char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new string(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

/* Exhibit B (Clean code): */

/*
    The high-level purpose of this code is to reverse a string
    and count the number of times a particular character appears.
*/
string sentence = "The quick brown fox jumps over the lazy dog.";
char[] characterList = sentence.ToCharArray();

Array.Reverse(characterList);

int letter_o_appearances = 0;

foreach (char character in characterList)
{
    if (character == 'o')
    {
        letter_o_appearances++;
    }
}

string sentenceReversed = new string(characterList);

Console.WriteLine(sentenceReversed);
Console.WriteLine($"'o' appears {letter_o_appearances} times.");
```

Which chunk of code is easier to read, Exhibit A or Exhibit B?

If you can't decide, I'll let Google's `Bard` answer that question for you.

**Me**:

*Bard, could you elaborate as to why one chunk of code is considered ugly and the other chunk of code is considered clean?*

**Bard**:

I'd be happy to explain the differences that make one code chunk cleaner than the other:

### Exhibit A (Ugly Code):

**Readability Issues**:

- <ins>Poorly named variables</ins>: Names like str, charMessage, and x are vague and uninformative, making the code harder to grasp.
- <ins>Lack of comments</ins>: No comments explain the code's purpose or logic, hindering understanding.
- <ins>Inconsistent indentation</ins>: Uneven indentation makes the code's structure less clear.

**Maintainability Issues**:

- <ins>Tightly coupled logic</ins>: The string reversal and character counting are mixed together, making it harder to modify one aspect without affecting the other.
- <ins>Unclear variable usage</ins>: The purpose of variables like charMessage and new_message is not immediately evident.

### Exhibit B (Clean Code):

**Improved Readability**:

- <ins>Descriptive variable names</ins>: Names like sentence, characterList, and letter_o_appearances clearly convey their roles.
- <ins>Comment explaining purpose</ins>: The comment at the beginning outlines the code's overall goal, providing context.
-  <ins>Consistent indentation</ins>: The code is formatted with consistent indentation, improving readability.

**Enhanced Maintainability**:

- <ins>Separated concerns</ins>: The string reversal and character counting are performed in distinct blocks, making the code more modular and easier to modify.
- <ins>Meaningful variable names</ins>: The choice of variable names helps to self-document the code's functionality.

**Additional Considerations**:

- <ins>Meaningful comments</ins>: Comments could be added to further explain specific steps or logic within the code.
- <ins>Descriptive output</ins>: Output could be formatted more descriptively (e.g., "The reversed sentence is: ...").

Overall, Exhibit B demonstrates better coding practices that prioritize readability, maintainability, and clarity, making it easier to understand, modify, and collaborate on.