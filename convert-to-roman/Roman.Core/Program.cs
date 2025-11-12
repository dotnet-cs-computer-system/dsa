// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var numberToRomans = new Dictionary<uint, string>()
{
    {1000, "M"},
    {900, "CM"},
    {500, "D"},
    {400, "CD"},
    {100, "C"},
    {90, "XC"},
    {50, "L"},
    {40, "XL"},
    {10, "X"},
    {9, "IX"},
    {5, "V"},
    {4, "IV"},
    {1, "I"}
};

var roman39 = ToRoman(39);
Console.WriteLine($"{(roman39 == "XXXIX")}");

var roman246 = ToRoman(246);
Console.WriteLine($"{(roman246 == "CCXLVI")}");

var roman789 = ToRoman(789);
Console.WriteLine($"{(roman789 == "DCCLXXXIX")}");

string ToRoman(uint n)
{
    foreach(var numberRoman in numberToRomans)
    {
        if (numberRoman.Key <= n)
        {
            return numberRoman.Value + ToRoman(n - numberRoman.Key);
        }
    }
    return "";
}
