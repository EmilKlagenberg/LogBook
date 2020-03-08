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
            var tagList2 = new List<Tag>();
            tagList2.Add(new Tag("test3"));

            var a = Guid.NewGuid();
            var b = Guid.NewGuid();
            var c = Guid.NewGuid();

            var q1 = new LogPostQuestion("Hvor glad er du?", tagList, 1, 5) { Id = a };
            var q2 = new LogPostQuestion("Hvad er det bedste der skete i dag?", tagList2) { Id = b };
            var q3 = new LogPostQuestion("Hvor mæt er du?", tagList2, 1, 10) { Id = c };
                                 
            var temp1 = new LogPostTemplate();
            temp1.AddQuestion(q1);
            temp1.AddQuestion(q2);

            var temp2 = new LogPostTemplate();
            temp2.AddQuestion(q3);

            var posts = new List<LogPost>();
            var post1 = new LogPost(temp1) { Note = "Første note"};
            var post2 = new LogPost(temp2) { Note = "Anden note" };
            post1.AnswerQuestion(q1, 3, null);
            post1.AnswerQuestion(q2, null, "Is i Søborg");
            post2.AnswerQuestion(q3, 8, null);
            posts.Add(post1);
            posts.Add(post2);


            return posts;
        }
    }
}
