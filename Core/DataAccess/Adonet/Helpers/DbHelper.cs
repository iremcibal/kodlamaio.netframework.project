using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Adonet.Helpers
{
    public class DbHelper
    {
        public static List<T> CreateReadCommand<T>(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            return DataReaderMapToList<T>(reader);

        }

        public static List<T> DataReaderMapToList<T>(IDataReader dataReader)
        {
            List<T> list = new List<T>();

            T objectToMap  = default(T);

            while (dataReader.Read())
            {
                objectToMap = Activator.CreateInstance<T>();

                foreach (PropertyInfo propertyInfo in objectToMap.GetType().GetProperties())
                {
                    if (!object.Equals(propertyInfo.Name, DBNull.Value))
                    {
                        propertyInfo.SetValue(objectToMap,dataReader[propertyInfo.Name],null);
                    }
                }
                list.Add(objectToMap);
            }
            return list;
        }
    }
}
