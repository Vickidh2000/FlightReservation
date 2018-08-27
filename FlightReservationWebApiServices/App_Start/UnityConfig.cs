using FlightReservartion.DAL;
using FlightReservation.Business;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace FlightReservationWebApiServices
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IFlightRepository, FlightRepository>();
            //container.RegisterType<IFlightServices, FlightServices>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}