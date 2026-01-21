using System.Globalization;

namespace CodeQuest.Challenges
{
    public abstract class ChallengeBase
    {
        public int Day { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
        public int Points { get; set; }

        public ChallengeBase(int day,string title,string description,string difficulty,int points)
        {
            Day = day;
            Title = title;
            Description = description;
            Difficulty = difficulty;
            Points = points;
        }
        public abstract string Solve(string input);

        public abstract string GetExampleInput();

        public abstract string GetExampleOutput();
    }
}

