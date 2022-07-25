using System.Collections.Generic;
using UnitTest.Entities;

namespace UnitTest.Business
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetCustomersByInitial(string initial);
    }
}
