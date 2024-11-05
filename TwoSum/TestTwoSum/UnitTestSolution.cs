
using TwoSum;

namespace TestTwoSum
{
    public class UnitTestSolution
    {
        TwoSumSolution solution = new TwoSumSolution();

        [Fact]
        public void Test1()
        {
            var result = solution.TwoSum([1, 2, 3, 4, 5], 9);
            Assert.Equal(new int[] { 3, 4 }, result);
        }

        [Fact]
        public void Test2()
        {
            var result = solution.TwoSum([9, 4, 8, 32, 89], 97);
            Assert.Equal(new int[] { 2, 4 }, result);
        }

        [Fact]
        public void Test3()
        {
            Assert.Throws<InvalidOperationException>(() => solution.TwoSum([1, 2, 3, 4, 5], 10));
        }
    }
}