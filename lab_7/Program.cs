using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 8.2");

            List<Song> songs = new List<Song>();

            for (int i = 0; i < 4; i++)
            {
                Song song = new Song();
                song.SetName($"Song {i + 1}");
                song.SetAuthor($"Author {i + 1}");
                songs.Add(song);
            }

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title());
            }

            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Первая и вторая песни одинаковые.");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни разные.");
            }

            // Упражнение 8.2
            string ReverseString(string input)
            {
                if (input == null)
                {
                    throw new ArgumentNullException(nameof(input), "Строка не должна быть null");
                }
                return new string(input.Reverse().ToArray());
            }

            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("1: " + ReverseString("Привет"));
            Console.WriteLine("2: " + ReverseString("12345"));
            Console.WriteLine("3: " + ReverseString("abcdef"));
            Console.WriteLine("4: " + ReverseString("!@#$%^&*()"));

            // Тестирование пустой строки
            Console.WriteLine("5: " + ReverseString(""));

            // Тестирование строки из одного символа
            Console.WriteLine("6: " + ReverseString("A"));

            try
            {
                // null
                Console.WriteLine("7: " + ReverseString(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // Упражнение 8.3
            bool ImplementsIFormattable(object obj)
            {
                if (obj is IFormattable)
                {
                    return true;
                }

                return false;
            }

            Console.WriteLine("Упражнение 8.3");
            int number = 123;
            DateTime dateTime = DateTime.Now;
            string text = "Hello, World!";
            double doubleValue = 45.67;

            // Проверка IFormattable
            Console.WriteLine($"Число: {ImplementsIFormattable(number)}"); 
            Console.WriteLine($"Дата и время: {ImplementsIFormattable(dateTime)}"); 
            Console.WriteLine($"Текст: {ImplementsIFormattable(text)}");
            Console.WriteLine($"Число с плавающей точкой: {ImplementsIFormattable(doubleValue)}");

            // Использование оператора as
            IFormattable formattableObject = dateTime as IFormattable;
            if (formattableObject != null)
            {
                Console.WriteLine($"Форматированная дата: {formattableObject.ToString("d", null)}");
            }
        }
    }
}