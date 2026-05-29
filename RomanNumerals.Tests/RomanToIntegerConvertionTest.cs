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

        [Theory]
        [InlineData("XI", 11)]
        [InlineData("XIV", 14)]
        [InlineData("XXX", 30)]
        [InlineData("XXXIV", 34)]
        [InlineData("XXXIX", 39)]
        [InlineData("XL", 40)]
        [InlineData("XLV", 45)]
        [InlineData("XLIX", 49)]
        [InlineData("L", 50)]
        public void ConvertToInteger_ShouldReturnCorrectIntegerFrom11To50(string roman, int expected)
        {
            // Act
            var result = RomanNumeralConverter.ConvertToInteger(roman);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("A")]
        [InlineData("ABC")]
        [InlineData("IIII")]
        [InlineData("XXXX")]
        [InlineData("VV")]
        [InlineData("LL")]
        public void ConvertToInteger_ShouldThrowExceptionForInvalidRomanNumeral(string roman)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => RomanNumeralConverter.ConvertToInteger(roman));
        }
    }
}
