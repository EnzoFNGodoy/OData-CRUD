using ODataCrud.Domain.Interfaces;
using ODataCrud.Domain.Models;
using ODataCrud.Infra.Data;

namespace ODataCrud.Infra.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public IEnumerable<Customer> GetAll()
    {
        return CustomersData.Customers;
    }
}