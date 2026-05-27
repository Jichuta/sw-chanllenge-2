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

        public static readonly Dictionary<string, int> RomanToIntegerMap = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
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
            var romanLength = roman.Length;

            var numberList = new List<int>();
            for (int i = 0; i < romanLength; i++)
            {
                var temp = roman[i].ToString();

                if (RomanToIntegerMap.TryGetValue(temp, out var value))
                {
                    numberList.Add(value);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(roman), "Invalid Roman numeral.");
                }
            }

            Console.WriteLine(string.Join(", ", numberList));

            var total = 0;
            if (numberList.Count == 1)
            {
                return numberList[0];
            }
            else if (numberList.Count % 2 == 0)
            {
                for (int i = 0; i < numberList.Count; i += 2)
                {
                    if (numberList[i] < numberList[i+1])
                    {
                        total += numberList[i + 1] - numberList[i]; 
                    }
                    else
                    {
                        total += numberList[i] + numberList[i + 1];
                    }
                }
            }
            else
            {
                for (int i = 0; i < numberList.Count - 1; i += 2)
                {
                    if (numberList[i] < numberList[i + 1])
                    {
                        total += numberList[i + 1] - numberList[i];
                    }
                    else
                    {
                        total += numberList[i] + numberList[i + 1];
                    }
                }

                total += numberList.Last();
            }
            

            return total;
        }
    }
}