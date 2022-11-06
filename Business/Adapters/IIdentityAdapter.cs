using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters
{
    public interface IIdentityAdapter
    {
        bool CheckIdentityNumber(long IdentityNumber,string FirstName, string LastName, int BirthYear);
    }
}
