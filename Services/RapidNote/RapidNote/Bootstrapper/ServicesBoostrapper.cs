using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using PasswordHasher.Interfaces;

namespace RapidNote.Bootstrapper
{
    public class ServicesBoostrapper : Autofac.Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            RegisterPasswordHasher(containerBuilder);
        }

        private void RegisterPasswordHasher(ContainerBuilder containerBuilder)
        {
            containerBuilder
                .RegisterType<PasswordHasher.Services.PasswordHasher>()
                .As<IPasswordHasher>();
        }
    }
}
