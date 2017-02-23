/* 
 * Test cases to the solution
*/
using System;
using Xunit;

namespace Two_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        [Fact]
        public void Test_3_2_4_TwoSum_6()
        {
            // Arrange
            int target = 6;
            int[] nums = new int[] { 3, 2, 4 };
            int[] expected = new int[] { 1, 2 };

            // Act
            int[] actual = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_3_3_TwoSum_6()
        {
            // Arrange
            int target = 6;
            int[] nums = new int[] { 3, 3 };
            int[] expected = new int[] { 0, 1 };

            // Act
            int[] actual = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_3_2_3TwoSum_6()
        {
            // Arrange
            int target = 6;
            int[] nums = new int[] { 3, 2, 3 };
            int[] expected = new int[] { 0, 2 };

            // Act
            int[] actual = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_2_5_5_11_TwoSum_10()
        {
            // Arrange
            int target = 10;
            int[] nums = new int[] { 2, 5, 5, 11 };
            int[] expected = new int[] { 1, 2 };

            // Act
            int[] actual = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_n3_4_3_90_TwoSum_0()
        {
            // Arrange
            int target = 0;
            int[] nums = new int[] { -3, 4, 3, 90 };
            int[] expected = new int[] { 0, 2 };

            // Act
            int[] actual = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_5_75_25_TwoSum_100()
        {
            // Arrange
            int target = 100;
            int[] nums = new int[] { 5, 75, 25 };
            int[] expected = new int[] { 1, 2 };

            // Act
            int[] actual = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_2_2_5_TwoSum_7()
        {
            // Arrange
            int target = 7;
            int[] nums = new int[] { 2, 2, 5 };
            int[] expected = new int[] { 0, 2 };

            // Act
            int[] actual = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
