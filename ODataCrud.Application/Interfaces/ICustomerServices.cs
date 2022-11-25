using ODataCrud.Domain.Models;

namespace ODataCrud.Application.Interfaces;

public interface ICustomerServices
{
    IQueryable<Customer> GetAll();
}