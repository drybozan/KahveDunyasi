using NeroAndStarbucksKahveDunyası.Abstract;
using NeroAndStarbucksKahveDunyası.Concrete;
using NeroAndStarbucksKahveDunyası.Entities;
using NeroAndStarbucksKahveDunyası.Adapters;
using System;

namespace NeroAndStarbucksKahveDunyası
{
    class Program
    {
        static void Main(string[] args)
        {
            //mernis doğrulama isteyen Starbucks
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapters());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 3, 7), FirstName = "Derya", LastName = "Bozan", NationalityId = "17444444444" });

            //herhangi doğrulama istemeyen Nero
            BaseCustomerManager customerManager2 = new NeroCustomerManager();
            customerManager2.Save(new Customer { DateOfBirth = new DateTime(1999, 3, 9), FirstName = "Ali", LastName = "Kaya", NationalityId = "1784596587455" });
            Console.WriteLine();
        }
    }
}
