using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Block.DataAccess._0___Base
{
    public class DbFactoryConnection : IDisposable
    {
        private static string _connectionString;
        private static SqlConnection _sqlConnection;

        static DbFactoryConnection()
        {
            _connectionString = ConfigurationManager
                    .ConnectionStrings["SqlConnectionDb"].ConnectionString;
        }

        public static SqlConnection DbFactory()
        {
            try
            {
                _sqlConnection = new SqlConnection()
                {
                    ConnectionString = _connectionString                    
                };

                return _sqlConnection;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler a Connection String do arquivo: " + ex.Message);
            }            
        }

        public void Dispose()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Open)
                _sqlConnection.Close();

            if (_sqlConnection != null)
            {
                _sqlConnection = null;
                DbFactory().Dispose();
            }

            if (string.IsNullOrEmpty(_connectionString))
                _connectionString = string.Empty;
        }
    }
}
