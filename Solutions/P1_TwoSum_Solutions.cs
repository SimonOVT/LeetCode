namespace Solutions;

public static class P1_TwoSum_Solutions
{
    public static int[] FirstAttempt(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
        }

        return new int[2] { -1, -1 };
    }

    public static int[] SecondAttempt(int[] nums, int target)
    {
        var numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            numIndices[nums[i]] = i;
        }

        throw new ArgumentException("No two elements sum up to the target.");
    }
}
