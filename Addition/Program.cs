using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и 
//возвращает среднее арифметическое этих аргументов. 

namespace Addition
{
    public delegate double MyDelegate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = 15;
            double average;
            MyDelegate myDelegate;

            myDelegate = delegate (int a, int b, int c) { return (a + b + c) / 3; };
            // можно использовать лямбда выражение, но это не соответствует условию
            // myDelegate = (a, b, c) => (a + b + c) / 3;

            average = myDelegate(a, b, c);

            Console.WriteLine($"Среднеарифметическое {a}, {b} и {c} будет равно {average}");

            Console.ReadKey();
        }
    }
}