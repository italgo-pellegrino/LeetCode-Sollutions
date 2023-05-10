# Pivot Index Algorithm

The Pivot Index Algorithm is an algorithm that calculates the pivot index of an integer array. The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.
How it works

The algorithm works by first calculating the total sum of all elements in the array. It then traverses the array and calculates the left sum for each index, which is the sum of all elements to the left of the index. The right sum can be calculated as the difference between the total sum and the left sum, minus the current element. If the left sum and the right sum are equal for an index, that index is a pivot index.

## Here's the algorithm in pseudocode:

    totalSum = sum of all elements in the array
    leftSum = 0
    for i from 0 to length of array - 1
        if leftSum == totalSum - leftSum - nums[i]
            return i
        leftSum = leftSum + nums[i]
    return -1

