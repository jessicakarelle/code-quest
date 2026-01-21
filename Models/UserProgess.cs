namespace CodeQuest.Models
{
    public class UserProgess
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChallengeId { get; set; }
        public bool IsSolved { get; set; }
        public int Score { get; set; }
        public int Attempts { get; set; }
        // public DateTime? 
        public User User { get; set; }
        public Challenge Challenge { get; set; }

    }
}
