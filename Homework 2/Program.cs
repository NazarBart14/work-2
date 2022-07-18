using System;
using System.Text;
using static System.Console;

namespace Homework_2
{
    internal class Program
    {

        static void Main()
        {
            OutputEncoding = Encoding.Unicode;
            Write("Write nomber - ");
            int num = Convert.ToInt32(ReadLine());
            Write("Write procent - ");
            int pro = Convert.ToInt32(ReadLine());
            int rez;
            rez = num / 100 * pro;
            Console.WriteLine(+pro + "widsotok wid chusla " + num + " = " + rez);
        }
    }
}
