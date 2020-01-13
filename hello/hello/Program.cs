using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sum = one + two + tri; //сумма (на всякий случай)   
namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int v;
                Console.Write("Введите №: ");
                v = Convert.ToInt32(Console.ReadLine());
                if (v == 1)
                {
                    string name;
                    Console.Write("Введите ваше имя: ");
                    name = Console.ReadLine();

                    Console.WriteLine("Привет, " + name + "!");

                    Console.ReadKey();
                }
                if (v == 2)
                {
                    int one;
                    int two;

                    int tri;
                    string a = " условных едениц";
                    int b;
                    Console.Write("Введите 1 стакан: ");
                    one = Convert.ToInt32(Console.ReadLine());
                    // Convert.ToDouble
                    Console.Write("Введите 2 стакан: ");
                    two = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите в меру измерения (р. падеж): "); //Вывод запроса для пользователя
                    a = Console.ReadLine();
                    tri = one; // 3 = 1
                    one = two; // 1 = 2
                    b = tri; // запасной(скрытый) для отчистки третьего равен третьему
                    two = tri; // 2 = 3
                    tri -= b; // из 3 вычитаем запасной(скрытый)

                    Console.Write("Первый стакан " + one + " " + a + "! Второй стакан " + two + " " + a + "! Третий стакан " + tri + " " + a + "!");
                }
                if (v == 3)
                {
                    int one;
                    int two;
                    Console.Write("Введите 1: ");
                    one = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2: ");
                    two = Convert.ToInt32(Console.ReadLine());
                    one += two;
                    two = one - two;
                    one -= two;
                    Console.WriteLine("1 = " + one);
                    Console.WriteLine("2 = " + two);

                    Console.ReadKey();
                }
                if (v == 4)
                {
                    int a;
                    int b;
                    int c;
                    int otvet;
                    Console.Write("Введите a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите c: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    otvet = (a + 2 * b) / (a * c);
                    Console.WriteLine("Ответ: " + otvet);
                    Console.ReadKey();
                }
                if (v == 5)
                {
                    int chislo; //число
                    int b; // 
                    Console.Write("Введите число: "); //печать
                    chislo = Convert.ToInt32(Console.ReadLine());// ввод
                    b = chislo % 2; //остаток
                    if (b == 0)
                    {
                        Console.WriteLine("Чётное"); //печать
                    }
                    else
                    {
                        Console.WriteLine("He чётное"); //печать
                    }
                    Console.WriteLine("Конец! Нажмите Enter!");// печать
                    Console.ReadKey();
                }
                if (v == 6)
                {
                    int god;
                    int a;
                    int b;
                    int c;
                    Console.Write("Введите год: ");
                    god = Convert.ToInt32(Console.ReadLine()); // ввод
                    a = god % 4;
                    b = god % 100;
                    c = god % 400;
                    if (a == 0)
                    {
                        if (b == 0)
                        {
                            if (c == 0)
                            {
                                Console.WriteLine("Год " + god + " весокосный");
                            }
                            else
                            {
                                Console.WriteLine("Год " + god + " neвесокосный");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Год " + god + " весокосный");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Год " + god + " neвесокосный");
                    }
                    if (c == 0)
                    {
                        Console.WriteLine("Год " + god + " весокосный");
                    }
                    Console.WriteLine("Конец! Нажмите Enter!");// печать
                    Console.ReadKey();
                }
                if (v == 7)
                {
                    int god;
                    int a;
                    int b;
                    int c;
                    Console.Write("Введите год: ");
                    god = Convert.ToInt32(Console.ReadLine()); // ввод
                    a = god % 4;
                    b = god % 100;
                    c = god % 400;

                    // если (делится на 4 И НЕ делится 100) ИЛИ делится на 400
                    if (a == 0 || c == 0)
                    {
                        Console.WriteLine("Год " + god + " весокосный");
                    }
                    else
                    {
                        Console.WriteLine("Год " + god + " neвесокосный");
                    }

                    Console.WriteLine("Конец! Нажмите Enter!");// печать
                    Console.ReadKey();

                }
                if (v == 8)
                {
                    int a;
                    int b;
                    int c;
                    Console.Write("Введите a: ");
                    a = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите b: ");
                    b = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите c: ");
                    c = Convert.ToInt32(Console.ReadLine()); // ввод
                    if (c < a)
                    {
                        Console.WriteLine("C  меньше a и b");
                    }
                    else if (c > b)
                    {
                        Console.WriteLine("C больше б ");
                    }
                    else if (c < b && c > a)
                    {
                        Console.WriteLine("C  между а и б");
                    }
                    else
                    {
                        Console.WriteLine("C - одна из переменных");
                    }
                    Console.WriteLine("Конец! Нажмите Enter!");// печать
                    Console.ReadKey();

                }
                if (v == 9)
                {
                    int x1;
                    int y1;
                    int x2;
                    int y2;
                    int a;
                    int b;
                    int help1;
                    int help2;
                    int help3;
                    string p;
                    Console.Write("Введите x1: ");
                    x1 = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите y1: ");
                    y1 = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите a(длинна x): ");
                    a = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите b(длинна y): ");
                    b = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите x2: ");
                    x2 = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите y2: ");
                    y2 = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите 0: ");
                    p = Console.ReadLine(); // ввод
                    help1 = x1 + a;
                    help2 = y1 + b;
                    help3 = y1 - b;

                    if (help1 > x2 && x1 < x2)
                    {
                        Console.WriteLine("x пройден");
                        if (help2 > y2 || help3 < y2)
                        {
                            Console.WriteLine("Точка в фигуре");
                        }
                        else
                        {
                            Console.WriteLine("Точка не в фигуре");
                        }
                    }

                    else if (help1 == x2 || x1 == x2)
                    {
                        Console.WriteLine("x пройден");
                        if (help2 == y2 || y1 == y2)
                        {
                            Console.WriteLine("Точка на краю фигуры");
                        }
                        else
                        {
                            Console.WriteLine("Точка не в фигуре");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Точка не в фигуре");
                    }
                    Console.ReadKey();


                    if (x2 < x1 || x2 > help1 || y2 > y1 || y2 < help3)
                    {
                        Console.WriteLine("Точка не в фигуре");
                    }
                    else if (x2 > x1 && x2 < help1 && y2 < y1 && y1 > help3)
                    {
                        Console.WriteLine("Точка не в фигуре");
                    }
                    else
                    {
                        Console.WriteLine("Точка нa границе");
                    }
                    Console.ReadKey();
                }
                if (v == 10)
                {
                    double a;
                    double b;
                    double c;
                    double d;
                    double x1;
                    double x2;
                    double k;
                    Console.Write("Введите a: ");
                    a = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите b: ");
                    b = Convert.ToInt32(Console.ReadLine()); // ввод
                    Console.Write("Введите c: ");
                    c = Convert.ToInt32(Console.ReadLine()); // ввод

                    d = b * b - (4 * a * c);
                    if (a != 0)
                    {
                        if (d < 0)
                        {
                            Console.WriteLine("Нет корней");
                        }
                        if (d == 0)
                        {
                            k = Math.Sqrt(d);
                            x1 = -b / 2 * a;
                            Console.WriteLine(" x = " + x1);
                        }
                        if (d > 0)
                        {
                            k = Math.Sqrt(d);
                            x1 = -b + k / 2 * a;
                            Console.WriteLine("x1: " + x1);
                            x2 = -b - k / 2 * a;

                            Console.WriteLine("x2: " + x2);
                        }
                    }

                    if (a == 0)
                    {

                        if (b == 0)
                        {

                            if (c == 0)
                            {
                                Console.WriteLine("Любой корень");
                            }
                            else
                            {
                                Console.WriteLine("Нет корней");
                            }
                        }
                        else
                        {
                            x1 = -c / b;
                            Console.WriteLine("X: " + x1);
                        }


                    }
                }
                if (v == 11)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        int a;
                        Console.Write("Введите  № ");
                        a = Convert.ToInt32(Console.ReadLine()); // ввод
                        if (a == 1)
                        {
                            int n;
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 1; i <= n; i++)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        if (a == 2)
                        {
                            int n;
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 1; i <= n; i++)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine("");
                        }
                        if (a == 3)
                        {
                            int n;
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 1; i < n; i++)
                            {

                                Console.Write(i + ",");
                            }
                            Console.WriteLine(n);
                        }
                        if (a == 4)
                        {
                            int n;
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 1; i <= n; i++)
                            {
                                Console.WriteLine("*");
                            }
                            Console.WriteLine("");
                        }
                        if (a == 5)
                        {
                            int n;
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 1; i <= n; i++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        if (a == 6)
                        {
                            int n;
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= n; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine("");
                            }
                        }
                        if (a == 7)
                        {
                            int n;
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = n; i > 1; i--)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("1");
                            for (int i = 2; i <= n; i++)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        if (a == 8)
                        {
                            int n;

                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (a = n; a > 1; a--)
                            {
                                for (int i = 0; i < a; i++)
                                {

                                    Console.Write("*");
                                }
                                Console.WriteLine("");
                            }


                            for (int i = 2; i <= n + 1; i++)
                            {
                                for (int j = i + 1; j > 2; j--)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine("");

                            }

                            if (a == 9)
                            {
                                int f;
                                Console.Write("Введите  n ");
                                f = Convert.ToInt32(Console.ReadLine()); // ввод
                                for (a = f; a > 1; a -= 2)
                                {
                                    for (int i = 0; i < (f - a) / 2; i++)
                                    {

                                        Console.Write(" ");
                                    }
                                    for (int i = a + 1; i > 1; i--)
                                    {

                                        Console.Write("*");

                                    }

                                    Console.WriteLine("");

                                }
                                //Console.Write("тут пусто (Нужно верить в это!!! Обязательно!!!)");

                                for (a = 1; a <= n; a += 2)
                                {
                                    for (int i = 0; i < (n - a) / 2; i++)
                                    {

                                        Console.Write(" ");
                                    }
                                    for (int i = a + 1; i > 1; i--)
                                    {

                                        Console.Write("*");

                                    }
                                    Console.WriteLine("");
                                }


                                Console.ReadKey();


                            }

                        }
                    }
                }
                if (v == 12)
                {
                    for (int g = -1; g < 10; g++)
                    {
                        Console.Write("Введите  s ");
                        int s;
                        s = Convert.ToInt32(Console.ReadLine()); // ввод
                        if (s == 1)
                        {
                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                    if (i == j)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }


                        if (s == 2)
                        {
                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                    if (i == n - j - 1)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }
                        if (s == 3)
                        {
                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (i == j || i + 1 == n - j)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }

                                }
                                Console.WriteLine();
                                //for (int j = n; j > -1; j--)



                            }
                            Console.ReadKey();
                        }
                        if (s == 4)
                        {

                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                    if (i >= n - j - 1)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                Console.WriteLine();
                            }
                            Console.ReadKey();

                        }
                        if (s == 5)
                        {
                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {



                                    if (i <= j && i >= n - j -1)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }
                        if (s == 6)
                        {
                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {



                                    if ((i <= j && i >= n - j - 1 )||( i >= j && i <= n - j- 1))
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                        if (s == 7)
                        {
                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {

//i <= j && i >= n - j - 1 || i >= j && i <= n - j - 1

                                    if ((i >= j && i >= n - j - 1) || (i <= j && i <= n - j - 1))
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                    }
                }
                if (v == 13)
                {
                    Console.Write("Введите  z ");
                    int z;
                    z = Convert.ToInt32(Console.ReadLine()); // ввод
                    if (z == 0)
                    {
                        Console.Write("Введите  n ");
                        int n;
                        n = Convert.ToInt32(Console.ReadLine()); // ввод
                        do
                        {
                            Console.Write("Введите  n ");
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                        }
                        while (n % 2 == 0);

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {

                                //i <= j && i >= n - j - 1 || i >= j && i <= n - j - 1

                                if ((i >= j && i >= n - j - 1) || (i <= j && i <= n - j - 1))
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(".");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                
                    if (z == 1)
                        {
                            Console.Write("Введите  n ");
                            int n;
                            n = Convert.ToInt32(Console.ReadLine()); // ввод
                            while (n%2 == 0)
                            {
                                Console.WriteLine("Неверное n ");
                                Console.Write("Введите  n ");
                                n = Convert.ToInt32(Console.ReadLine()); // ввод
                            }
                            
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {

                                    //i <= j && i >= n - j - 1 || i >= j && i <= n - j - 1

                                    if ((i >= j && i >= n - j - 1) || (i <= j && i <= n - j - 1))
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                    }
            

       
            }

                 



              


        }

    }
}
