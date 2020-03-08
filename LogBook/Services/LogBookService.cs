using LogBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Services
{
    public class LogBookService : ILogBookService
    {
        public async Task<List<LogPost>> GetPostsAsync()
        {
            var tagList = new List<Tag>();
            tagList.Add(new Tag("test1"));
            tagList.Add(new Tag("test2"));

            var questionList = new List<LogPostQuestion>();
            questionList.Add(new LogPostQuestion("Hvor glad er du?", tagList, 1, 5) { Answer = "5" });
            questionList.Add(new LogPostQuestion("Hvad er det bedste der skete i dag?", tagList) { Answer = "lang tekst test...\r\n123\r\nPå flere linjer" });
                 var posts = new List<LogPost>();
            posts.Add(new LogPost { CreateTime = DateTimeOffset.Now, Note = "test", QuestionList = questionList });
            return  posts;
        }
    }
}
