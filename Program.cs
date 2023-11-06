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
            if (variable == true)
            {
                if (result == 1)
                {
                    FirstAppTask();
                }
                if (result == 2)
                {
                    SecondAppTask();
                }
                if (result == 3)
                {
                    ThreeAppTask();
                }
                if (result == 4)
                {
                    FourAppTask();
                }
                if (result == 5)
                {
                    FiveAppTask();
                }
                if (result == 6)
                {
                    SixAppTask();
                }
                if (result == 7)
                {
                    SevenAppTask();
                }
                if (result == 8)
                {
                    EightAppTask();
                }
                if (result == 9)
                {
                    NineAppTask();
                }
                if(result == 10)
                {
                    TenAppTask();
                }
                if (result == 11)
                {
                    ElevenAppTask();
                }
            }
                else
            {
                Console.WriteLine("Номер задачи не введен!"); 
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

        /// <summary>
        /// Среди двузначных чисел найти те, сумма квадратов цифр которых делится на 13. 
        /// </summary>
        static void FourAppTask()
        {
            double result = 0;

            for (double i = 13; i <= 99; i++)
            {
                result += Math.Pow(i, 2);

                if (result%13==0)
                {
                    Console.WriteLine(result);
                }                
            }
            
        }

        /// Написать программу поиска двузначных чисел, таких, что если к сумме цифр этого числа прибавить
        /// квадрат этой суммы, то получится это число.
        static void FiveAppTask()
        {
            for (int i = 10; i <= 99; i++)
            {
                int iOne = i / 10;
                int iTwo = i % 10;
                int iSum=iOne+iTwo;
                double iPow = Math.Pow(iSum, 2);

                if (i==iPow+iSum)
                {
                    Console.WriteLine(i);
                }
            }

        }

        /// <summary>
        /// Квадрат трехзначного числа оканчивается тремя цифрами, которые как раз и составляют это число
        /// </summary>
        static void SixAppTask()
        {
            for (int i = 100; i <= 999; i++)
            {
                double number = Math.Pow(i, 2);

                int result = Convert.ToInt32(number / 100);

                int resultOne, resultTwo, resultThree;

                resultOne = Convert.ToInt32(result / 100);

                resultTwo = result / 10;
                resultTwo%=10;

                resultThree = Convert.ToInt32(result% 10);

                int score = resultOne * 100 + resultTwo * 10 + resultThree;

                if (score==i)
                {
                    Console.WriteLine(score);
                }
            }
        }

        /// <summary>
        /// Составьте поле для игры в морской бой.
        /// </summary>
        static void SevenAppTask()
        {
            { 
                OneArea();
                TwoArea();
                ThirdArea();
                FourArea();                                                    
            }
        }
        /// <summary>
        /// Прорисовка одноклеточных кораблей
        /// </summary>
        private static void OneArea()
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j == 7 && i == 4)
                    {
                        Console.Write(" 1");
                    }
                    else if (j == 0 && i == 9)
                    {
                        Console.Write(" 1");
                    }
                    else if (j == 4 && i == 6)
                    {
                        Console.Write(" 1");
                    }
                    else if (j == 9 && i == 5)
                    {
                        Console.Write(" 1");
                    }
                    else
                    {
                        Console.Write(" X");
                    }
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Прорисовка двухклеточных кораблей
        /// </summary>
        private static void TwoArea()
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j == 7 && i == 7)
                    {
                        Console.Write(" 2");
                        Console.Write(" 2");
                        j++;
                    }
                    else if (j == 1 && i == 5)
                    {
                        Console.Write(" 2");
                        Console.Write(" 2");
                        j++;
                    }
                    else if (j == 8 && i == 2)
                    {
                        Console.Write(" 2");
                        Console.Write(" 2");
                        j++;
                    }
                    else
                    {
                        Console.Write(" X");
                    }
                }
                Console.WriteLine();
            }            
        }
        /// <summary>
        /// Прорисовка трехклеточных кораблей
        /// </summary>
        private static void ThirdArea()
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j == 6 && i == 9)
                    {
                        Console.Write(" 3");
                        Console.Write(" 3");
                        Console.Write(" 3");
                        j += 2;
                    }
                    else if (j == 0 && i == 0)
                    {
                        Console.Write(" 3");
                        Console.Write(" 3");
                        Console.Write(" 3");
                        j += 2;
                    }
                    else
                    {
                        Console.Write(" X");
                    }
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Прорисовка четырехклеточных кораблей
        /// </summary>
        private static void FourArea()
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j == 2 && i == 3)
                    {
                        Console.Write(" 4");
                        Console.Write(" 4");
                        Console.Write(" 4");
                        Console.Write(" 4");
                        j += 3;
                    }
                    else
                    {
                        Console.Write(" X");
                    }

                }
                Console.WriteLine();
            }
        }    
        /// <summary>
        /// Написать программу поиска четырехзначного числа, которое при делении на 133 дает в остатке 125, 
        /// а при делении на 134 дает в остатке 111. Ответ: 1987. 
        /// </summary>
        static void EightAppTask()
        {
            for (int i = 1000; i < 10000; i++)
            {
                if (i % 133 == 125 && i % 134 == 111)
                {
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Найти сумму положительных нечетных чисел, меньших 100. 
        /// </summary>
        static void NineAppTask()
        {
            int k = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    k += i;
                }
            }
            Console.WriteLine("Cумма положительных нечетных чисел равна: {0}", k);            
        
        }
        /// <summary>
        ///  Найти сумму целых положительных чисел из промежутка от A до B, кратных 4 (значения переменных A и B вводятся с клавиатуры). 
        /// </summary>
        static void TenAppTask()
        {
            int count = 0;
            Console.Write("Введите первое число промежутка: ");
            int firstNumber=int.Parse(Console.ReadLine());
            
            Console.Write("Введите последнее число промежутка: ");
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber ;  i <= lastNumber; i++)
            {
                if (i % 4 == 0)
                {
                    count += i;
                }
            }
            Console.WriteLine(count);
        }
        /// <summary>
        /// Найти сумму целых положительных чисел, больших 20, меньших 100, кратных 3 и заканчивающихся на 2, 4 или 8. 
        /// </summary>
        static void ElevenAppTask()
        {
            int count = 0;
            for (int i = 21; i <= 99; i++)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    count += i;
                }
            }
            Console.WriteLine(count);

        }
    }
}
