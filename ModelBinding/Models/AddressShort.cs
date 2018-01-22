using System.Web.Mvc;

namespace ModelBinding.Models
{
    [Bind(Include = "Country")]
    public class AddressShort
    {
        public string City { get; set; }

        public string Country { get; set; }
    }
}