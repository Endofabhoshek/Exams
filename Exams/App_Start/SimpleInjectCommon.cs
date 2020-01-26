[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Exams.App_Start.SimpleInjectCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(Exams.App_Start.SimpleInjectCommon), "Stop")]

namespace Exams.App_Start
{

    using Exams.IoC;
    public class SimpleInjectCommon
    {
        public static void RegisterServices()
        {
            System.Web.Mvc.DependencyResolver.SetResolver(Injector.CreateContainer());
        }
    }
}