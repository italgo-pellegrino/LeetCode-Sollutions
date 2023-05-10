using System;

/// <summary>
/// Computes the running sum of the input array.
/// </summary>
/// <param name="nums">The input array of integers.</param>
/// <returns>An array of integers containing the running sum of the input array.</returns>
/// @author Italgo Walter Pellegrino
public class RunningSumOf1DArray
{

    public int[] RunningSum(int[] nums)
    {
        // Create an output array of the same size as the input array.
        int[] output = new int[nums.Length];

        // Compute the running sum of the input array.
        output[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            output[i] = output[i - 1] + nums[i];
        }
        return output;

    }

    public static void Main()
    {        
        RunningSumOf1DArray runningSumOf1DArray = new RunningSumOf1DArray();
        int[] runSum = runningSumOf1DArray.RunningSum(new int[] { 1, 3, 8 });

        System.Console.Write("[");
           foreach(int i in runSum)
        {
           System.Console.Write(i);
            if(i != runSum.Last())
            {
                System.Console.Write(',');
            }
        }
        System.Console.Write("]");
    }

   
}