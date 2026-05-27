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

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 100.");
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

            switch (number)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                case 10:
                    return "X";
                default:
                    throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 10.");
            }
        }
    }
}