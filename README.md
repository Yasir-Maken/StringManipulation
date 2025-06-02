# String Manipulation Fun in C#! ✨

Hey there! 👋 Welcome to this little corner of code where we play around with words and letters using the magic of C#.

## What This Code Does 🧪

Think of this as a handy toolkit for taking strings (that's just fancy talk for text!) and doing some cool things with them. Inside, you'll find three neat tools:

1.  **The Character Counter 🔍:** Imagine you have a sentence, and you're curious about how many uppercase letters, lowercase letters, numbers, spaces, and other special symbols it has. This tool will go through your text like a super-sleuth and count them all up for you!

2.  **The Palindrome Checker 🔄:** Ever wondered if a word or phrase reads the same forwards and backward (like "racecar" or "madam")? This tool is like a palindrome detective! Give it a string, and it will tell you if it's a palindrome (true!) or not (false!). It even ignores whether the letters are big or small and doesn't care about spaces.

3.  **The Word Reverser 🗣️➡️🗣️:** Got a sentence you want to flip the order of words in? This tool takes a sentence like "Hello World" and turns it into "World Hello". It's like a fun word puzzle!

## How to Use It 🚀

If you have .NET 8 installed on your computer (which you do, awesome!), you can run this code quite easily:

1.  **Save the Code:** Make sure you've saved the `Program.cs` file with all the code we wrote earlier in the `StringManipulation` folder.

2.  **Open Your Terminal:** Go back to your terminal and navigate to the `StringManipulation` folder.

3.  **Run the Magic Command:** Type the following command and press Enter:

    ```bash
    dotnet run
    ```

    This command tells .NET to build and run your code.

4.  **See the Results! 🎉:** The program will then show you the results of the character counter for a sample string. After that, it will ask you to type in a string to check if it's a palindrome and then a sentence to reverse the words. Just follow the instructions on the screen!

## Behind the Scenes (A Little Peek) 👀

This code uses some cool C# features like:

* **`for` loops:** To go through each letter in a string one by one.
* **`if` and `else if`:** To make decisions based on what kind of character we're looking at (uppercase, lowercase, etc.).
* **`char.IsUpper()`, `char.IsLower()`, `char.IsDigit()`, `char.IsWhiteSpace()`:** These are like built-in helpers in C# that make it easy to figure out what type of character we have.
* **`ToLower()`:** To make all letters lowercase for the palindrome check so that "Racecar" and "racecar" are seen as the same.
* **`Split(' ')`:** To chop a sentence into individual words based on the spaces.
* **`Array.Reverse()`:** To flip the order of words in the list.
* **`string.Join(" ", ...)`:** To put the reversed words back together into a sentence with spaces in between.

## Enjoy! 😄

Have fun playing around with these string tools! If you have any ideas for more cool things we can do with strings, feel free to share!
