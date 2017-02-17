using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using MyCert.Data;
using MyCert.Data.Models;
using MyCert.Repository;
using MyCert.Services;
using MyCert.Services.DTO;
using MyCert.Web.Controllers;

namespace MyCert.Web
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here  
            //This is the important line to edit  

            // Register Identity
            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            
            // Register or OWIN will not be injected
            container.RegisterType<AccountController>(new InjectionConstructor());

            // Register Repositories
            container.RegisterType<IRepository<Answer>, AnswerRepository>();
            container.RegisterType<IRepository<Question>, QuestionRepository>();

            // Register Services
            container.RegisterType<IService<QuestionDTO>, QuestionService>();

            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}