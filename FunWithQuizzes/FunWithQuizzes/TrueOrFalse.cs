using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class TrueOrFalse : Question
    {
        public bool CorrectAnswer { get; set; }
        
        public TrueOrFalse(string message, int point, bool correctAnswer) : base(point, message)
        {
            Message = message;
            Point = point;
            CorrectAnswer = correctAnswer;
        }


        public override void DisplayAnswers()
        {
            Console.WriteLine(Message);
        }

        //public override int GetAnswers()
        //{
        //    Console.WriteLine(Point++);
        //}

    }
}
