namespace RomanNumerals.Tests
{
    public class RomanToIntegerConvertionTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        public void ConvertToInteger_ShouldReturnCorrectInteger(string roman, int expected)
        {
            // Act
            var result = RomanNumeralConverter.ConvertToInteger(roman);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}