using NeroAndStarbucksKahveDunyası.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroAndStarbucksKahveDunyası.Abstract
{

    // Mernis kontrolünü bugün için Starbucks istiyor olabilir ancak yarın diğer kahve satıcıları da isteyebilir bu nedenle interface üzerinden implemente etmekte fayda var.

    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
