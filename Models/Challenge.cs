namespace CodeQuest.Models
{
    public class Challenge
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public string Title { get; set; }
        public string Difficulty { get; set; }
        public int Points { get; set; }
        public string ExampleInput { get; set; }
        public string ExampleOutput { get; set; }
    }
}
