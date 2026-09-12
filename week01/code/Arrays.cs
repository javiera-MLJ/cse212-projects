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
        // To perform this function, we first create a list to store the results of the multiples of the requested number.
        List<double> results = new();
        // Next, we create a for loop to generate the list of options for the required number of multiples, limiting the total to the value specified in `length`.
        for (int i = 1; i <= length; ++i) {
            //Finally, we need to calculate the result of the multiples by multiplying `number` by the loop results, and then add that to the list we created to store the answer.
            results.Add(number * i);
            }
        //Finally, the list is returned, and `.ToArray()` is added to convert our list into a `double[]`.
        return results.ToArray();
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
        //To begin, we create a conditional check to handle cases where the list is empty,
        //thereby avoiding errors; we also implement a division operation to prevent incorrect full loops through the list and avoid an overflow.
        if(data.Count == 0) return;
        amount = amount % data.Count;
        //Next, we create a new temporary list to hold our data, and we calculate the index positions that need to be shifted within the list by 
        //performing a subtraction.
        List<int> dataList = new();
        int p = data.Count-amount;
        //First, we specify the range to place at the beginning of our list—specifically, the numbers from the break point to the end.
        List<int> f = data.GetRange(p, amount);
        dataList.AddRange(f);
        //...to then arrange the numbers from the beginning up to the break point, and organize it that way.
        List<int> s = data.GetRange(0, p);
        dataList.AddRange(s);
        //Finally, since our function is a `void` type, we cannot return the `dataList`; instead, we clear the `data` so we can add the data from our `dataList` to it.
        data.Clear();
        data.AddRange(dataList);
    }
}
