using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDemploi01 
{
    public class CompanyContext : DbContext
    {
        public DbSet<Customer> Customers;

        public CompanyContext(String connectionString) : base(connectionString)
        {
        }
    }
}
