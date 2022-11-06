using Business.KPSService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters
{
    public class KPSIdentityAdapter : IIdentityAdapter
    {

        public bool CheckIdentityNumber(long IdentityNumber, string FirstName, string LastName, int BirthYear)
        {
            using (KPSPublicSoapClient client = new KPSPublicSoapClient())
            {
                return client.TCKimlikNoDogrula(IdentityNumber, FirstName, LastName, BirthYear);
            }
        }
    }
}
