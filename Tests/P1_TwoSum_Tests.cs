using Solutions;
using Xunit;

namespace Tests;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
///
/// Example 1:
///
/// Input: nums = [2,7,11,15], target = 9
/// Output: [0,1]
/// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
/// Example 2:
///
/// Input: nums = [3,2,4], target = 6
/// Output: [1,2]
/// Example 3:
///
/// Input: nums = [3,3], target = 6
/// Output: [0,1]
///
///
/// Constraints:
///
/// * 2 <= nums.length <= 10^4
/// * -10^9 <= nums[i] <= 10^9
/// * -10^9 <= target <= 10^9
/// * Only one valid answer exists.
///
///
/// Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
/// </summary>
public sealed class P1_TwoSum_Tests
{
    public static IEnumerable<object[]> TestData
    {
        get
        {
            yield return new object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } };
            yield return new object[] { new[] { 3, 2, 4 }, 6, new[] { 1, 2 } };
            yield return new object[] { new[] { 3, 3 }, 6, new[] { 0, 1 } };
        }
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void FirstAttempt(int[] nums, int target, int[] expected)
    {
        var actual = P1_TwoSum_Solutions.FirstAttempt(nums, target);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void SecondAttempt(int[] nums, int target, int[] expected)
    {
        var actual = P1_TwoSum_Solutions.SecondAttempt(nums, target);

        Assert.Equal(expected, actual);
    }
}
