using NeroAndStarbucksKahveDunyası.Abstract;
using NeroAndStarbucksKahveDunyası.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroAndStarbucksKahveDunyası.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
