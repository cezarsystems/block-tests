using Block.DataAccess._1___Interfaces;
using System;
using System.Collections.Generic;
using Block.DataAccess._0___Base;
using System.Data.SqlClient;
using Dapper;

namespace Block.DataAccess._2___Implementations
{
    public class DbBasicOperations : IDbBasicOperations
    {
        private readonly SqlConnection _sqlConnection;

        public DbBasicOperations()
        {
            _sqlConnection = DbFactoryConnection.DbFactory();
        }

        public IEnumerable<T> GetAll<T>()
        {
            try
            {
                using (_sqlConnection)
                {
                    string sqlQuery = "SELECT * FROM [dbo].[Pessoa]";

                    if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                        _sqlConnection.Open();

                    IEnumerable<T> dataResult = _sqlConnection.Query<T>(sql: sqlQuery);
                    return dataResult;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar os dados no Banco: " + ex.Message);
            }
        }

        public bool InUpDe<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
