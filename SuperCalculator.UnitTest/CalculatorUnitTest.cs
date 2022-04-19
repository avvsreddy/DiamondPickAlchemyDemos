using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperCalculator.UnitTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void Sum_ValidInput_ShouldReturnValidResult()
        {
            // AAA
            // A - Arrange
            int a = 10;
            int b = 20;
            Calculator target = new Calculator();
            int expected = 30;
            // A - Act
            int actual = target.Sum(a, b);
            // A - Assert
            Assert.AreEqual(expected, actual);
            // do not use conditional/looping/try..catch  -- simple code


        }
        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void Sum_WithZeroInput_ThrowsExp()
        {
            Calculator target = new Calculator();
            int expected = target.Sum(0, 0);
            //sdfsdfsd
        }

        [TestMethod]
        public void Subtract_ValidInput_ValidOutput()
        {
            Calculator target = new Calculator();
            Assert.AreEqual(0, target.Subtract(10, 10));
        }

        //}

    }
}
