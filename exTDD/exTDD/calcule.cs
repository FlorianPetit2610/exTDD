using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exTDD
{
    public class calcule
    {
        public double num1;
        public double num2;
        public calcule(double Num1, double Num2)
        {
            this.num1 = Num1;
            this.num2 = Num2;
        }
        public void Addition()
        {
            double result = this.num1 + this.num2;
            Console.WriteLine(result);
        }
        public void Soustraction()
        {
            double result = this.num1 - this.num2;
            Console.WriteLine(result);

        }
        public void Multiplication()
        {
            double result = this.num1 * this.num2;
            Console.WriteLine(result);

        }
        public void Division()
        {
            double result = this.num1 / this.num2;
            Console.WriteLine(result);

        }
    }
}
