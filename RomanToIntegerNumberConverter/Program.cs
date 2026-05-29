using RomanNumerals;

Console.WriteLine("Enter a Roman numeral between I and M to convert to an integer:");
var romanNumber = Console.ReadLine();

try
{
    if (string.IsNullOrEmpty(romanNumber))
    {
        Console.WriteLine("Error: Roman numeral cannot be empty.");
        return;
    }
    Console.WriteLine($"The integer for {romanNumber} is: {RomanNumeralConverter.ConvertToInteger(romanNumber)}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

