using System;

namespace Calculator_Logic
{
    public static class Calculator
    {
        //add operation, using 2 numbers and returning using the operator +
        public static double Add(double left, double right)
        {
            return left + right;
        }

        //subtraction operation, using 2 numbers and returning using the operator -
        public static double Sub(double left, double right)
        {
            return left - right;
        }

        //Multiplication operation, using 2 numbers and returning using the operator *
        public static double Mul(double left, double right)
        {
            return left * right;
        }

        //Division operation, using 2 numbers and returning using the operator "/"
        //with an exception if the right number is equal to 0
        public static double Div(double left, double right)
        {
            if(right != 0)
            {
                return left / right;
            }
            else 
            { 
                throw new DivideByZeroException(); 
            }
        }

     
    }
}
