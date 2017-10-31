using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestWCFCustomer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomerService.svc or CustomerService.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        private static List<Customer> customers = new List<Customer>()
        {
            //new Customer(0, "Himler", "Davidson", 1927),
            new Customer(1, "Davy", "Jones", 1645)
        };

        private static int _nextId = 2;

        public string GetData()
        {
            return "Hi, my name is Jeff";
        }


        public IList<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer GetCustomer(string id)
        {
            int idNumber = int.Parse(id);
            return customers.FirstOrDefault(Customer => Customer.Id == idNumber);
        }

        public Customer GetCustomerByYear(string yearFragment)
        {
            int intYear = int.Parse(yearFragment);
            return customers.FirstOrDefault(Customer => Customer.Year.Equals(intYear));
        }

        public Customer AddCustomer(Customer customer)
        {
            customer.Id = _nextId++;
            customers.Add(customer);
            return customer;
        }

        public Customer UpdateCustomer(string id, Customer customer)
        {
            int idNumber = int.Parse(id);
            Customer existingCustomer = customers.FirstOrDefault(b => b.Id == idNumber);
            if (existingCustomer == null) return null;
            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LatName = customer.LatName;
            existingCustomer.Year = customer.Year;
            return existingCustomer;
        }

        public Customer DeleteCustomer(string id)
        {
            Customer customer = GetCustomer(id);
            if (customer == null) return null;
            bool removed = customers.Remove(customer);
            if (removed) return customer;
            return null;

        }


        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
