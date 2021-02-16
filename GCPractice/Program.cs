using System;
using System.Collections.Generic;
using System.Reflection;

namespace GCPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.С помощью рефлексии вызвать метод Substring класса String
            // и извлечь из строки подстроку заданного размера.
            string text = "Good day";


            // 2.Получить список конструкторов класса List<T>

            Type tp = typeof(List<>);

            ConstructorInfo[] constructors = tp.GetConstructors();
            
            int i = 0;
            foreach (ConstructorInfo constructor in constructors)
            {
                i++;
                Console.WriteLine($"Method[{i}] = {constructor.Name}");

            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
