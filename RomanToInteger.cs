using System;
/*
 * This Programm converts a roman numeral to an integer.Range [1,3999] with supported letters :I;V;X;L;C;D;M 
 * @author Italgo Walter Pellegrino
 */
public class RomanToInteger
{   
    int sum = 0;

    public static void Main()
    {
        RomanToInteger romanToInteger = new RomanToInteger();
        Console.WriteLine("Type your roman number:");
        string romanInput = Console.ReadLine(); //Read Input
        Console.WriteLine("Result: " + romanToInteger.RomanToInt(romanInput));
    }

    // This method converts a roman numeral to an integer
    public int RomanToInt(string s)
    {
        char[] sChar = s.ToCharArray();
        for(int i = 0; i < s.Length;i++)
        {
            switch (sChar.GetValue(i))
            {
                case 'I':
                    {
                        if (i != s.Length-1)
                        {
                            //First special case: I infront of V or X. Substract 1
                            if (sChar.GetValue(i + 1).Equals('V') || sChar.GetValue(i + 1).Equals('X'))
                            {
                                sum -= 1;
                                continue;
                            }
                        }
                        sum += 1;
                        continue;
                    }
                case 'V':
                    {
                        sum += 5;
                        continue;
                    }
                case 'X':
                    {
                        if (i != s.Length - 1)
                        {
                            //Second special case: X infront of L or C. Substract 10
                            if (sChar.GetValue(i + 1).Equals('L') || sChar.GetValue(i + 1).Equals('C'))
                            {
                                sum -= 10;
                                continue;
                            }
                        }
                        sum += 10;
                        continue;
                    }
                case 'L':
                    {
                        sum += 50;
                        continue;
                    }
                case 'C':
                    {
                        if (i != s.Length - 1)
                        {
                            //Third special case: C infront of D or M. Substract 100
                            if (sChar.GetValue(i + 1).Equals('D') || sChar.GetValue(i + 1).Equals('M'))
                            {
                                sum = sum - 100;
                                continue;
                            }
                        }
                        sum += 100;
                        continue;
                    }
                case 'D':
                    {
                        sum += 500;
                        continue;
                    }
                case 'M':
                    {
                        sum += 1000;
                        continue;
                    }
                default:
                    {
                        return sum;
                    }
            }
        }
        return sum;
    }
}