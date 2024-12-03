namespace MoodJournal.Models
{
    public enum MoodType
    {
        Happy,
        Sad,
        Anxious,
        Calm
    }

    public class MoodEntry
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public MoodType Mood { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
