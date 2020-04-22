using SQLite;

namespace Class11Jokes
{
    public class JokeItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string JokeText { get; set; }
    }
}

