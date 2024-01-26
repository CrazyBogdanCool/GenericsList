using System;
using System.Linq;

namespace GenericsListTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            if (genericsList.Contains(5))
            {
                genericsList.Remove(5);
            }
            else
            {
                genericsList.Add(5);
            }

            genericsList.Clear();
        }
    }
}
