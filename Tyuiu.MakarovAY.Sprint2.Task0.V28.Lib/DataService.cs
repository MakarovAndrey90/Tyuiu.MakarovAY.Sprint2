using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MakarovAY.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x * 735 != y * 111;
            res[2] = x * 7 < y;
            res[3] = x > y;
            res[4] = x * 7 <= y;
            res[5] = x >= y;

            return res; //2
        }
    }
}
