using NeroAndStarbucksKahveDunyası.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroAndStarbucksKahveDunyası.Abstract
{
    /// Müşteri kaydetme operasyonu ortaktır bu nedenle abstract bir class içerisine tanımlanabilir.
    public abstract class BaseCustomerManager : ICustomerService
    {

        public virtual void Save(Customer customer)
        {
            Console.WriteLine(" Veritabanına kaydedildi : "+ customer.FirstName);
        }
    }
}
