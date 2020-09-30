using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(28.1825, 32.8429);

            string from = "";
            string to = "";
            double value = 0;

            Console.WriteLine("Конвертувати з: ");
            from = Console.ReadLine();

            Console.WriteLine("Конвертувати в: ");
            to = Console.ReadLine();

            Console.WriteLine("Введiть суму: ");
            value = double.Parse(Console.ReadLine());

            Console.WriteLine(converter.Convert(from, to, value));
        }
    }
}
