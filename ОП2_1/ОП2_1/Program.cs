using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОП2_1
{
    class textfile
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Виберiть директорiю");
            Directory c = new Directory();
            c.show();
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    File q = new File();
                    File qq = new File();
                    q.Add1("Лаба по ОП");
                    q.Add1("Лаба по ТА");
                    q.Add1("Курсач");
                    Console.WriteLine("Доступнi текстовi файли");
                    q.show();
                    Console.WriteLine();

                    Console.WriteLine("Виберiть: ");
                    Console.WriteLine("1)Вiдкрити перший файл");
                    Console.WriteLine("2)Вiдкрити другий файл");
                    Console.WriteLine("3)Вiдкрити третiй файл");
                    Console.WriteLine("4)Додати новий файл");
                    Console.WriteLine("5)Перейменувати файл");

                    int b = Convert.ToInt32(Console.ReadLine());
                    if (b == 1)
                    {
                        string v = ("Зроблено 1.5 лаби..");
                        q.content(v);
                        Console.WriteLine();
                        Console.WriteLine("Додати текст(так/ні):");


                        string choise = Convert.ToString(Console.ReadLine());
                        if (choise == "так")
                        {
                            Console.WriteLine("Напишiть текст ");
                            string h = Convert.ToString(Console.ReadLine());
                            q.addtext(v, h);
                            Console.ReadLine();
                        }
                        else if (choise == "ні") { Console.WriteLine("Кiнець роботи програми"); }


                    }
                    else if (b == 2)
                    {
                        string v = ("Зроблено 2 лаби");
                        q.content(v);
                        Console.WriteLine("Додати текст(так/ні):");


                        string choise = Convert.ToString(Console.ReadLine());
                        if (choise == "так")
                        {
                            Console.WriteLine("Напишiть текст ");
                            string h = Convert.ToString(Console.ReadLine());
                            q.addtext(v, h);
                            Console.ReadLine();
                        }
                        else if (choise == "ні") { Console.WriteLine("Кiнець роботи програми"); }



                    }
                    else if (b == 3)
                    {
                        string v = ("Буде зроблений колись");
                        q.content(v);
                        Console.WriteLine("Додати текст(так/ні):");


                        string choise = Convert.ToString(Console.ReadLine());
                        if (choise == "так")
                        {
                            Console.WriteLine("Напишiть текст ");
                            string h = Convert.ToString(Console.ReadLine());
                            q.addtext(v, h);
                            Console.ReadLine();
                        }
                        else if (choise == "ні") { Console.WriteLine("Кiнець роботи програми"); }



                    }

                    else if (b == 4)
                    {
                        Console.WriteLine("Iм'я файлу,який хочете додати");
                        string g = Convert.ToString(Console.ReadLine());
                        q.Add1(g);
                        q.show();
                        Console.WriteLine("Хочете видалити файл?(так/ні)");
                        string choice2 = Convert.ToString(Console.ReadLine());
                        if (choice2 == "так")
                        {
                            Console.WriteLine("Доступнi текстовi файли:");
                            q.show();

                            string h = Convert.ToString(Console.ReadLine());

                            q.remove(h);
                            Console.WriteLine("Доступнi текстовi файли пiсля видалення");
                            q.show();
                            Console.ReadLine();
                        }
                        else if (choice2 == "ні")
                        {
                            Console.WriteLine("Кiнець роботи програми");
                            Console.ReadLine();
                        }
                    }

                    else if (b == 5)
                    {
                        Console.WriteLine();
                        q.show();
                        Console.WriteLine("Виберiть файл який хочете перейменувати");
                        string u = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Напишiть нову назву файлу");
                        string x = Convert.ToString(Console.ReadLine());
                        q.rename(u, x);
                        q.show();
                        Console.ReadLine();

                    }

                    break;
                case 2:
                    File w = new File();
                    w.Add1("Фронт");
                    w.Add1("Бек");
                    Console.WriteLine("Доступнi текстовi файли");
                    w.show();
                    Console.WriteLine();

                    Console.WriteLine("Виберiть: ");
                    Console.WriteLine("1)Вiдкрити перший файл");
                    Console.WriteLine("2)Вiдкрити другий файл");
                    Console.WriteLine("3)Додати новий файл");
                    Console.WriteLine("4)Перейменувати файл");

                    int j = Convert.ToInt32(Console.ReadLine());
                    if (j == 1)
                    {
                        string v = ("Coming soon");
                        w.content(v);
                        Console.WriteLine();
                        Console.WriteLine("Додати текст(так/ні):");


                        string choise = Convert.ToString(Console.ReadLine());
                        if (choise == "так")
                        {
                            Console.WriteLine("Напишiть текст ");
                            string h = Convert.ToString(Console.ReadLine());
                            w.addtext(v, h);
                            Console.ReadLine();
                        }
                        else if (choise == "ні") { Console.WriteLine("Кiнець роботи програми"); }


                    }
                    else if (j == 2)
                    {
                        string v = ("Coming soon too");
                        w.content(v);
                        Console.WriteLine("Додати текст(так/ні):");


                        string choise = Convert.ToString(Console.ReadLine());
                        if (choise == "так")
                        {
                            Console.WriteLine("Напишiть текст ");
                            string h = Convert.ToString(Console.ReadLine());
                            w.addtext(v, h);
                            Console.ReadLine();
                        }
                        else if (choise == "ні") { Console.WriteLine("Кiнець роботи програми"); }

                    }
                    else if (j == 3)
                    {
                        Console.WriteLine("Iм'я файлу,який хочете додати");
                        string g = Convert.ToString(Console.ReadLine());
                        w.Add1(g);
                        w.show();
                        Console.WriteLine("Хочете видалити файл?(так/ні)");
                        string choice2 = Convert.ToString(Console.ReadLine());
                        if (choice2 == "так")
                        {
                            Console.WriteLine("Доступнi текстовi файли");
                            w.show();

                            string h = Convert.ToString(Console.ReadLine());

                            w.remove(h);
                            Console.WriteLine("Доступнi текстовi файли пiсля видалення");
                            w.show();
                            Console.ReadLine();
                        }
                        else if (choice2 == "ні")
                        {
                            Console.WriteLine("Кiнець роботи програми");
                            Console.ReadLine();
                        }
                    }
                    else if (j == 4)
                    {
                        Console.WriteLine();
                        w.show();
                        Console.WriteLine("Виберiть файл який хочете перейменувати");
                        string u = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Напишiть нову назву файлу");
                        string x = Convert.ToString(Console.ReadLine());
                        w.rename(u, x);
                        w.show();
                        Console.ReadLine();
                    }


                    break;



            }
        }
    }
}
