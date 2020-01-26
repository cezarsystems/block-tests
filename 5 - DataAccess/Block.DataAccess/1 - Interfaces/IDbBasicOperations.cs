using System.Collections.Generic;

namespace Block.DataAccess._1___Interfaces
{
    public interface IDbBasicOperations
    {
        IEnumerable<T> GetAll<T>();
        bool InUpDe<T>(T obj);
    }
}