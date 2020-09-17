using System;

namespace DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обозначение переменных и приветствие
            double x1, x2, y1, y2;
            Console.WriteLine("Добро пожаловать! \nВас приветствует программа для вычесления площади и периметра прямоугольника.");
            //Введение координат с консоли(проверка на допустимость)
            Console.Write("Введите координыты (x1,y1) первой вершины прямоугольника.\nx1=");
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("y1=");
            y1 = Double.Parse(Console.ReadLine());
            Console.Write("Введите координаты (x2,y2) второй вершины прямоугольника. \nx2=");
            x2 = Double.Parse(Console.ReadLine());
            if (x2 == x1)
            {
                Console.WriteLine("Данное значение координаты не допустимо в условии задачи.\nДо свидания.");
                return;
            }
            Console.Write("y2=");
            y2 = Double.Parse(Console.ReadLine());
            if (y2 == y1)
            {
                Console.WriteLine("Данное значение координаты не допустимо в условии задачи.\nДо свидания.");
                return;
            }
            //Подсчёт площади, периметра и выведение результата на экран
            double S, P;
            P = 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
            Console.WriteLine($"Периметр данного прямоугольника равен P={P:0.000}");
            S = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            Console.WriteLine($"Площадь данного прямоугольника равна S={S:0.000}");
            Console.ReadKey();
        }
    }
}
