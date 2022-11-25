using System.ComponentModel.DataAnnotations;

namespace ODataCrud.Domain.Models;

public class Customer
{
    public Customer(int id, string name, int age, DateTime createdAt)
    {
        Id = id;
        Name = name;
        Age = age;
        CreatedAt = createdAt;  
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    public DateTime CreatedAt { get; private set; }
}