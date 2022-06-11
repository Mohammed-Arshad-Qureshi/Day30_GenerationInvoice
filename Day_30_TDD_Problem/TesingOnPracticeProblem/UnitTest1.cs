using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_30_TDD_Problem;
namespace TesingOnPracticeProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnsTotalFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 5;
            int time = 6;
            double expected = 56;
            //Act
            double actual = invoiceGenerator.CalculateFare(distance, time);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// For multiple rides
        /// </summary>
        [TestMethod]
        public void GivenMultipleRidesShouldReturnsAggregateTotalFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(3, 25), new Ride(0.5, 10) };
            double expected = 70;
            //Act
            double actual = invoiceGenerator.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
