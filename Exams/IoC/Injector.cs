using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exams.IoC
{
    public class Injector
    {
        public static Container CreateContainer()
        {
            var container = new Container();
            container.Options.DefaultLifestyle = new AsyncScopedLifestyle();            
        }
    }
}