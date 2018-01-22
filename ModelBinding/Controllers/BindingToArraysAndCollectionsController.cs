using System.Collections.Generic;
using System.Web.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class BindingToArraysAndCollectionsController : Controller
    {
        public ActionResult Countries(string[] countries)
        {
            countries = countries ?? new string[0];

            return View(countries);
        }

        public ActionResult Cities(IList<string> cities)
        {
            cities = cities ?? new List<string>();

            return View(cities);
        }

        public ActionResult Address(IList<AddressShort> addresses)
        {
            addresses = addresses ?? new List<AddressShort>();

            return View(addresses);
        }
    }
}