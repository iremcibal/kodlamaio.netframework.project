using Core.DataAccess.Adonet.Helpers;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Adonet
{
    public class AdoEmployeeDal : IEmployeeDal
    {
        public List<Employee> GetAll()
        {
            List<Employee> employees = DbHelper.CreateReadCommand<Employee>("select * from employees");
            return employees;
        }
    }
}
