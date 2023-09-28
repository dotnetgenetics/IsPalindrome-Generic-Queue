using IsPalindromeGenericQueue;

namespace IsPalindromeGenericQueueTest
{
    public class IsPalindromeTest
    {
        private IsPalindromeQueue sut;

        public IsPalindromeTest()
        {
           sut = new IsPalindromeQueue();
        }

        [Fact]
        public void ShouldValidateIsPalindromeString()
        {
            //arrange
            bool status;

            //act
            status = sut.IsPalindromic<char>("LIRIL");

            //assert
            Assert.True(status);
        }

        [Fact]
        public void ShouldValidateIsPalindromeStringArray()
        {
            //arrange
            bool status;

            //act
            status = sut.IsPalindromic<string>(new string[] { "mango", "apple", "mango" });

            //assert
            Assert.True(status);
        }

        [Fact]
        public void ShouldValidateIsPalindromeIntArray()
        {
            //arrange
            bool status;

            //act
            status = sut.IsPalindromic<int>(new int[] { 1, 2, 3, 4, 5, 6, 0, 6, 5, 4, 3, 2, 1 });

            //assert
            Assert.True(status);
        }

        [Fact]
        public void ShouldValidateIsPalindromeFloatArray()
        {
            //arrange
            bool status;

            //act
            status = sut.IsPalindromic<float>(new float[] { 1.34F, 2.34F, 1.34F });

            //assert
            Assert.True(status);
        }

        [Fact]
        public void ShouldFailIsPalindromeFloatArray()
        {
            //arrange
            bool status;

            //act
            status = sut.IsPalindromic<float>(new float[] { 1.34F, 2.34F, 43.1F });

            //assert
            Assert.False(status);
        }

        [Fact]
        public void ShouldFailIsPalindromeString()
        {
            //arrange
            bool status;

            //act
            status = sut.IsPalindromic<char>("GREG");

            //assert
            Assert.False(status);
        }
    }
}