using System.Text;

class Program
{
    /*
     * International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:

    'a' maps to ".-",
    'b' maps to "-...",
    'c' maps to "-.-.", and so on.
    For convenience, the full table for the 26 letters of the English alphabet is given below:

    [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
    Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.

    For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
    Return the number of different transformations among all words we have.
     */
    static void Main(string[] args)
    {

    }
    public int UniqueMorseRepresentations(string[] words)
    {
        Dictionary<string, string> morseAlfabe = new Dictionary<string, string>()
        {
            {"a", ".-"},
            {"b", "-..."},
            {"c", "-.-."},
            {"d", "-.."},
            {"e", "."},
            {"f", "..-."},
            {"g", "--."},
            {"h", "...."},
            {"i", ".."},
            {"j", ".---"},
            {"k", "-.-"},
            {"l", ".-.."},
            {"m", "--"},
            {"n", "-."},
            {"o", "---"},
            {"p", ".--."},
            {"q", "--.-"},
            {"r", ".-."},
            {"s", "..."},
            {"t", "-"},
            {"u", "..-"},
            {"v", "...-"},
            {"w", ".--"},
            {"x", "-..-"},
            {"y", "-.--"},
            {"z", "--.."},
        };
        HashSet<string> result = new HashSet<string>();
        foreach (var item in words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var letter in item)
            {
                stringBuilder.Append(morseAlfabe[letter.ToString()]);
            }
            result.Add(stringBuilder.ToString());
        }
        return result.Count;
    }
}