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