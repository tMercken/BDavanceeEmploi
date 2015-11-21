using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using ProjetBDemploi01;
using System.Linq;
using System.Collections.Generic;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContext>());

            CompanyContext context = new CompanyContext(@"Data Source=vm-sql.iesn.be\Stu3IG;User ID=IG3A8;Password=pwUserdb39");
            Customer client01 = new Customer();
            context.Customers.Add(client01);
            context.SaveChanges();
            TestHasCustomer();
        }

        public void TestHasCustomer()
        {
            CompanyContext context = new CompanyContext(@"Data Source=vm-sql.iesn.be\Stu3IG;User ID=IG3A8;Password=pwUserdb39");
            Assert.IsTrue(context.Customers.Count() > 0);
        }
    }
}
