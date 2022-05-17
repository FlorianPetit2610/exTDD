using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exTDD
{
    class Program
    {
        public static void Main()
        {
            calcule calcule = new calcule(3,8);
            calcule.Addition();
            calcule.Soustraction();
            calcule.Division();
            calcule.Multiplication();
         }

    }

}

