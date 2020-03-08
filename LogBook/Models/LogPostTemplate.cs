using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public class LogPostTemplate
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public List<LogPostQuestion> QuestionList { get; set; }
        public LogPostTemplate()
        {
            CreateTime = DateTimeOffset.Now;
            Id = Guid.NewGuid();
            QuestionList = new List<LogPostQuestion>();
        }

        public void AddQuestion(LogPostQuestion q)
        {
            QuestionList.Add(q);
        }
        public List<Tag> GetTags()
        {
            return QuestionList.SelectMany(x => x.Tags).Distinct().ToList();
        }
    }
}
