using System;

namespace EFTuts.Data.Repository.Domain
{
    public class Customer
    {
        public int id { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public int Fax { get; set; }

    }
}
