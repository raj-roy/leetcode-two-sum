namespace TwoSum
{
    public class TwoSumSolution
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="target">Traget value</param>
        /// <returns>Indices of he two numbers that add upto the value</returns>
        /// <exception cref="InvalidOperationException">Throws InvalidOperationException if no such solution exists.</exception>
        public int[] TwoSum(int[] nums, int target)
        {
            // Dictionary to hold the answer keys
            Dictionary<int, int> map = new Dictionary<int, int>();

            //Loop through each item in the array
            for (int i = 0; i < nums.Length; i++)
            {
                //Get the second number
                int complement = target - nums[i];

                //If the second number is present return the second number and item at position i.
                //Else, store the item at position i in the dictionary
                if (map.ContainsKey(complement))
                {
                    return [map[complement], i];
                }
                map[nums[i]] = i;
            }
            // Throws error if a valid solution is not present.
            throw new InvalidOperationException("No two sum solution");
        }
    }
}
