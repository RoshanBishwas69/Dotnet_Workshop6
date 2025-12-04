namespace Workshop6
{
    public class Music
    {
        public string SongName { get; set; }
        public int DurationSeconds { get; set; }

        public Music(string name, int duration)
        {
            SongName = name;
            DurationSeconds = duration;
        }
    }
}