using Autofac;
using IRepository.BaseIRespitory;
using Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BoardCore.Extensions
{
    public class AutofacModuleRegister : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var BasePath = AppContext.BaseDirectory;
            var ServiceDll = Path.Combine(BasePath, "Service.dll");
            var RepositoryDll = Path.Combine(BasePath, "Repository.dll");

            var AssemblysServices = Assembly.LoadFrom(ServiceDll);
            builder.RegisterAssemblyTypes(AssemblysServices)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();

            var AssemblysRepository = Assembly.LoadFrom(RepositoryDll);
            builder.RegisterAssemblyTypes(AssemblysRepository)
                       .AsImplementedInterfaces()
                       .InstancePerDependency();

            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
