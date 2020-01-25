using Exams.ServiceInterfaces.IoC;
using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using System;
using SimpleInjector.Lifestyles;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exams.IoC
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly Container container;
        private Scope _scope;

        public ServiceLocator(Container container)
        {
            this.container = container;
        }

        
        public void BeginScope()
        {
            _scope = AsyncScopedLifestyle.BeginScope(container);
        }

        public void EndScope()
        {
            _scope.Dispose();
        }

        public T Resolve<T>() where T : class
        {
            return this.container.GetInstance<T>();
        }
    }
}