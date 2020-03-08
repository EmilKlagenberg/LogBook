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
        public List<LogPostQuestion> QuestionList { get; set; }
        public string Note { get; set; }
        
        public List<Tag> GetTags()
        {
            return QuestionList.SelectMany(x => x.Tags).Distinct().ToList();
        }
    }


}
