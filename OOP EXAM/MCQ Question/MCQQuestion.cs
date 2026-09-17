using OOP_EXAM.question;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.trueFalseQuestion
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark)
        {
        }
    }
}
