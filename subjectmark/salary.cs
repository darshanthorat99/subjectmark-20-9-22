using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subjectmark
{
    internal class salary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  the basic salary");
            double bs=Convert.ToDouble(Console.ReadLine());
            if(bs<10000)
            {
                double da = bs * 0.8;
                double hra = bs * 0.2;
                double gross = bs + da + hra;
                Console.WriteLine($"the gross salary is {gross}");
            }
            if (bs >10000 && bs<20000)
            {
                double da = bs * 0.9;
                double hra = bs * 0.35;
                double gross = bs + da + hra;
                Console.WriteLine($"the gross salary is {gross}");
            }
            else
            {
                double da = bs * 0.95;
                double hra = bs * 0.4;
                double gross = bs + da + hra;
                Console.WriteLine($"the gross salary is {gross}");
            }
        }
    }
}
 