using Block.Business.Base.Interfaces;
using System.Collections.Generic;

namespace Block.Business.Base
{
    public class ServiceBasic : IServiceBasic
    {
        private readonly Repository.Base.Interfaces.IServiceBasic _serviceBasic;

        public ServiceBasic(Repository.Base.Interfaces.IServiceBasic serviceBasic)
        {
            _serviceBasic = serviceBasic;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return _serviceBasic.GetAll<T>();
        }
    }
}