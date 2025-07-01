using System.Runtime.InteropServices.Marshalling;

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

        // PLAN:
        // 1. Create a list to store the result.
        // 2. Use a for loop that runs from 1 to the specified length.
        // 3. In each loop iteration, multiply the base number by the loop index.
        // 4. Add the result of the multiplication to the result list.
        // 5. After the loop, convert the list to an array and return it.
        List<double> result = new();
        for (double i = 1; i <= length; ++i)
        {
            result.Add(number * i);
        }
        return result.ToArray(); // replace this return statement with your own
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

        // PLAN:
        // 1. Get the last 'amount' elements from the list (these will move to the front).
        // 2. Get the rest of the list (the elements that stay behind).
        // 3. Combine both parts into a new list.
        // 4. Copy the combined list back into the original list.
        int count = data.Count;
        List<int> end = data.GetRange(count - amount, amount);
        List<int> start = data.GetRange(0, count - amount);

        List<int> rotated = new();
        rotated.AddRange(end);
        rotated.AddRange(start);

        for (int i = 0; i < count; i++)
        {
            data[i] = rotated[i];
        }
    }
}
