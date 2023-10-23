using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCyclesWithIncrements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            string s = Console.ReadLine();
            bool variable = int.TryParse(s,out int result);
            try 
            {
                if (result==1)
                {
                    FirstAppTask();
                }
                if (result == 2)
                {
                    SecondAppTask();                     
                }
                if(result == 3) 
                {
                    ThreeAppTask();
                }
            }
            catch (Exception ex) 
            {
                throw ex;
                    
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Составить программу возведения натурального числа в квадрат, используя следующую закономерность: 
        /// 1 в квадрате = 1
        /// 2 в квадрате = 1 + 3
        /// 3 в квадрате = 1 + 3 + 5
        /// 4 в квадрате = 1 + 3 + 5 + 7
        /// .... n в квадрате = 1 + 3 + 5 + 7 + 9 + ... + 2n-1
        /// </summary>
        static void FirstAppTask()
        {
            int increment = 1;

            for (int i = 1; i <= 10; i +=2)
            {
                if (i!=1)
                {
                    increment += i;
                }
                
            }
            Console.WriteLine(increment);
        }

        /// <summary>
        /// Определить количество трехзначных натуральных чисел, сумма цифр которых равна заданному числу N.
        /// </summary>
        static void SecondAppTask() 
        {
            Console.Write("Введите число: ");
            int number=Convert.ToInt32(Console.ReadLine());

            int increment = 0;
            for (int i = 100; i < 1000; i++)
            {
                int iOne, iSecond, iThree;

                iOne = i / 100;
                iSecond = i / 10;
                iSecond %= 10;
                iThree = i % 10;

                int sum=iOne+iSecond+iThree;

                if (sum==number)
                {
                    increment++;
                }
            }
            Console.WriteLine(increment);



        }

        /// <summary>
        /// Составить программу вычисления суммы кубов чисел от 25 до 125. 
        /// </summary>
        static void ThreeAppTask()
        {
            double result = 0;

            for (double i = 25; i <= 125; i++)
            {
                result += Math.Pow(i, 3);
            }
            Console.WriteLine(result);
        }
    }
}
 