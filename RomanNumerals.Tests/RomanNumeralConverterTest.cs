

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
        [InlineData(11, "XI")]
        [InlineData(30, "XXX")]
        [InlineData(34, "XXXIV")]
        [InlineData(40, "XL")]
        [InlineData(45, "XLV")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        public void ConvertToRoman_ShouldReturnCorrectRomanNumeralForTens(int number, string expected)
        {
            // Act
            var result = RomanNumeralConverter.ConvertToRoman(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(51, "LI")]
        [InlineData(60, "LX")]
        [InlineData(70, "LXX")]
        [InlineData(80, "LXXX")]
        [InlineData(89, "LXXXIX")]
        [InlineData(90, "XC")]
        [InlineData(99, "XCIX")]
        [InlineData(100, "C")]
        public void ConvertToRoman_ShouldReturnCorrectRomanNumeralFrom51To100(int number, string expected)
        {
            // Act
            var result = RomanNumeralConverter.ConvertToRoman(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(101)]
        [InlineData(115)]
        public void ConvertToRoman_ShouldThrowExceptionForOutOfRangeNumbers(int number)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => RomanNumeralConverter.ConvertToRoman(number));
        }
    }
}