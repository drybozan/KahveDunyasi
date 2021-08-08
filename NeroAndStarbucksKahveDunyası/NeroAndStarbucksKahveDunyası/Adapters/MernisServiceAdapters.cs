using NeroAndStarbucksKahveDunyası.Abstract;
using NeroAndStarbucksKahveDunyası.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeroAndStarbucksKahveDunyası.Adapters
{
    public class MernisServiceAdapters : ICustomerCheckService
    {
        // Mernis e ait servise bağlanılarak kullanılan gerçek kişi kontrolü yapan service.
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client
                .TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
                    customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
