using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public class LogPostAnswer
    {
        public Guid Id { get; set; }
        public Guid Question { get; set; }
        public int? Score { get; set; }
        public string Text { get; set; }
        public LogPostAnswer(Guid question, int? score=null, string text=null)
        {
            Id = Guid.NewGuid();
            Question = question;
            Score = score;
            Text = text;
        }
        public override string ToString()
        {
            if (Text == null)
                Text = "";
            if (Score == null)
                return Text;
            return Score.ToString();
        }
    }
}
