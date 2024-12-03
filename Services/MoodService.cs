using MoodJournal.Models;
using System.Collections.Generic;

namespace MoodJournal.Services
{
    public class MoodService
    {
        private readonly List<MoodEntry> moodEntries = new();

        public List<MoodEntry> GetMoodEntries() => moodEntries;

        public void AddMoodEntry(MoodEntry moodEntry)
        {
            moodEntries.Add(moodEntry);
        }
    }
}
