namespace ModelBinding.Models
{
    public class Customer
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public Role Role { get; set; }
    }
}