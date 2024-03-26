using System;

class Program
{
    

    static void Main(string[] args)
    {
        Console.WriteLine(CountValidWords("a-!b"));
    }
    
    public static int CountValidWords(string sentence)
    {
        string[] tokens = sentence.Split(' ',StringSplitOptions.RemoveEmptyEntries);
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
    public static bool IsValidWord(string word)
    {
        int countHyphen = 0;
        int countPunctuation = 0;

        // No digits and uppercase letters allowed in a valid word
        if (word.Any(x=> char.IsDigit(x) || char.IsUpper(x)))
        {
            return false; 
        }

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];
            if(c == '-' )
            {

                if (countHyphen ==0)
                {
                    countHyphen++;
                    if (i+1 < word.Length && i >0)
                    {
                        if (!char.IsLetter(word[i-1])&&char.IsLetter(word[i+1])) return false;
                        // tire işaretine bi daha kontrol eklenebilir
                        
                    }
                    else
                    {
                        if (i==word.Length-1) return false;
                        else if (word.Length==1) return false;
                        
                    }
                }
                else return false;
                
            }

            else if (char.IsPunctuation(word[i]) )
            {
                
                    if (countPunctuation == 0)
                    {
                            countPunctuation++;
                            if (i+1 < word.Length && i >0)
                            {
                                if (char.IsLetter(word[i-1])&&char.IsLetter(word[i+1])) return false;
                                else if (word[i+1] ==  '-' || word[i-1]=='-') return false;
                                // tire işaretine bi daha kontrol eklenebilir
                                else return true;
                            }
                            else
                            {
                                if (i==word.Length-1) return true;
                                else if (word.Length==1) return true;
                                else return false;
                            }
                    }
                    else 
                    return false;
                
            }
        }
        return true;
    }
}
