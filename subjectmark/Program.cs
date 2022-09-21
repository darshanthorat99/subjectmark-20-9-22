using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subjectmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the mark of physics");
            double n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark of math");
            double n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark of chemisty");
            double n3 = Convert.ToInt32(Console.ReadLine());
            double per = ((n1 + n2 + n3) / 300) * 100;
            Console.WriteLine($"percentage is {per}%");
            if (per >= 80)
            {
                Console.WriteLine(" grade is A");
            }
            else if (per >= 70 && per < 80)
            {
                Console.WriteLine("grade is B");
            }
            else if (per >= 60 && per < 70)
            {
                Console.WriteLine("grade is c");
            }
            else if (per < 60)
            {
                Console.WriteLine("grade is d");
            }
        }
    }
}
