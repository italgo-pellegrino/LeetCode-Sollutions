using System.Text;
using System.Collections.Generic;

public class IsomorphicStrings
{
    public static void Main()
    {
        IsomorphicStrings isM = new IsomorphicStrings();
        System.Console.WriteLine(isM.IsIsomorphic("bbbaaaba", "aaabbbba"));

    }

    // This method checks if the two strings s and t are isomorphic, meaning that a character in s can be replaced by a different character in t such that the two strings become identical.
    // The method returns true if the strings are isomorphic, and false if they are not.
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        // Creates the "code" string for s and t by assigning an integer to each character in s and t that indicates the index of the character in s or t.
        string sCode = codeString(s, t);
        string tCode = codeString(t, s);

        // Returns true if the two "code" strings are equal, false otherwise.
        return sCode == tCode;
    }

    // This private method creates the "code" string for the given string s by assigning an integer to each character in s that indicates the index of the character in s and t.
    // The "code" string is a combination of the indexes of characters in s and t.
    // The method returns the generated "code" string.
    private string codeString(string s, string t)
    {
        Dictionary<char, int> mapS = new Dictionary<char, int>();
        Dictionary<char, int> mapT = new Dictionary<char, int>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            char cS = s[i];
            char cT = t[i];

            // If character cS appears for the first time, its index in s is added to the mapS dictionary.
            if (!mapS.ContainsKey(cS))
            {
                mapS[cS] = i;
            }

            // If character cT appears for the first time, its index in t is added to the mapT dictionary.
            if (!mapT.ContainsKey(cT))
            {
                mapT[cT] = i;
            }

            // Appends the indexes of cS and cT as part of the "code" string to the StringBuilder sb.
            sb.Append(mapS[cS]);
            sb.Append(mapT[cT]);
        }

        // Returns the generated "code" string.
        return sb.ToString();
    }
}
