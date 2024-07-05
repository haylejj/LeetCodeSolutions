class Program
{
    /*
     You are given a 0-indexed array of string words and two integers left and right.

    A string is called a vowel string if it starts with a vowel character and ends with a vowel character where vowel characters are 'a', 'e', 'i', 'o', and 'u'.

    Return the number of vowel strings words[i] where i belongs to the inclusive range [left, right].
     */
    static void Main(string[] args)
    {

    }
    public int VowelStrings(string[] words, int left, int right)
    {
        int count = 0;
        string vowel= "aeiou";
        for (int i = left; i<=right; i++)
        {
            if (vowel.Contains(words[i][0]) && vowel.Contains(words[i][words[i].Length-1])) count++;
        }
        return count;
    }
}