using RomanNumerals;

Console.WriteLine("Enter an integer between 1 and 1000 to convert to a Roman numeral:");
var number = Console.ReadLine();

try
{
    if (int.TryParse(number, out var parsedNumber))
    {
        Console.WriteLine($"The Roman numeral for {number} is: {RomanNumeralConverter.ConvertToRoman(parsedNumber)}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        return;
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    return;
}
