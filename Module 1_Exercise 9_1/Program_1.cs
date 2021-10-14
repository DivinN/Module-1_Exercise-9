using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_9_1
{
    class Program_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор! Дикий... но симпотишный (:с Он очень любит усложнять логику...");
            int numFirst = 0;
            int numSecond = 0;
            int operationCode = 0;
            int test = 0;

            Console.WriteLine("Введите первое целое число");
            bool checkFirst = true;
            try
            {
                numFirst = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
                checkFirst = false;
            }

            if (checkFirst)
            {
                Console.WriteLine("Введите второе целое число");
                try
                {
                    numSecond = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Ошибка! ");
                    Console.WriteLine(ex.Message);
                    checkFirst = false;
                }

                if (checkFirst)
                {
                    Console.WriteLine("Введите код операции:");
                    Console.WriteLine("     1 - сложение");
                    Console.WriteLine("     2 - вычитание");
                    Console.WriteLine("     3 - произведение");
                    Console.WriteLine("     4 - частное");

                    try
                    {
                        Console.Write("Ваш выбор: ");
                        operationCode = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Ошибка! ");
                        Console.WriteLine(ex.Message);
                        checkFirst = false;
                    }
                    if (checkFirst)
                    {
                        if (operationCode == 1)
                        {
                            Console.Write("Результат: ");
                            Console.WriteLine(numFirst + numSecond);
                        }
                        else if (operationCode == 2)
                        {
                            Console.Write("Результат: ");
                            Console.WriteLine(numFirst - numSecond);
                        }
                        else if (operationCode == 3)
                        {
                            Console.Write("Результат: ");
                            Console.WriteLine(numFirst* numSecond);
                        }
                        else if (operationCode == 4)
                        {
                            try
                            {
                                // Вопрос! А почему он не захотел выбрасывать исключение, когда я делил на 0,
                                // когда переменные переводил в double?
                                test = numFirst / numSecond;
                                Console.WriteLine(Math.Round(Convert.ToDouble(numFirst) / Convert.ToDouble(numSecond), 2));
                            }
                            catch (Exception ex)
                            {
                                Console.Write("Ошибка! ");
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Нет операции с указанным номером!");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
