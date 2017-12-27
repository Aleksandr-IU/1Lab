using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Начальные переменные
            double A, B, C;
            //Ввод коэффициентов
            A = readDouble("A");
            B = readDouble("B");
            C = readDouble("C");
            //Вычисление дискриминанта
            double D = Math.Pow(B, 2) - 4 * A * C;
            //Вывод корней
            if (D < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля, уравнение не имеет корней");
            }
            else if (D == 0)
            {
                Console.WriteLine("Дискриминант уравнения = 0");
                Console.WriteLine("Оба корня уравнения равны X = " + (-B / (2 * A)));
            }
            else
            {
                Console.WriteLine("Дискриминант уравнения = " + D);
                Console.WriteLine("Первый корень уравнения равен X1 = " + ((Math.Sqrt(D)) + B) / (2 * A));
                Console.WriteLine("Второй корень уравнения равен X2 = " + ((Math.Sqrt(D)) - B) / (2 * A));
            }
            //Конец работы, ожидание консоли.
            Console.ReadKey();
        }
        public static double readDouble(string name)
        {
            int number;
            string str;
            do
            {
                Console.WriteLine("Введите " + name);
                str = Console.ReadLine();
                if (str == "0" && name == "A") { str = "."; }

            } while (!Int32.TryParse(str, out number));
            return number;
        }

    }
}
