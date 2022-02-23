using System;

namespace Task5
{
    internal class Calculator
    {
        public dynamic Add(dynamic operand1, dynamic operand2)
        {
            return operand1 + operand2;
        }
        public dynamic Sub(dynamic operand1, dynamic operand2)
        {
            return operand1 - operand2;
        }
        public dynamic Mul(dynamic operand1, dynamic operand2)
        {
            return operand1 * operand2;
        }
        public dynamic Div(dynamic operand1, dynamic operand2)
        {
            if(operand2 == 0)
            {
                throw new DivideByZeroException();                
            }
            return operand1 + operand2;
        }
    }
}
