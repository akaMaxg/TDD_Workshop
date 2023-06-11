using WordLib_MaxG;

namespace WordLibTest_MaxG
{
    [TestClass]
    public class WordLibTests
    {
        [TestMethod]
        public void IsPalindrome()
        {
            // Arrange
            string input = "noon";
            string expectedResult = "noon";
            Palindrome palindrome = new Palindrome();

            // Act
            string result = palindrome.ReverseString(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void EvenlyDividableByFive()
        {
            //Arrange
            int input = 10;
            int expectedResult = 0;

            Dividable dividable = new Dividable();

            //Act
            int result = dividable.Modulo(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}