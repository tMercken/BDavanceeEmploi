using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDemploi01
{
    public class Customer
    {
        public double AccountBalance { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EMail { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
        public string Remark { get; set; }

        public Customer()
        {
            this.AccountBalance = 3;
            this.AddressLine1 = "lol";
            this.AddressLine2 = "fe";
            this.City = "j";
            this.Country = "balgique";
            this.Name = "bob";
            this.PostCode = "gr";
            this.Remark = "nop";
            this.Id = 001;
        }
    }
}
