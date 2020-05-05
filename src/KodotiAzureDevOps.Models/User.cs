using System;

namespace KodotiAzureDevOps.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string MedicareBeneficaryNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Passport { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
    }
}
