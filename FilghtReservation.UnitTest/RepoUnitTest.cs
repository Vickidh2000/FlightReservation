using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightReservartion.DAL;


namespace FilghtReservation.UnitTest
{
    [TestClass]
    public class RepoUnitTest
    {
       
        [TestMethod]
        public void GetCoordinate()
        {

            IFlightRepository repo = new FlightRepository();

            var res = repo.GetCoordinate("Zaventem");

            Assert.AreEqual(50.8854878, res[0]);
            Assert.AreEqual(4.4709968, res[1]);
        }



    }
}
