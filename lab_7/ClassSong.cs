namespace lab_7
{
    class Song
    {
        private string name; 
        private string author; 
        private Song prev; // Связь с предыдущей песней

        
        public void SetName(string songName)
        {
            name = songName;
        }

        
        public void SetAuthor(string songAuthor)
        {
            author = songAuthor;
        }

        
        public void SetPrev(Song previousSong)
        {
            prev = previousSong;
        }

        
        public string Title()
        {
            return $"{name} - {author}";
        }


        public override bool Equals(object obj)
        {
            if (obj is Song otherSong)
            {
                return name == otherSong.name && author == otherSong.author;
            }
            return false;
        }


        public override int GetHashCode()
        {
            return (name?.GetHashCode() ?? 0) ^ (author?.GetHashCode() ?? 0);
        }
    }
}
