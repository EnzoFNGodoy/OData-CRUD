using ODataCrud.Application.Interfaces;
using ODataCrud.Domain.Interfaces;
using ODataCrud.Domain.Models;

namespace ODataCrud.Application.Services;

public class CustomerServices : ICustomerServices
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerServices(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public IQueryable<Customer> GetAll()
    {
        return _customerRepository
            .GetAll()
            .AsQueryable();
    }
}