using System.Collections.Generic;
using System.Linq;
using UnitTest.DataAccess;
using UnitTest.Entities;

namespace UnitTest.Business
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetCustomersByInitial(string initial)
        {
            return _customerDal.GetAll().Where(c => c.FirstName.StartsWith(initial)).ToList();
        }
    }
}
