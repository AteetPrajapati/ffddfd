using lastone.repositories.Repos;
using lastone.repositories.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace lastone
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<ITeacherRepository, TeacherRepository>();
            container.RegisterType<IGlobalRepository, GlobalRepository>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<TeacherRepository, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}