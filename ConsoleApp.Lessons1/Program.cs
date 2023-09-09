
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Lessons._2
{
    internal class Program
    {
        static int Age = 56;
        /// <summary>
        /// 5.	Написать приложение, которое выведет на экран Ваше имя и фамилию.
        /// (Жду что у вас будет приложение, которое я сам запущу и где у меня попросят ввести ФИО, 
        /// после я нажму Enter и мне выдастся сообщение – «Приветствую тебя - ФИО»
        /// </summary>
        static void Exmpl01()
        {
            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Приветсвую тебя ");
        }

        /// <summary>
        /// 6.	Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму.
        /// (Так же как и в предыдущем примере, только с цифрами.Мы проходили как можно из строки перевести в число.)
        /// </summary>
        static void Exmpl02()
        {
            Console.Write("Введите число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("сумма чисел {0} и {1} равна {2}",
                a, b, c);

        }

        static void Exmpl03()
        {
            DateTime dt = new DateTime(2023, 09, 06);
            // ваозраст
            var cirrertome = DateTime.Now;
            double age = (cirrertome - dt).TotalDays;
            double age2 = cirrertome.Year - dt.Year;

            var test1 = cirrertome.DayOfWeek;

            cirrertome.AddDays(56);


            Console.WriteLine("{0}", DateTime.Now);

            TimeSpan ts = new TimeSpan(4, 30, 0);
            var tiks = ts.Ticks;
        }
        static void Exmpl04()
        {
            int[] arr = new int[7];
            foreach (int i in arr)
            {
            }
        }

        // вычисления значения функции y = 7x^2-3x+4  при любом значении x
        static void Exmpl05()
        {
            int y, x;
            Console.WriteLine("y = 7x^2-3x+4");
            Console.Write("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = 7 * x * x - 3 * x + 4;
            Console.WriteLine("y=" + y);
        }

        /// <summary>
        /// Дан радиус окружности.Найти длину окружности и площадь круга
        /// </summary>
        static void Exmpl06()
        {
            Console.WriteLine("Дайте радиус окружности.Чтобы найти длину окружности и площадь круга");
            Console.Write("Введите R: ");
            double r = Convert.ToInt32(Console.ReadLine());
            double S = 3.14 * r * r;
            double l = 2 * 3.14 * r;
            Console.WriteLine("l=" + l);
            Console.WriteLine("S=" + S);
        }
        /// <summary>
        /// 13.	Дано расстояние в сантиметрах. Найти число полных метров в нем. 1 cm = 0.01 m
        /// </summary>
        static void Exmpl07()
        {
            Console.WriteLine("Дайте расстояние в сантиметрах.Чтобы найти число полных метров в нем");
            Console.Write("Введите в сантиметрах: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double m = cm / 100;
            Console.WriteLine("m=" + m);
        }
        /// <summary>
        /// 14.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
        /// </summary>
        static void Exmpl08()
        {
            Console.WriteLine("Прошло 234 дня. Сколько полных недель прошло за этот период?");
            int wk = 234 / 7;
            Console.WriteLine("Прошло : " + wk + " недель");
        }
        /// <summary>
        /// 19.	Напишите функцию swap(int* a, int* b), которая изменяет значения параметров a и b так, что новое значение a рав- но старому значению b и наоборот.
        /// </summary>
        static void swap()
        {
            Console.WriteLine("функцию swap(int* a, int* b), которая изменяет значения параметров a и b");
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }

        static void Main(string[] args)
        {
            Exmpl02() ;

        }
    }
}
