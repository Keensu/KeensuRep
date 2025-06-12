using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorMaster
    {
        private IOperation _oper;
        
        public void SetWork(IOperation operation)
        {
            _oper = operation;
        }
        public void DoOper(double i, double j)
        {
            _oper.DoOperation(i, j);
        }
    }
}