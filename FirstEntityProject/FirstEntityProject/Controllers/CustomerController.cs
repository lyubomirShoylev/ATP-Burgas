using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstEntityProject.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerService _custService;

        public CustomerController()
        {
            _custService = new CustomerService();
        }
        // GET: Customer
        public ActionResult AllCustomers()
        {
            IEnumerable<Customers> allCustomers = _custService.GetAllCustomers();
            return View(allCustomers);
        }

        [HttpGet]
        public ActionResult Insert()
        {

            return View(new Customers());
        }

        [HttpPost]
        public ActionResult Inserted(Customers customer)
        {
            customer.CustomerID = 
                (customer.ContactName +
                customer.Address +
                customer.Phone)
                .GetHashCode()
                .ToString()
                .Substring(0, 5);

            _custService.InsertCustomer(customer);
            return RedirectToAction("AllCustomers");
        }

        public ActionResult Details(string id)
        {
            Customers customer = _custService.GetCustomerWithDetails(id);

            return View(customer);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            Customers customer = _custService.GetCustomer(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edited(Customers cust)
        {
            _custService.EditCustomer(cust);
            return RedirectToAction("AllCustomers");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            _custService.DeleteCustomer(id);
            return RedirectToAction("AllCustomers");
        }
    }
}