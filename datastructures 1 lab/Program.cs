using System;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b = 0,answer;

            Console.WriteLine("Введите число натуральное число N : ");
            a = int.Parse(Console.ReadLine());
            if(a % 2 != 0)
            {
                a /= 2;
                b += a++;
            }
            else
            {
                a /= 2;
                b += a;
            }
           
            Console.WriteLine(" Выходные данные : " + a + " " + b);
            
        }
    }
}