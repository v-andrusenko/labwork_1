using System;

namespace labwork_1_2
{
    class Program
    {
        delegate double Operation(double x, double y);
        static void Main(string[] args)
        {
            Console.Write("Введите:\nx = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите, что требуется сделать с числами (+, -, *, /): ");
            string op = Console.ReadLine();
            Operation operation;
            switch (op)
            {
                case "+": 
                    operation = (x, y) => x + y;
                    Console.WriteLine($"Результат операции: {operation(x, y)}"); 
                    break;
            
                case "-":
                    operation = (x, y) => x - y;
                    Console.WriteLine($"Результат операции: {operation(x, y)}");
                    break;

                case "*":
                    operation = (x, y) => x * y;
                    Console.WriteLine($"Результат операции: {operation(x, y)}");
                    break;

                case "/":
                    operation = (x, y) => y != 0 ? (x / y) : Double.PositiveInfinity;
                    Console.WriteLine($"Результат операции: {Math.Round(operation(x, y), 3)}");
                    break;

                default:
                    Console.WriteLine("Неизвестная операция"); 
                    break;
            }
        }
    }
}
