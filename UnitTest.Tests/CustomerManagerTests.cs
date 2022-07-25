using Moq;
using System.Collections.Generic;
using UnitTest.Business;
using UnitTest.DataAccess;
using UnitTest.Entities;
using Xunit;

namespace UnitTest.Tests
{
    public class CustomerManagerTests
    {
        Mock<ICustomerDal> _mockCustomerDal;
        List<Customer> _dbCustomers;

        public CustomerManagerTests()
        {
            _mockCustomerDal = new Mock<ICustomerDal>();
            _dbCustomers = new List<Customer>
            {
                new Customer { Id=1, FirstName="Ali"},
                new Customer { Id=2, FirstName="Ahmet"},
                new Customer { Id=3, FirstName="Ayşe"},
                new Customer { Id=4, FirstName="Aydın"},
                new Customer { Id=5, FirstName="Deniz"},
            };
            _mockCustomerDal.Setup(c => c.GetAll()).Returns(_dbCustomers);
        }
        [Fact]
        public void all_customers_count_check()
        {
            //Arrange
            ICustomerService customerService = new CustomerManager(_mockCustomerDal.Object);

            //Act
            List<Customer> customers = customerService.GetAll();

            //Assert
            Assert.Equal(5, customers.Count);

        }
        [Fact]
        public void start_d_customers_check_count()
        {
            ICustomerService customerService = new CustomerManager(_mockCustomerDal.Object);

            List<Customer> customers = customerService.GetCustomersByInitial("D");

            Assert.Equal(4, customers.Count);
        }
    }
}
