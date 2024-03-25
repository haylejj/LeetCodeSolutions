using System;

class Program
{
    

    static void Main(string[] args)
    {
        Console.WriteLine(CountValidWords("!this  1-s b8d! "));
    }
    /*
      A sentence consists of lowercase letters ('a' to 'z'), digits ('0' to '9'), hyphens ('-'), punctuation marks ('!', '.', and ','), and spaces (' ') only. 
      Each sentence can be broken down into one or more tokens separated by one or more spaces ' '.
      A token is a valid word if all three of the following are true:

     It only contains lowercase letters, hyphens, and/or punctuation (no digits).
     There is at most one hyphen '-'. If present, it must be surrounded by lowercase characters ("a-b" is valid, but "-ab" and "ab-" are not valid).
     There is at most one punctuation mark. If present, it must be at the end of the token ("ab,", "cd!", and "." are valid, but "a!b" and "c.," are not valid).
     Examples of valid words include "a-b.", "afad", "ba-c", "a!", and "!".

     Given a string sentence, return the number of valid words in sentence.
     */
    public static int CountValidWords(string sentence)
    {
        string[] tokens = sentence.Split(' ');
        int validCount = 0;

        foreach (string token in tokens)
        {
            if (IsValidWord(token))
            {
                validCount++;
            }
        }

        return validCount;
    }

    public static bool IsValidWord(string word)
    {
        bool hasLetter = false;
        bool hasPunctuation = false;
        bool hasHyphen=false;
        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            if (char.IsLetter(c))
            {
                hasLetter = true; // Set hasLetter upon encountering a letter
            }
            else if (char.IsPunctuation(c))
            {
                if (hasPunctuation || i != word.Length - 1) // Check punctuation at the end only
                {
                    return false;
                }
                hasPunctuation = true;
            }
            else if (c == '-')
            {
                if (hasHyphen || i == 0 || i == word.Length - 1 || !char.IsLetter(word[i - 1]) || !char.IsLetter(word[i + 1])) // Check hyphen between letters
                {
                    return false;
                }
                hasHyphen = true;
            }
        }

        // Additional check for digits
        if (word.Any(char.IsDigit))
        {
            return false; // No digits allowed in a valid word
        }

        // Special case for compound words with hyphen
        if (hasHyphen && word.Length > 1)
        {
            return true;
        }

        return hasLetter; // Return true only if there's at least one letter
    }
}
