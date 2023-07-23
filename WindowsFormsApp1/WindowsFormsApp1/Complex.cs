using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Complex
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }   

        public Complex add(Complex num1,Complex num2)
        {
            Complex sum=new Complex();

            sum.RealPart=num1.RealPart+num2.RealPart;
            sum.ImaginaryPart=num1.ImaginaryPart+num2.ImaginaryPart;

            return sum;
        }
        public Complex sub(Complex num1, Complex num2)
        {
            Complex diff = new Complex();
            diff.RealPart = num1.RealPart - num2.RealPart;
            diff.ImaginaryPart = num1.ImaginaryPart - num2.ImaginaryPart;
            return diff;
        }
    }
}
