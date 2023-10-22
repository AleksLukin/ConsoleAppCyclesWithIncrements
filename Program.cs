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
            Console.Write("Введите номер задачи");
            string s = Console.ReadLine();
            bool variable = int.TryParse(s,out int result);
            try 
            {
                if (result==1)
                {
                    FirstAppTask();
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
    }
}
 