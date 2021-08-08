using NeroAndStarbucksKahveDunyası.Abstract;
using NeroAndStarbucksKahveDunyası.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroAndStarbucksKahveDunyası.Concrete
{
    // "BaseCustomerManager" alarak Dolaylı olarak interface içerisindeki Save operasyonunuda almış oldu.
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        //dependcy injection
        private ICustomerCheckService customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        //Save metodunu burada override edebiliriz bunun yanısıra mernis doğrulaması isteyen starbucks için bu noktada mernis doğrulaması da yapılabilir..
        public override void Save(Customer customer)
        {
            if (customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil !");
            }
        }

       
    }
}
