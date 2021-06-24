using System;

namespace CalculatorLibrary
{
    public class Calculator
    {
        static public double add(double firstNumber, double secondNumber) { // Addition method

            return firstNumber + secondNumber;
        }
        static public double sub(double firstNumber, double secondNumber)  //subtraction method
        {

            return firstNumber - secondNumber;
        }

        static public double div(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
            
        }

        static public double mul(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;

        }
    }
}
