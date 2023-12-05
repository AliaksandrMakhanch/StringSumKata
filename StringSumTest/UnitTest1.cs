using StringSumApp;
using Xunit;

namespace StringSumApp
{
    public class StringSumTest
    {
        private readonly StringSumUtility _stringSumUtility = new StringSumUtility();

        [Fact]
        public void Test_EmptyStrings()
        {
            string num1 = "";
            string num2 = "";
            string expectedResult = "0";

            string result = _stringSumUtility.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test_SmallNumbers()
        {
            string num1 = "5";
            string num2 = "10";
            string expectedResult = "15";

            string result = _stringSumUtility.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test_OneEmptyString()
        {
            string num1 = "11";
            string num2 = "";
            string expectedResult = "11";

            string result = _stringSumUtility.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test_NegativeNumbers()
        {
            string num1 = "-5";
            string num2 = "-10";
            string expectedResult = "0";

            string result = _stringSumUtility.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test_NonNumericStrings()
        {
            string num1 = "2A";
            string num2 = "3B";
            string expectedResult = "0";

            string result = _stringSumUtility.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test_LargeNumbers()
        {
            string num1 = "123456";
            string num2 = "654321";
            string expectedResult = "777777";

            string result = _stringSumUtility.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }
    }
}