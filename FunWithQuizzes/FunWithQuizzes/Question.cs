using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public abstract class Question
    {
        public int Point { get; set; }
        public string Message { get; set; }

        public Question(int point, string message)
        {
            Point = point;
            Message = message;
        }

        public void PrintQuestion()
        {
            Console.WriteLine(Message);
        }

        public abstract void DisplayAnswers();

        //public abstract int GetAnswers(); // why int? : to get point
      
    }
}
