using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    class Song
    {
        private string name; // Название песни
        private string author; // Автор песни
        private Song prev; // Связь с предыдущей песней в списке

        // Метод для заполнения поля name
        public void SetName(string songName)
        {
            name = songName;
        }

        // Метод для заполнения поля author
        public void SetAuthor(string songAuthor)
        {
            author = songAuthor;
        }

        // Метод для заполнения поля prev
        public void SetPrev(Song previousSong)
        {
            prev = previousSong;
        }

        // Метод для печати названия песни и ее исполнителя
        public string Title()
        {
            return $"{name} - {author}";
        }

        // Метод, который сравнивает между собой два объекта-песни
        public override bool Equals(object obj)
        {
            if (obj is Song otherSong)
            {
                return name == otherSong.name && author == otherSong.author;
            }
            return false;
        }

        // Уникальный хэш-код для песен
        public override int GetHashCode()
        {
            return (name?.GetHashCode() ?? 0) ^ (author?.GetHashCode() ?? 0);
        }
    }
}
