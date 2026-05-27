namespace RomanNumerals
{
    public static class RomanNumeralConverter
    {
        public static string ConvertToRoman(int number)
        {
            if (number == 0)
            {
                return string.Empty;
            }

            if (number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be equal or less than 100.");
            }

            if (number == 100)
            {
                return "C";
            }

            if (number >= 90)
            {
                return "XC" + ConvertToRoman(number - 90);
            }

            if (number >= 50)
            {
                return "L" + ConvertToRoman(number - 50);
            }

            if (number >= 40)
            {
                return "XL" + ConvertToRoman(number - 40);
            }

            if (number >= 10)
            {
                return "X" + ConvertToRoman(number - 10);
            }

            if (number >= 9)
            {
                return "IX" + ConvertToRoman(number - 9);
            }

            if (number >= 5)
            {
                return "V" + ConvertToRoman(number - 5);
            }

            if (number >= 4)
            {
                return "IV" + ConvertToRoman(number - 4);
            }

            if (number >= 1)
            {
                return "I" + ConvertToRoman(number - 1);
            }

            throw new ArgumentOutOfRangeException(nameof(number), "Number must be greater than or equal to 1.");
        }
    }
}