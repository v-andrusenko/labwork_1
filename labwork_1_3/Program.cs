using System;
using System.Diagnostics;

namespace labwork_1_3
{
    class Program
    {
        delegate double del();
        delegate double Average(del[] x);
        static void Main(string[] args)
        {
            del[] deleg = new del[10];
            Random rand = new Random();
            for (int i=0;i<deleg.Length;i++)
            {
                deleg[i] = () => { return rand.Next(0, 10); };
            }
            Average avgdel = delegate (del[] deleg)
            {
                double sum = 0;
                for (int i = 0; i < deleg.Length; i++)
                {
                    sum += deleg[i]();
                    Console.WriteLine($"{i} число = ");
                }
                return sum / deleg.Length;
            };
            Console.WriteLine($"Среднее арифметическое значений массива: {avgdel(deleg)}");
        }
    }
}
