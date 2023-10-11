using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnv1test
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество строк");
                int k = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("Введите "+(i+1)+" строку с символами");
                    string qwe = Console.ReadLine();
                    for (int j = 0; j < qwe.Length; j++)
                    {
                        if (qwe[j] != '(' & qwe[j] != ')' & qwe[j] != '[' & qwe[j] != ']' & qwe[j] != '{' & qwe[j] != '}')
                        {
                            Console.WriteLine("Неверно введенные данные " +
                    "\n нажмите для продолжения");
                            goto next;
                        }
                    }
                    Gnv X = new Gnv();
                    //X.test(qwe);
                    Console.WriteLine(X.test(qwe));
                    next:;
                }
                Console.WriteLine("Нажмите Enter для закрытия консоли");
                Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неверно введенные данные " +
                    "\n Нажмите Enter для закрытия консоли");
                Console.ReadLine();
                Environment.Exit(0);
            }

            
        }
    }

    class Gnv
    {
        public bool test(string a)
        {
            int count1 = 0, count2 = 0, count3 = 0, count11 = 0, count22 = 0, count33 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '{')
                {
                    count1++;
                }
                if (a[i] == '[')
                {
                    count2++;
                }
                if (a[i] == '(')
                {
                    count3++;
                }
                if (a[i] == '}')
                {
                    count11++;
                }
                if (a[i] == ']')
                {
                    count22++;
                }
                if (a[i] == ')')
                {
                    count33++;
                }
            }
            if (count1 == count11 && count2 == count22 && count3 == count33)
            {
                Console.WriteLine("Входная строка: "+ a);
                return true;
            }
            else
            {
                Console.WriteLine("Входная строка: "+ a);
                return false;
            }
        }
    }
}
