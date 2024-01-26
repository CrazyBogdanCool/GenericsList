using System;
using System.IO;

namespace GenericsListTests
{
    internal class FileUse
    {
        Random random = new Random();

        public void CreateRandom(int numberOfCharacters, string filePath)
        {
            File.WriteAllText(filePath, string.Empty);

            for (int i = 0; i < numberOfCharacters; i++)
            {
                string text = Convert.ToString(random.Next(1, 100));

                File.AppendAllText(filePath, text);

                if (i < numberOfCharacters - 1)
                {
                    File.AppendAllText(filePath, ",");
                }
            }
        }
        public string ReturnArray(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}