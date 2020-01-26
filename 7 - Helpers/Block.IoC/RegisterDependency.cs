using Block.Business.Base;
using Block.Business.Base.Interfaces;
using Unity;
using Unity.Lifetime;

namespace Block.IoC
{
    public static class RegisterDependency
    {
        public static UnityContainer Register()
        {
            var container = new UnityContainer();

            // Services
            container.RegisterType<IServiceBasic, ServiceBasic>(new HierarchicalLifetimeManager());

            // Repositorys
            container.RegisterType<Block.Repository.Base.Interfaces.IServiceBasic, Block.Repository.Base.ServiceBasic>(new HierarchicalLifetimeManager());

            // DataAccess
            container.RegisterType<Block.DataAccess._1___Interfaces.IDbBasicOperations, Block.DataAccess._2___Implementations.DbBasicOperations>(new HierarchicalLifetimeManager());

            return container;
        }
    }        
}
