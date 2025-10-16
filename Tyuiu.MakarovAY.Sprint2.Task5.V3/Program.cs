using Tyuiu.MakarovAY.Sprint2.Task5.V3.Lib;
namespace Tyuiu.MakarovAY.Sprint2.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Условие: Составить программу, которая в зависимости от порядкового      *");
            Console.WriteLine("* номера дня недели (1, 2, …, 7) выводит на экран его название            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня недели: ");
            int numday = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numday < 1) || (numday > 7))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Этот день недели " + ds.FindDayName(numday);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
