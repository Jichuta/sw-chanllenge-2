namespace RomanNumerals
{
    public static class RomanNumeralConverter
    {
        public static readonly (string Roman, int Value)[] RomanNumerals = new (string, int)[]
        {
            ("M", 1000),
            ("D", 500),
            ("C", 100),
            ("L", 50),
            ("X", 10),
            ("V", 5),
            ("I", 1)
        };

        public static readonly Dictionary<string, int> RomanToIntegerSingleMap = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
        };

        public static readonly Dictionary<string, int> RomanToIntegerTwinMap = new Dictionary<string, int>
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },    
            { "CD", 400 },
            { "CM", 900 },
        };

        public static string ConvertToRoman(int number)
        {
            if (number == 0)
            {
                return string.Empty;
            }

            if (number > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be equal or less than 1000.");
            }

            if (number == 1000)
            {
                return "M";
            }

            if (number >= 1000)
            {
                return "M" + ConvertToRoman(number - 1000);
            }

            if (number >= 900)
            {
                return "CM" + ConvertToRoman(number - 900);
            }

            if (number >= 500)
            {
                return "D" + ConvertToRoman(number - 500);
            }

            if (number >= 400)
            {
                return "CD" + ConvertToRoman(number - 400);
            }

            if (number >= 100)
            {
                return "C" + ConvertToRoman(number - 100);
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

        public static int ConvertToInteger(string roman)
        {
            var total = 0;
            var index = 0;

            while (index < roman.Length)
            {
                if (index + 1 < roman.Length)
                {
                    var twin = roman.Substring(index, 2);
                    if (RomanToIntegerTwinMap.TryGetValue(twin, out var twinValue))
                    {
                        total += twinValue;
                        index += 2;
                        continue;
                    }
                }

                var oneCharacter = roman.Substring(index, 1);

                if (RomanToIntegerSingleMap.TryGetValue(oneCharacter, out var singleValue))
                {
                    total += singleValue;
                    index++;
                    continue;
                }
            
                throw new ArgumentOutOfRangeException(nameof(roman), "Invalid Roman numeral.");
            }
            

            return total;
        }
    }
}