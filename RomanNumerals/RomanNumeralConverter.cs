namespace RomanNumerals
{
    public static class RomanNumeralConverter
    {
        public static readonly (string Roman, int Value)[] RomanNumerals = new (string, int)[]
        {
            ("M", 1000),
            ("CM", 900),
            ("D", 500),
            ("CD", 400),
            ("C", 100),
            ("XC", 90),
            ("L", 50),
            ("XL", 40),
            ("X", 10),
            ("IX", 9),
            ("V", 5),
            ("IV", 4),
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

        public static readonly Dictionary<string, int> RomanToIntegerComboMap = new Dictionary<string, int>
        {
            { "III", 3 },
            { "XXX", 30 },
            { "CCC", 300 },
        };

        public static readonly string[] WrongRomanTwinCombos = new string[]
        {
            "VV",
            "LL",
            "DD",
        };

        public static readonly string[] WrongRomanFourthCombos = new string[]
        {
            "IIII",
            "XXXX",
            "CCCC",
            "MMMM"
        };

        public static string ConvertToRoman(int number)
        {
            if (number == 0)
            {
                return string.Empty;
            }

            if (number < 0 || number > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be greater than 0 or less than 1001.");
            }

            foreach (var (roman, value) in RomanNumerals)
            {
                if (number >= value)
                {
                    return roman + ConvertToRoman(number - value);
                }
            }
            
            throw new ArgumentOutOfRangeException(nameof(number), "Out of range number.");
        }

        public static int ConvertToInteger(string roman)
        {
            var total = 0;
            var index = 0;

            var length = roman.Length;

            if(length >= 4 && WrongRomanFourthCombos.Any(combo => roman.Contains(combo)))
            {
                throw new ArgumentOutOfRangeException(nameof(roman), "Invalid Roman numeral.");
            }

            while (index < roman.Length)
            {
                if (index + 1 < roman.Length)
                {
                    var twin = roman.Substring(index, 2);

                    if (WrongRomanTwinCombos.Contains(twin))
                    {
                        throw new ArgumentOutOfRangeException(nameof(roman), "Invalid Roman numeral.");
                    }

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
