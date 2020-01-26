using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block.Repository.Base.Interfaces
{
    public interface IServiceBasic
    {
        IEnumerable<T> GetAll<T>();
    }
}
