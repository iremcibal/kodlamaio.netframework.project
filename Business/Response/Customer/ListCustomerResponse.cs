using System;

namespace Business.Response.Customer
{
    public class ListCustomerResponse
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }  
        public DateTime BirthDate { get; set; }
    }
}