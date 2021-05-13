using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGenratorTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        /// <summary>
        /// TC 1 : Given the distance and time hould return total fare.
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_WhenInvoiceGenerator_ThenShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
    }
}