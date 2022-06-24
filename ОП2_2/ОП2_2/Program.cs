using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОП2_2

{
    class Program
    {
        static void Main(string[] args)
        {
            PassTrain t = new PassTrain();
            Carriage carriage = new Carriage();
            Random rnd = new Random();
                t.show();
                Console.WriteLine();
                Console.WriteLine("Показати к-ть пасажирiв ?(yes/no) ");
                string choice = Convert.ToString(Console.ReadLine());

                if (choice == "yes")
                {
                    Console.Clear();
                    int vrt = carriage.people();
                    Console.WriteLine(" Всього пасажирiв : " + "  " + vrt);
                    Console.WriteLine(" Вільних місць в поїзді " + " " + (250 - vrt));
                    Console.WriteLine(" Вього зайнятих місць для багажу " + (vrt - rnd.Next(0, 25)));
                    Console.WriteLine();
                    Console.WriteLine(" Сортувати вагони по зручності?(yes/no)");
                string choice2 = Convert.ToString(Console.ReadLine());

                    if (choice2 == "yes")
                    {
                        Console.WriteLine(" Відсортовано по зручності");
                        t.comfortable();
                        Console.WriteLine("Хочете вибрати вагон?(yes/no) ");
                        string choice3 = Convert.ToString(Console.ReadLine());
                        if (choice3 == "yes")
                        {
                            Console.Clear();
                            carriage.people();
                            Console.WriteLine("Вкажіть діапазон пасажирів ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a >= 50 || a < 0)
                            {
                                Console.WriteLine("Помилка!");

                            }
                            else if (a < 50 || a >= 0)
                            {
                                Console.WriteLine("to");
                                int b = Convert.ToInt32(Console.ReadLine());
                                if (b > 50 || b <= 0)
                                {
                                    Console.WriteLine("Помилка");
                                }
                                else if (b <= 50 || b > 0)
                                {
                                    carriage.choiseacarriage(a, b);
                                    Console.ReadLine();
                                }
                            }
                        }
                        else if (choice3 == "no")
                        {
                            Console.WriteLine("Кінець роботи програми");
                        }
                        Console.ReadLine();
                    }
                    else if (choice2 == "no")
                    {

                    Console.WriteLine("Вкажіть діапазон пасажирів ");
                    int a = Convert.ToInt32(Console.ReadLine());
                        if (a >= 50 || a < 0)
                        {
                            Console.WriteLine("Помилка!");

                        }
                        else if (a < 50 || a >= 0)
                        {
                            Console.WriteLine("to");
                            int b = Convert.ToInt32(Console.ReadLine());
                            if (b > 50 || b <= 0)
                            {
                                Console.WriteLine("Помилка");
                            }
                            else if (b <= 50 || b > 0)
                            {
                                carriage.choiseacarriage(a, b);
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (choice != "no" || choice != "yes")
                    {
                        Console.WriteLine("неправильно введені дані");
                    }
                }
                else if (choice == "no")
                {
                Console.WriteLine(" Сортувати вагони по зручності?(yes/no)");
                string choice2 = Convert.ToString(Console.ReadLine());

                    if (choice2 == "yes")
                    {
                    Console.WriteLine(" Відсортовано по зручності");
                    t.comfortable();
                    Console.WriteLine("Хочете вибрати вагон?(yes/no) ");
                    string choice3 = Convert.ToString(Console.ReadLine());
                        if (choice3 == "yes")
                        {
                            carriage.people();
                        Console.WriteLine("Вкажіть діапазон пасажирів ");
                        int a = Convert.ToInt32(Console.ReadLine());
                            if (a >= 50 || a < 0)
                            {
                                Console.WriteLine("Помилка!");

                            }
                            else if (a < 50 || a >= 0)
                            {
                                Console.WriteLine("to");
                                int b = Convert.ToInt32(Console.ReadLine());
                                if (b > 50 || b <= 0)
                                {
                                    Console.WriteLine("Помилка");
                                }
                                else if (b <= 50 || b > 0)
                                {
                                    carriage.choiseacarriage(a, b);
                                    Console.ReadLine();
                                }
                            }
                        }
                        else if (choice3 == "no")
                        {
                            Console.WriteLine("Кінець роботи програми");
                        }
                        Console.ReadLine();
                    }
                    else if (choice2 == "no")
                    {
                        carriage.people();
                    Console.WriteLine("Вкажіть діапазон пасажирів ");
                    int a = Convert.ToInt32(Console.ReadLine());
                        if (a >= 50 || a < 0)
                        {
                            Console.WriteLine("Помилка!");

                        }
                        else if (a < 50 || a >= 0)
                        {
                            Console.WriteLine("to");
                            int b = Convert.ToInt32(Console.ReadLine());
                            if (b > 50 || b <= 0)
                            {
                                Console.WriteLine("Помилка");
                            }
                            else if (b <= 50 || b > 0)
                            {
                                carriage.choiseacarriage(a, b);
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (choice != "no" || choice != "yes")
                    {
                    Console.WriteLine("неправильно введені дані");
                }

                Console.ReadLine();
                }


            
            else
            {
                Console.WriteLine("Не знайдено необхідного потрібного вагону");
                Console.ReadLine();
            }
        }
    }
}
