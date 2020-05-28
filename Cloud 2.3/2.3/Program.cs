using System;
using System.Linq;
namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] films = { "Джокер", "Текст", "Богемская рапсодия" };
            string[] dishes = { "Джокер", "Лед", "Неудержимые" };

            
            var result = films.Except(dishes);
            var result1 = films.Intersect(dishes);
            var result2 = films.Union(dishes);

            Console.WriteLine("Пересечение множеств: ");
            foreach (string q in result1)
                Console.WriteLine(q);
            Console.WriteLine(" ");

            Console.WriteLine("Объеденение множеств");
            foreach (string i in result2)
                Console.WriteLine(i);

            Console.WriteLine(" ");
            Console.WriteLine("Разность множеств");
            foreach (string s in result)
                Console.WriteLine(s);
        }
    }
}
