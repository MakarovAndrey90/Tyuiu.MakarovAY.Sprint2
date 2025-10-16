using Tyuiu.MakarovAY.Sprint2.Task6.V5.Lib;
namespace Tyuiu.MakarovAY.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Условие: Игральным картам условно присвоены следующие порядковые номера *");
            Console.WriteLine("* в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю»   *");
            Console.WriteLine(" «королю» — 13, «тузу» — 14. Порядковые номера остальных карт             *");
            Console.WriteLine(" соответствуют их названиям  По заданному номеру карты k (6 <=k <= 14)    *");
            Console.WriteLine(" определить достоинство соответствующей карты.                            *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер карты: ");
            int numcard = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numcard < 6) || (numcard > 14)) 
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это карта " + ds.FindCardValue(numcard);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}