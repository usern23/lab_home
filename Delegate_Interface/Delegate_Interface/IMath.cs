using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Interface
{
    
    internal interface IMath
    {
        
        double Summ (double x, double y);
        double Subtraction(double x, double y);
        double Multiplication(double x, double y);
        double Divide(double x, double y);
    }
}
