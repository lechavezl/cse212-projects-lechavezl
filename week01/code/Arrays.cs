public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // --- STEP-BY-STEP PLAN ---
        // 1. Initialize a new array of doubles with the size specified by the 'length' parameter.
        // 2. Create a loop that will run 'length' times to calculate each multiple.
        // 3. In each iteration, calculate the multiple by multiplying the base 'number' by (i + 1).
        //    For example: if number is 7, the first element (i=0) is 7 * 1 = 7.
        // 4. Store the calculated value into the current index of the array.
        // 5. After the loop finished, return the populated array.

        // 1. Initialize the array with the given length
        double[] multiples = new double[length];

        // 2. Loop through the array to calculate values
        for (int i = 0; i < length; i++)
        {
            // 3 & 4. Calculate the multiple and assign it to the array index
            // We use (i + 1) because multiples usually start from number * 1
            multiples[i] = number * (i + 1);
        }

        // 5. Return the resulting array
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // --- STEP-BY-STEP PLAN ---
    // 1. Identify the split point: The elements to move to the front are the last 'amount' elements.
    // 2. Extract those elements: Use GetRange starting from (data.Count - amount) for 'amount' items.
    // 3. Remove the elements from their original position: Use RemoveRange at the end of the list.
    // 4. Insert the elements at the beginning: Use InsertRange starting at index 0.

    // Handle edge cases where the list is empty or rotation is not needed
    if (data.Count <= 1 || amount == 0 || amount == data.Count)
    {
        return;
    }

    // 1. Determine the index where the slice starts
    int splitIndex = data.Count - amount;

    // 2. Create a temporary list containing the segment that will be moved to the front
    List<int> sliceToMove = data.GetRange(splitIndex, amount);

    // 3. Delete those elements from the end of the original list to avoid duplicates
    data.RemoveRange(splitIndex, amount);

    // 4. Place the extracted segment at the very start of the list
    data.InsertRange(0, sliceToMove);
    }
}
