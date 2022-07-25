using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Entities;

namespace UnitTest.DataAccess
{
    public class CustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersByInitial(string initial)
        {
            throw new NotImplementedException();
        }
    }
}
