using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerService
    {
        private NORTHWNDEntities _Db;

        public CustomerService()
        {
            _Db = new NORTHWNDEntities();
        }

         public IEnumerable<Customers> GetAllCustomers()
         {
             IEnumerable<Customers> cust =
                 from customer in _Db.Customers
                 select customer;

             return cust;
         }

         public Customers GetCustomer(string id)
         {
             Customers cust =
                 (from customer in _Db.Customers
                 where customer.CustomerID == id
                 select customer).SingleOrDefault();

             return cust;
         }

         public Customers GetCustomerWithDetails(string id)
         {
             Customers cust =
                 (from customer in _Db.Customers
                  join order in _Db.Orders
                  on customer.CustomerID equals order.CustomerID
                  where customer.CustomerID == id
                  select customer).Distinct().SingleOrDefault();

             return cust;
         }

        public void InsertCustomer(Customers customer)
        {
            _Db.Customers.Add(customer);
            _Db.SaveChanges();
        }

        public void EditCustomer(Customers customer)
        {
            Customers cust =
                (from customers in _Db.Customers
                 where customers.CustomerID == customer.CustomerID
                 select customers).SingleOrDefault();

            cust.CompanyName = customer.CompanyName;
            cust.City = customer.City;
            cust.Address = customer.Address;
            cust.Country = customer.Country;
            cust.Fax = customer.Fax;
            cust.Phone = customer.Phone;
            cust.ContactName = customer.ContactName;
            _Db.SaveChanges();

        }

        public void DeleteCustomer(string id)
        {
            Customers cust = this.GetCustomer(id);
            _Db.Customers.Remove(cust);
            _Db.SaveChanges();
        }
    }
}
