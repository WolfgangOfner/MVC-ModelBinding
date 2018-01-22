using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer
            {
                PersonId = 1,
                FirstName = "Wolfgang",
                LastName = "Ofner",
                Role = Role.Admin
            },
            new Customer
            {
                PersonId = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Role = Role.User
            },
            new Customer
            {
                PersonId = 3,
                FirstName = "John",
                LastName = "Doe",
                Role = Role.Guest
            },
        };

        public ActionResult Index(int id = 1)
        {
            var dataItem = _customers.First(p => p.PersonId == id);

            return View(dataItem);
        }

        public ActionResult CreateCustomer()
        {
            return View(new Customer());
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer model)
        {
            return View("Index", model);
        }

        public ActionResult DisplayAddressShort([Bind(Prefix = "Address", Exclude = "City")]
            AddressShort summary)
        {
            return View(summary);
        }
    }
}