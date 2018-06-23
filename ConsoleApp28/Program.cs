using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            double epsilon;     
            bool ok; 
            do
            {
                Console.Write("Введите точность: "); 
                string buf = Console.ReadLine(); 
                ok = Double.TryParse(buf, out epsilon); 
                if (!ok) Console.WriteLine("Неправильный ввод, попробуй ещё раз"); 
            } while (!ok); 

            double x1 = 2.1, x2 = 2.2, x3 = Metod(x1, x2);
            while (Math.Abs(x3 - x2) > epsilon)
            {
                x1 = x2;
                x2 = x3;
                x3 = Metod(x1, x2);
            }
            Console.WriteLine("Ответ: " + x3);
            Console.ReadLine();
        }
        static double Metod(double x1, double x2)
        {
            return x1 - (x2 - x1) * Func(x1) / (Func(x2) - Func(x1));
        }
        static double Func(double x)
        {
            return (x*x*x - 2*x*x + x - 3);
        }
    }
}

