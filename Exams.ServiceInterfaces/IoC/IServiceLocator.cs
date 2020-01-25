using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.ServiceInterfaces.IoC
{
    public interface IServiceLocator
    {
        T Resolve<T>() where T : class;
        void BeginScope();
        void EndScope();
    }
}
