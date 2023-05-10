using System;
/**
 * This class implements the problem of finding the longest common prefix of an array of strings. 
 * It provides two methods for solving this problem: lCPVertical, which uses vertical scanning,
 * and lCPHorizontal, which uses horizontal scanning. The main method is used to test the two
 * methods and print the result to the console.
 *
 * @author Italgo Walter Pellegrino
 */
public class Longest_Common_Prefix
{
    String[] strs = { "flower","flower","flow","florian" };
    String result = "";

   public static void Main(string[] args)
    {
      String output = "";
        
        Longest_Common_Prefix longest_Common_Prefix = new Longest_Common_Prefix();

        //Choose one algorithm
        //output = longest_Common_Prefix.lCPVertical(longest_Common_Prefix.strs);
        output = longest_Common_Prefix.lCPHorizontal(longest_Common_Prefix.strs);
        Console.WriteLine(output);
    }
   
    Longest_Common_Prefix()
    {
        strs = this.strs;
        result = this.result;
    }

    /*
     * This method implements the vertical scanning algorithm to find the longest common prefix.
     * It takes an array of strings strs as input and returns the longest common prefix as a string.
     * It first checks if the first string in the array is empty, if so, it returns an empty string.
     * It then iterates over the characters of the first string and compares them with the corresponding
     * characters in the other strings. If a mismatch is found, it returns the prefix found so far.
     * Otherwise, it appends the matching character to the prefix and continues the iteration.
     */
    public string lCPVertical(string[] strs)
    {
        if(strs[0].Equals(""))
        {
            return result;
        }
        char temp = strs[0].ElementAt<char>(0);

        for (int j = 0; j < maxLength(strs); j++)
        {
            temp = strs[0].ElementAt<char>(j);
            for (int i = 0; i < strs.Length; i++)
            {
                if (!strs[i].ElementAt<char>(j).Equals(temp))
                {
                    return result.ToString();
                }               
            }
            result += temp;
        }        
        return result.ToString();
    }


    /*
     * This method implements the horizontal scanning algorithm to find the longest common prefix. It takes an
     * array of strings strs as input and returns the longest common prefix as a string. It first checks if the
     * input array is null or empty, if so, it returns an empty string. It initializes the prefix to the first
     * string in the array and iterates over the remaining strings, repeatedly removing the last character from
     * the prefix until it is a prefix of the current string. If the prefix becomes empty, it returns an empty 
     * string. Otherwise, it returns the prefix.  
     */
    public string lCPHorizontal(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                {                  
                    return "";
                }
            }
        }
        return prefix;
    }

   /*
    * This method takes an array of strings str as input and returns the length of the shortest string in the array.
    * It initializes a variable i to the maximum possible integer value and iterates over the strings in the array,
    * updating the value of i to the length of the current string if it is shorter than i.
    */
    public int maxLength(string[] str)
    {
        int i = int.MaxValue;
        foreach (String s in str)
        {
            if (s.Length < i)
            {
                i = s.Length;
            }
        }
        return i;
    }
}