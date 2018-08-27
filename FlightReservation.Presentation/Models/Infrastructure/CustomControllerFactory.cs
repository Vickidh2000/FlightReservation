using FlightReservation.Business;
using FlightReservartion.DAL;
using FlightReservation.Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace FlightReservation.Presentation.Models.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {           

         
            if (controllerName.ToLower().StartsWith("flight"))
            {
                var Flightrepository = new FlightRepository();
                var service = new FlightServices(Flightrepository);
                var controller = new FlightController(service);
                return controller;
            }


            var defaultFactory = new DefaultControllerFactory();
            return defaultFactory.CreateController(requestContext, controllerName);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            var disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}