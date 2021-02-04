using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;


namespace labwork_1
{
    delegate double DelAverage(int x, int y, int z);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите:\nx = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());
            DelAverage delav;
            delav = delegate (int x, int y, int z) { return (double)((x + y + z) / 3d); };
            Console.WriteLine($"Среднее арифметическое введённых чисел: {Math.Round(delav(x, y, z), 3)}");

        }
    }
}
