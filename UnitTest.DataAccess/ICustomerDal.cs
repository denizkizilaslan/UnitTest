using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Entities;

namespace UnitTest.DataAccess
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
        List<Customer> GetCustomersByInitial(string initial);
    }
}
