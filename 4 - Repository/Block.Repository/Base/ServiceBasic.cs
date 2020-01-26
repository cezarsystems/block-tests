using Block.Repository.Base.Interfaces;
using System.Collections.Generic;

namespace Block.Repository.Base
{
    public class ServiceBasic : IServiceBasic
    {
        private readonly Block.DataAccess._1___Interfaces.IDbBasicOperations _dbBasicOperations;

        public ServiceBasic(Block.DataAccess._1___Interfaces.IDbBasicOperations dbBasicOperations)
        {
            _dbBasicOperations = dbBasicOperations;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return _dbBasicOperations.GetAll<T>();
        }
    }
}
