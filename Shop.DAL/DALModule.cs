using Autofac;
using Shop.DAL.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL
{
    public class DALModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ShopDbContext>()
                .AsSelf().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(BookRepository).GetTypeInfo().Assembly)
                  .Where(t => t.Name.EndsWith("Repository"))
                  .AsImplementedInterfaces();
        }
    }
}
