using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public class LogPostQuestion
    {
        public string Question { get; set; }
        public Guid Id { get; set; }
        public List<Tag> Tags { get; set; }
        public bool Scorable { get; set; }
        public int? MinScore { get; set; }
        public int? MaxScore { get; set; }


        public LogPostQuestion(string question, List<Tag> tags) : this(question, tags, null, null )
        { }
        public LogPostQuestion(string question, List<Tag> tags, int? minScore, int? maxScore)
        {
            Question = question;
            Tags = tags;
            bool scoreable = false;
            if (minScore != null && maxScore != null) scoreable = true;
            if (scoreable)
            {
                MinScore = minScore;
                MaxScore = maxScore;
            }
        }
    }
}
