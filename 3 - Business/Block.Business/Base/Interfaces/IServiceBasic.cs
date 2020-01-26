using System.Collections.Generic;

namespace Block.Business.Base.Interfaces
{
    public interface IServiceBasic
    {
        IEnumerable<T> GetAll<T>();
    }
}
