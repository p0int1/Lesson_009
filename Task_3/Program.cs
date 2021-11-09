using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает 
//среднее  арифметическое  возвращаемых  значений  методов, сообщенных  с  делегатами  в  массиве. 
//Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 

namespace Task_3
{
    class Program
    {
        public delegate int Element();
        public delegate double AverageElement(Element[] el);
        static void Main(string[] args)
        {
            Console.Write("Сколько будет элементов в массиве?: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //создаем массив делегатов
            Element [] arr = new Element[x];

            //создание объекта для генерации чисел
            Random number = new Random();
            //сообщаем с делегатом метод генерации числа
            Element rand = () => number.Next(0, 100);

            //в цикле заполняем массив
            //в элементах массива содержатся сообщенные методы
            //которые возвращают случайные числа
            for (int i = 0; i < arr.Length; i++)
                arr[i] = () => rand.Invoke();

            AverageElement average = delegate (Element[] array)
                                        {
                                            double sum = 0;
                                            for (int i = 0; i < arr.Length; i++)
                                            {
                                                int tmp = array[i].Invoke(); //возвращает случайное число
                                                Console.WriteLine($"{i}: " + tmp); //вывод элементов в консоль
                                                sum += tmp; //сумма всех элементов
                                            }
                                                
                                            return sum / array.Length; //среднее
                                        };

            //запуск всей цепочки действий
            double result = average.Invoke(arr);
            Console.WriteLine("Средне арефметическое элементов: {0:.#}", result);

            Console.ReadKey();
        }
    }
}