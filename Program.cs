using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class PalindromeChecker
    {
        private string word;

        public PalindromeChecker(string inputWord)
        {
            word = inputWord;
        }

        public bool IsPalindrome()
        {
            // Перетворюємо слово на рядок у нижньому регістрі і видаляємо символи розділення.
            string cleanedWord = string.Join("", word.ToLower().Split());

            // Порівнюємо слово із його реверснутим варіантом.
            return cleanedWord == new string(cleanedWord.ToCharArray().Reverse().ToArray());
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть слово для перевірки на паліндром: ");
            string userInput = Console.ReadLine();

            // Обробка порожнього вводу
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Введено порожній рядок. Будь ласка, введіть слово.");
                return;
            }

            PalindromeChecker checker = new PalindromeChecker(userInput);

            if (checker.IsPalindrome())
            {
                Console.WriteLine($"Слово: {userInput} - це паліндром!");
            }
            else
            {
                Console.WriteLine($"Слово: {userInput} - це не паліндром.");
            }
            Console.ReadLine();
        }
    }
}