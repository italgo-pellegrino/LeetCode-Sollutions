public class Find_Pivot_Index
{
    // Calculates the pivot index of an integer array, where the sum of all numbers to the left 
    // the index is equal to the sum of all numbers to the right of the index.
    public int PivotIndex(int[] nums)
    {
        // Calculate the total sum of all elements in the array
        int totalSum = nums.Sum();

        // Initialize the left sum with 0
        int leftSum = 0;

        // Traverse the array and check if there is a pivot index
        for (int i = 0; i < nums.Length; i++)
        {
            // If the left sum is equal to the right sum, return the index
            if (leftSum == totalSum - leftSum - nums[i])
            {
                return i;
            }
            // Otherwise, add the current element to the left sum
            leftSum += nums[i];
        }

        // If no pivot index was found, return -1
        return -1;
    }
}