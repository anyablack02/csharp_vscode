using System;

namespace csharp_vscode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какой-нибудь текст:");
            
            string userInput = Console.ReadLine();

            Console.WriteLine("Вы ввели: " + userInput);
        }
    }
}