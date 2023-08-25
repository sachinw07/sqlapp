using sqlapp.Models;
using System.Data.SqlClient;

namespace sqlapp
{
    public class CustomerService
    {

        private static string db_source = "sachindbserver100.database.windows.net";
        private static string db_user = "forazure";
        private static string db_password = "#Sachinforlinux_123";
        private static string db_database = "sachinDB";

        private SqlConnection GetConnection()
        {

            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }
        public List<Customers> GetCustomers()
        {
            List<Customers> _product_lst = new List<Customers>();
            //string _statement = "SELECT ID, NAME, ADDRESS, SALARY FROM CUSTOMERS";
            //SqlConnection _connection = GetConnection();

            //_connection.Open();

            //SqlCommand _sqlcommand = new SqlCommand(_statement, _connection);

            //using (SqlDataReader _reader = _sqlcommand.ExecuteReader())
            //{
            //    while (_reader.Read())
            //    {
            //        Customers _customer = new Customers()
            //        {
            //            id = _reader.GetInt32(0),
            //            name = _reader.GetString(1),
            //            address = _reader.GetString(2),
            //            salary = _reader.GetString(2)
            //        };

            //        _product_lst.Add(_customer);
            //    }
            //}
            //_connection.Close();
            return _product_lst;
        }
    }
}
