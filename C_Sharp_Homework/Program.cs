using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число: ");
            int number = int.Parse(Console.ReadLine());

            //Шестизначное число разделленное пополам
            int number2 = number % 1000;
            int number3 = number / 1000;

            int Summ1 = 0;
            int Summ2 = 0;

            while (number2 > 0)
            {
                int number4 = number2 % 10;
                Console.Write(number4 + "+");
                number2 /= 10;

                Summ1 += number4;
            }
            Console.Write("\b \b = ");
            Console.WriteLine(Summ1);

            Console.WriteLine();
            while (number3 > 0)
            {
                int number6 = number3 % 10;
                Console.Write(number6 + "+");
                number3 /= 10;

                Summ2 += number6;
            }
            Console.Write("\b \b = ");
            Console.WriteLine(Summ2);
            Console.WriteLine();

            if (Summ1 == Summ2)
            {
                Console.WriteLine("Равны!");
            }



            Console.ReadLine();
        }
    }
}
