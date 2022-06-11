using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_30_TDD_Problem;
namespace TesingOnPracticeProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}
