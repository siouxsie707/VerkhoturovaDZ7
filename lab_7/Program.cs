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
                Console.WriteLine("Тест 7: " + ReverseString(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}