using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – 
//вычитание,  Mul  –  умножение,  Div  –  деление).  Каждый лямбда  оператор  должен  принимать  два 
//аргумента  и  возвращать  результат  вычисления.  Лямбда  оператор  деления  должен  делать  проверку 
//деления на ноль.  
//Написать программу, которая будет выполнять арифметические действия, указанные пользователем. 

namespace Task_2
{
    public delegate double MyDelegate(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите операнд a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операнд b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию [+, -, *, /]: ");
            string op = Console.ReadLine();
            double result = 0;

            MyDelegate Add = (a, b) => a + b;
            MyDelegate Sub = (a, b) => a - b;
            MyDelegate Mul = (a, b) => a * b;
            MyDelegate Div = (a, b) => b == 0 ? (0) : (a / b);

            switch (op)
            {
                case "+":
                    result = Add(a, b);
                    break;

                case "-":
                    result = Sub(a, b);
                    break;

                case "*":
                    result = Mul(a, b);
                    break;

                case "/":
                    result = Div(a, b);
                    break;

                default:
                    Console.WriteLine("Не правильно введена операция");
                    break;
            }

            Console.WriteLine($"{a} {op} {b} = {result}");

            Console.WriteLine("\nНажмите любую клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
