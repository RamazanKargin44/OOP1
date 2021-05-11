using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.CustomerId = "1";
            individualCustomer1.CustomerName = "ahmet";
            individualCustomer1.CustomerSurname = "yıldız";
            individualCustomer1.TcNo = "42352352";
            individualCustomer1.Id = 1;

            CoorporateCustomer coorporateCustomer1 = new CoorporateCustomer();
            coorporateCustomer1.CompanyName = "yıldız holding";
            coorporateCustomer1.CustomerId = "34";
            coorporateCustomer1.Id = 5;
            coorporateCustomer1.VergiNo = "564456";

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CoorporateCustomer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer1);
            customerManager.Add(coorporateCustomer1);
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
