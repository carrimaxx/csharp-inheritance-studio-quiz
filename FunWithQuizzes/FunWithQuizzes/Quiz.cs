using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class Quiz // list of questions
    {
        // TODO add questions
        // TODO run the quiz --> print the list of questions, method
        // TODO grade the quiz --> 

        public List<Question> Questions { get; set; }
        public int Score { get; set; }
        private int Total { get; set; }


        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            Total = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                Total += questions[i].Point;
            }
        }
    }
}
