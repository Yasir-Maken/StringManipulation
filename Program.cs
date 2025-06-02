using System;

namespace StringManipulation
{
    class Program
    {
        // 1. Character Counter Method
        public static void AnalyzeString(string text)
        {
            int uppercaseCount = 0; // To store the count of uppercase letters
            int lowercaseCount = 0; // To store the count of lowercase letters
            int digitCount = 0;     // To store the count of digits
            int spaceCount = 0;     // To store the count of spaces
            int otherCount = 0;     // To store the count of other characters

            // Loop through each character in the input string
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i]; // Get the current character

                if (char.IsUpper(currentChar)) // Check if the character is uppercase
                {
                    uppercaseCount++;
                }
                else if (char.IsLower(currentChar)) // Check if the character is lowercase
                {
                    lowercaseCount++;
                }
                else if (char.IsDigit(currentChar)) // Check if the character is a digit
                {
                    digitCount++;
                }
                else if (char.IsWhiteSpace(currentChar)) // Check if the character is a whitespace (like space, tab, newline)
                {
                    spaceCount++;
                }
                else // If none of the above, it's considered another special character
                {
                    otherCount++;
                }
            }

            // Print the counts to the console
            Console.WriteLine($"Original String: {text}");
            Console.WriteLine($"Uppercase Letters: {uppercaseCount}");
            Console.WriteLine($"Lowercase Letters: {lowercaseCount}");
            Console.WriteLine($"Digits: {digitCount}");
            Console.WriteLine($"Spaces: {spaceCount}");
            Console.WriteLine($"Other Special Characters: {otherCount}");
            Console.WriteLine(); // Add an empty line for better readability
        }

        // 2. Palindrome Checker Method
        public static bool IsPalindrome(string text)
        {
            // Convert the string to lowercase to ignore case
            string lowerCaseText = text.ToLower();

            // Remove all spaces from the string
            string noSpaceText = "";
            foreach (char c in lowerCaseText)
            {
                if (!char.IsWhiteSpace(c))
                {
                    noSpaceText += c;
                }
            }

            // Use two pointers, one at the start and one at the end
            int left = 0;
            int right = noSpaceText.Length - 1;

            // Loop as long as the left pointer is before the right pointer
            while (left < right)
            {
                // If the characters at the left and right are not the same, it's not a palindrome
                if (noSpaceText[left] != noSpaceText[right])
                {
                    return false; // Return false immediately
                }
                left++;  // Move the left pointer one step to the right
                right--; // Move the right pointer one step to the left
            }

            // If the loop completes without finding any mismatched characters, it's a palindrome
            return true;
        }

        // 3. Word Reverser Method
        public static string ReverseWords(string sentence)
        {
            // Split the sentence into an array of words using space as the delimiter
            string[] words = sentence.Split(' ');

            // Reverse the order of the words in the array
            Array.Reverse(words);

            // Join the reversed words back into a string with spaces in between
            string reversedSentence = string.Join(" ", words);

            return reversedSentence;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------String Manipulation App!-------");
            Console.WriteLine("-----Yasir Maken QTS Doha Intern!-----\n");            

            // Demonstrate the AnalyzeString method
            Console.WriteLine("--- Character Counter ---");
            AnalyzeString("Hello World 123!@#");
            Console.WriteLine();

            // Demonstrate the IsPalindrome method
            Console.WriteLine("--- Palindrome Checker ---");
            Console.Write("Enter a string to check for palindrome: ");
            string palindromeInput = Console.ReadLine();
            if (IsPalindrome(palindromeInput))
            {
                Console.WriteLine($"\"{palindromeInput}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{palindromeInput}\" is not a palindrome.");
            }
            Console.WriteLine();

            // Demonstrate the ReverseWords method
            Console.WriteLine("--- Word Reverser ---");
            Console.Write("Enter a sentence to reverse the words: ");
            string sentenceInput = Console.ReadLine();
            string reversedWords = ReverseWords(sentenceInput);
            Console.WriteLine($"Reversed sentence: {reversedWords}");
        }
    }
}