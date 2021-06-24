using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Addition")] //checking addition for positive numbers      
        public void AddingPositiveNumbersGivePositiveResult()
        {
            double firstNumber = 25;
            double secondNumber = 35;
            double result = CalculatorLibrary.Calculator.add(firstNumber, secondNumber);
            Assert.AreEqual(60d, result);
        }

        

        [TestMethod]
        [TestCategory("Addition")] //negative number addition
        
        public void AddNegativeNumbers()
        {
            double firstNumber = -5;
            double secondNumber = -10;
            double result = CalculatorLibrary.Calculator.add(firstNumber, secondNumber);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        [TestCategory("Addition")] // different order of numbers return same value
       
        public void TestGetsSameResultEvenAfterOrderChanged()
        {
            double firstNumber = 1;
            double secondNumber = 2;
            double result = CalculatorLibrary.Calculator.add(firstNumber, secondNumber);
            double resultReverseOrder = CalculatorLibrary.Calculator.add(secondNumber, firstNumber);
            Assert.IsTrue(result == resultReverseOrder);
        }

        



        [TestMethod]
        [TestCategory("Divide")]//divide by zero exception
       
        public void DivideByZeroExceptionThrown()
        {
            double firstNumber = 150;
            double secondNumber = 0;

            Assert.ThrowsException<DivideByZeroException>(() => CalculatorLibrary.Calculator.div(firstNumber,secondNumber));

        }



        [TestMethod]
        [TestCategory("Division")] //result is order dependent
        
        public void ResultOrderDependent()
        {
            double firstNumber = 10;
            double secondNumber = 5;

            double result = CalculatorLibrary.Calculator.div(firstNumber, secondNumber);
            double resultRev = CalculatorLibrary.Calculator.div(secondNumber, firstNumber);
            Assert.IsTrue(result != resultRev);
        }

        [TestMethod]
        [TestCategory("Multiplication")] // both number zero returns zero
        
        public void ResultZeroWhenBothInputZero()
        {
            double firstNumber = 0;
            double secondNumber = 0;

            double result = CalculatorLibrary.Calculator.div(secondNumber, firstNumber);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("Multiplication")] // one number zero returns zero

        public void ResultZeroWhenOneInputZero()
        {
            double firstNumber = 10;
            double secondNumber = 0;

            double result = CalculatorLibrary.Calculator.div(secondNumber, firstNumber);

            Assert.AreEqual(0, result);
        }



        [TestMethod]
        [TestCategory("Addition")] //addition returns double
        
        public void AdditionOfDoubles()
        {
            double firstNumber = 10.5;
            double secondNumber = 12.5;
            object result = CalculatorLibrary.Calculator.add(firstNumber, secondNumber);
            Assert.IsInstanceOfType(result, typeof(double));
        }



        [TestMethod]
        [TestCategory("Subtraction")] // both same inputs returns zero
       
        public void SameValuesSubtractedReturnsZero()
        {
            double firstNumber = 10;
            double secondNumber = 10;
            double result = CalculatorLibrary.Calculator.add(firstNumber, secondNumber);

            Assert.AreEqual(0, result);
        }


       
    }
}

