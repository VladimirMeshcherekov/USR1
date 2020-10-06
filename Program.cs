
using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите массу: ");
            double m = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите высота: ");
            double h = Convert.ToDouble(Console.ReadLine());


            double g = 0.0000000000667408; //да, так делать нельзя, но у меня лапки и я не могу по другому


            Console.WriteLine(Math.Sqrt((g * m) / (r + h)));

        }
    }
}