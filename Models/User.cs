namespace CodeQuest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PassWordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TotalPoints { get; set; }

    }
}
