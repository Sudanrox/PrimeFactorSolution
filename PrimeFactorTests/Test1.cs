using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactorLib;

namespace PrimeFactorTests
{
    [TestClass]
    public class MathUtilitiesTests
    {
        // Test for input 4: Expected prime factors = "2 x 2"
        [TestMethod]
        public void PrimeFactors_ShouldReturn2x2_WhenInputIs4()
        {
            string expected = "2 x 2";
            string actual = MathUtilities.PrimeFactors(4);
            Assert.AreEqual(expected, actual);
        }

        // Test for input 7: Expected prime factors = "7" (since 7 is already a prime number)
        [TestMethod]
        public void PrimeFactors_ShouldReturn7_WhenInputIs7()
        {
            string expected = "7";
            string actual = MathUtilities.PrimeFactors(7);
            Assert.AreEqual(expected, actual);
        }

        // Test for input 30: Expected prime factors = "2 x 3 x 5"
        [TestMethod]
        public void PrimeFactors_ShouldReturn2x3x5_WhenInputIs30()
        {
            string expected = "2 x 3 x 5";
            string actual = MathUtilities.PrimeFactors(30);
            Assert.AreEqual(expected, actual);
        }

        // Test for input 40: Expected prime factors = "2 x 2 x 2 x 5"
        [TestMethod]
        public void PrimeFactors_ShouldReturn2x2x2x5_WhenInputIs40()
        {
            string expected = "2 x 2 x 2 x 5";
            string actual = MathUtilities.PrimeFactors(40);
            Assert.AreEqual(expected, actual);
        }

        // Test for input 50: Expected prime factors = "2 x 5 x 5"
        [TestMethod]
        public void PrimeFactors_ShouldReturn2x5x5_WhenInputIs50()
        {
            string expected = "2 x 5 x 5";
            string actual = MathUtilities.PrimeFactors(50);
            Assert.AreEqual(expected, actual);
        }
    }
}
