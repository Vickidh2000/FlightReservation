using System.Web.Mvc;
using Microsoft.Practices.Unity;
using FlightReservation.Presentation.Models;
using Unity;
using Unity.Mvc4;
using FlightReservation.Business;
using FlightReservartion.DAL;

namespace FlightReservation.Presentation
{
  public static class Bootstrapper
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
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
            //container.RegisterTypes(
            //   AllClasses.FromLoadedAssemblies(),
            //   WithMappings.FromMatchingInterface, WithName.Default);

            container.RegisterType<IFlightServices, FlightServices>();
            container.RegisterType<IReservationServices, ReservationServices>();
            container.RegisterType<IFlightRepository, FlightRepository>();
            container.RegisterType<IReservationRepository, ReservationRepository>();
        }
  }
}