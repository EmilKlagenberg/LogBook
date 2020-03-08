using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public class LogPostQuestion
    {
        public string Answer { get; set; }
        public string Question { get; set; }
        public Guid Id { get; set; }
        public List<Tag> Tags { get; set; }
        public bool Scorable { get; set; }
        private readonly int? MinScore;
        private readonly int? MaxScore;
        private int? _score;

        public int? Score
        {
            get { return _score; }
            set {
                if (Scorable)
                {
                    if (value <= MaxScore && value >= MinScore)
                        _score = value;
                    else
                        throw new ApplicationException("Invalid score");
                }
            }  
        }

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
