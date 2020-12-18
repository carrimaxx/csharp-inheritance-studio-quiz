﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public abstract class Question
    {
        public int PointValue { get; set; }
        private string Text { get; set; }

        public Question(int pointValue, string text)
        {
            PointValue = pointValue;
            Text = text;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Text);
        }

        public abstract void DisplayAnswers();

        public abstract int GetAnswers();
    }
}
