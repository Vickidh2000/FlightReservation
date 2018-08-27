using System;
using FlightReservartion.DAL;
using FlightReservation.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilghtReservation.UnitTest
{
    [TestClass]
    public class BusinessUnitTest
    {
        [TestMethod]
        public void FlightRepo()
        {

            IFlightRepository repo = new FlightRepository();
            IFlightServices Business = new FlightServices(repo);

            //var res = Business.GetFlightById("2");
            //Assert.AreEqual("Kigali", res.Destination);
        }


        [TestMethod]
        public void DistanceCalculServicesTest1()
        {

            IFlightRepository repo = new FlightRepository();
            IFlightServices Business = new FlightServices(repo);
            double res = 0;
            res = DistanceCalculService.CalculDistance(repo.GetAirportById(1).Latitude, 
                 repo.GetAirportById(1).Longitude, repo.GetAirportById(2).Latitude, 
                 repo.GetAirportById(2).Longitude);

            res= res / 1000;

            res = Math.Round(res, 4);

            Assert.AreEqual(5900.0513, res);
        }

        [TestMethod]
        public void DistanceCalculServicesTest2()
        {

            IFlightRepository repo = new FlightRepository();
            IFlightServices Business = new FlightServices(repo);
            double res = 0;
            res = DistanceCalculService.CalculDistance(repo.GetAirportById(10).Latitude,
                 repo.GetAirportById(10).Longitude, repo.GetAirportById(11).Latitude,
                 repo.GetAirportById(11).Longitude);

            res = res / 1000;

            res = Math.Round(res, 4);

            Assert.AreEqual(9290,7951, res);
        }

        [TestMethod]
        public void GetCoordinateTest2()
        {

            IFlightRepository repo = new FlightRepository();
            IFlightServices Business = new FlightServices(repo);
            double res = 0;
            res = DistanceCalculService.CalculDistance(repo.GetAirportById(10).Latitude,
                 repo.GetAirportById(10).Longitude, repo.GetAirportById(11).Latitude,
                 repo.GetAirportById(11).Longitude);

            res = res / 1000;

            res = Math.Round(res, 4);

            Assert.AreEqual(9290, 7951, res);
        }


    }
}
