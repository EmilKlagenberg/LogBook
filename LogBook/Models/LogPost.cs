using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public class LogPost
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public List<LogPostQuestion> Questions { get; set; }
        public Dictionary<LogPostQuestion, LogPostAnswer> QAList { get; set; }
        public string Note { get; set; }
        public LogPost(LogPostTemplate template)
        {
            CreateTime = DateTimeOffset.Now;
            Id = Guid.NewGuid();
            QAList = new Dictionary<LogPostQuestion, LogPostAnswer>();
            Questions = template.QuestionList;
        }
        public void AnswerQuestion(LogPostQuestion q, int? score=null, string text=null)
        {
            LogPostAnswer a = new LogPostAnswer(q.Id, score, text);

            if (QAList.ContainsKey(q))
                QAList.Remove(q);
            QAList.Add(q, a);
        }
        public List<Tag> GetTags()
        {
            return Questions.SelectMany(x => x.Tags).Distinct().ToList();
        }
    }


}
