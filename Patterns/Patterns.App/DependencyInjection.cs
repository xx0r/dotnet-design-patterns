using Patterns.Contracts;

namespace Patterns.App
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using SimpleInjector;

    public class DependencyInjection
    {
        private static readonly Container _container;

        static DependencyInjection()
        {
            _container = new Container();
        }

        public static void RegisterDependencies()
        {
            _container.Register(typeof(ICommandHandler<>));
        }

    }
}
