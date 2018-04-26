using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI第一次
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高");
            double A = double.Parse(Console.ReadLine());
            Console.Write("請輸入體重");
            double b = double.Parse(Console.ReadLine());

            double BMI = b / (A /100 * A /100);

            if (BMI >= 27)
            {
                Console.WriteLine("肥胖");
            }

            if (BMI >= 24 && BMI < 27)
            {
                Console.WriteLine("過重");
            }

            if (BMI >= 18.5 && BMI < 24)
            {
                Console.WriteLine("適中");
            }

            if (BMI < 18.5 && BMI > 16)
            {
                Console.WriteLine("過輕");
            }
            if (BMI > 27 || BMI < 16)
            {
                Console.WriteLine("免除兵役");
            }

                Console.WriteLine("BMI =" + BMI);
                Console.ReadLine();

        }
    }
}
