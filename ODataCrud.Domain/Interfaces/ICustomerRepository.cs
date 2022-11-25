using ODataCrud.Domain.Models;

namespace ODataCrud.Domain.Interfaces;

public interface ICustomerRepository
{
    IEnumerable<Customer> GetAll();
}