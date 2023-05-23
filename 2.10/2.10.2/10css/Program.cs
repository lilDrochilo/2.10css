using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace _10css
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Введите значение стороны a:");
            double FitrstSide = double.Parse(Console.ReadLine());

            Console.Write("Введите значение стороны b:");
            double SecondSide = double.Parse(Console.ReadLine());

            Console.Write("Введите значение стороны c:");
            double ThirdSide = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(FitrstSide,SecondSide,ThirdSide);
            while (true)
            {
                Console.WriteLine(
                "1.Найти периметр\n" +
                "2.Найти площадь\n" +
                "3.Найти точку пересечения медиан\n" +
                "4.Выход\n");
                int choise = int.Parse(Console.ReadLine());
            
                switch (choise)
                {
                    
                    case 1:
                        Console.WriteLine(triangle.Perimeter());
                        break;
                    case 2:
                        Console.WriteLine(triangle.Square());
                        break;
                    case 3:
                        Console.WriteLine(triangle.GetMedianIntersection());
                        break;
                    case 4:
                        return;
                       
                        
                }
            }



        }

    }
}
