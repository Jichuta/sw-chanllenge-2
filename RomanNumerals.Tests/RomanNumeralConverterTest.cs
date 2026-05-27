

namespace RomanNumerals.Tests
{
    public class RomanNumeralConverterTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        public void ConvertToRoman_ShouldReturnCorrectRomanNumeral(int number, string expected)
        {
            // Act
            var result = RomanNumeralConverter.ConvertToRoman(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(15)]
        public void ConvertToRoman_ShouldThrowExceptionForOutOfRangeNumbers(int number)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => RomanNumeralConverter.ConvertToRoman(number));
        }
    }
}