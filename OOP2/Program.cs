using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoorporateCustomer customer1 = new CoorporateCustomer();
            customer1.Id = 1;
            customer1.CompanyName = "Kodlama.io";
            customer1.CustomerNumber = "12345";
            customer1.TaxNumber = "123456895";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.Tc = "5555555";
            customer2.Adı = "Mert";
            customer2.Soyadı = "Akkaya";

            Customer customer3 = new CoorporateCustomer();
            customer3.Id = 4;
            customer3.CustomerNumber = "555";

            Customer customer4 = new IndividualCustomer();
            customer4.Id = 5;
            customer4.CustomerNumber = "66666";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer4);
        }
    }
}
