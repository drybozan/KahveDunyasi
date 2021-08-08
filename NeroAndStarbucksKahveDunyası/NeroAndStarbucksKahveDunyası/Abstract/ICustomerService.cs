using NeroAndStarbucksKahveDunyası.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroAndStarbucksKahveDunyası.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
