using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class TextManipulator
    {
        public static bool IsPalindrome(string text) 
        {
            // Удаление знаков препинания и пробелов, приведение к нижнему регистру
            string cleanText = new string(text.Where(char.IsLetter).ToArray()).ToLower();

            // Проверка на палиндром
            for (int i = 0; i < cleanText.Length / 2; i++)
            {
                if (cleanText[i] != cleanText[cleanText.Length - i - 1])
                    return false;
            }
            return true;
        }

        public static int CountSentences(string text)
        {
            // Подсчет количества предложений (предполагаем, что предложения разделены точкой)
            string[] sentences = text.Split('.');
            return sentences.Length - 1;
        }

        public static string ReverseString(string text)
        {
            // Переворот строки
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}