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

        // I will make an array to store the results
        double[] result = new double[length];

        // I will use a loop to fill the array
        int i = 0;
        while (i < length)
        {
            // I think we need to multiply the number by i + 1
            double value = number * (i + 1);

            // Put it in the array
            result[i] = value;

            // Go to next index
            i = i + 1;
        }

        // Now return the array
        return result;
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
        // I think we need to save the last values first
        List<int> lastItems = new List<int>();

        int start = data.Count - amount;
        for (int i = start; i < data.Count; i++)
        {
            lastItems.Add(data[i]);
        }

        // Now remove the last ones
        for (int i = 0; i < amount; i++)
        {
            data.RemoveAt(data.Count - 1);
        }

        // Now add them back to the beginning
        for (int i = 0; i < lastItems.Count; i++)
        {
            data.Insert(i, lastItems[i]);
        }
    }
}
