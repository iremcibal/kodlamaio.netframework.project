using Business.Adapters;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CustomerBusinessRules
    {
        private IIdentityAdapter _identityAdapter;
        ICustomerDal _customerDal;

        public CustomerBusinessRules(IIdentityAdapter identityAdapter, ICustomerDal customerDal)
        {
            _identityAdapter = identityAdapter;
            _customerDal = customerDal;
        }

        public void IsIdentityValid(string IdentityNumber , string FirstName,string LastName , int BirthDate)
        {
            var isIdentity =_identityAdapter.CheckIdentityNumber(Convert.ToInt64(IdentityNumber),FirstName,LastName,BirthDate);
            if (!isIdentity) throw new Exception("Kimlik Doğrulanamadı.");

        }
    }
}
