using System;
using System.Linq;

namespace GenericsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileUse fileUse = new FileUse();

            string filePath = "C:\\TestFolder\\new_file.txt";

            fileUse.CreateRandom(10, filePath);

            string[] arrayOfNumbersString = fileUse.ReturnArray(filePath).Split(',');

            int[] arrayOfNumbers = arrayOfNumbersString.Select(int.Parse).ToArray();

            GenericsList<int> genericsList = new GenericsList<int>();
            
            foreach (int number in arrayOfNumbers)
            {
                genericsList.Add(number);
            }

            Console.WriteLine("Згенерований масив об'єктів:");

            for (int i = 0; i < genericsList.Count; i++)
            {
                Console.Write(genericsList[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Перевірка масиву на наявність 5 до видалення: " + genericsList.Contains(5));

            genericsList.Remove(5);

            Console.WriteLine("Перевірка масиву на наявність 5 після видалення: " + genericsList.Contains(5));

            Console.WriteLine("Згенерований масив об'єктів після видалення числа:");

            for (int i = 0; i < genericsList.Count; i++)
            {
                Console.Write(genericsList[i] + " ");
            }

            genericsList.Clear();

            Console.ReadLine();
        }
    }
}
