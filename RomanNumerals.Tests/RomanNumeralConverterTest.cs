

namespace RomanNumerals.Tests
{
    public class RomanNumeralConverterTest
    {
        [Fact]

        public void ConvertToRoman_ShouldReturnCorrectRomanNumeral()
        {
            // Act
            var result = RomanNumeralConverter.ConvertToRoman(1);

            // Assert
            Assert.Equal("I", result);
        }
    }
}