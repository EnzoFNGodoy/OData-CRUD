using ODataCrud.Domain.Models;

namespace ODataCrud.Infra.Data;

public static class CustomersData
{
    private static readonly Random _random = new();

    public static readonly List<Customer> Customers = Enumerable.Range(1, 100)
        .Select(i => new Customer
            (i, GenerateName(), GenerateAge(), GenerateDateTime()))
        .ToList();

    private static string GenerateName()
    {
        var length = _random.Next(4, 10);
        string[] consonants = 
            { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        string[] vowels = 
            { "a", "e", "i", "o", "u", "ae", "y" };
        var name = "";
        
        name += consonants[_random.Next(consonants.Length)].ToUpper();
        name += vowels[_random.Next(vowels.Length)];
        
        var timesNewLetterAdded = 2;
        while (timesNewLetterAdded < length)
        {
            name += consonants[_random.Next(consonants.Length)];
            timesNewLetterAdded++;
            name += vowels[_random.Next(vowels.Length)];
            timesNewLetterAdded++;
        }

        return name;
    }

    private static int GenerateAge() => _random.Next(12, 50);

    private static DateTime GenerateDateTime()
    {
        var start = new DateTime(1995, 1, 1);
        var range = (DateTime.Today - start).Days;           
        return start.AddDays(_random.Next(range));
    }
}