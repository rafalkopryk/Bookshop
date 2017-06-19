using Autofac;
using Shop.BLL.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL
{
    public class BLLModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(BookService).GetTypeInfo().Assembly)
                  .Where(t => t.Name.EndsWith("Service"))
                  .AsImplementedInterfaces();
        }
    }
}
