using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Переменную age получается поменять, а time нет, потому что age уже задействена 
            int age = 18;
            int time = 20;
            Console.WriteLine(age);
            Console.WriteLine(time);
            int age2;
            int time2;
            age2 = Convert.ToInt32(time);
            Console.WriteLine(age2);
            time2 = Convert.ToInt32(age);
            Console.WriteLine(time2);
        }
    }
}
