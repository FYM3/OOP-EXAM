using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.answers
{
    internal class Answers
    {
		private int _AnswerId;
		private string _AnswerText = string.Empty;

        public int AnswerId
        {
            get { return _AnswerId; }
            set
            {
                if (value >= 0)
                    _AnswerId = value;
            }
        }
        public string AnswerText
        {
			get { return _AnswerText; }
			set
			{
				if (!string.IsNullOrEmpty(value))
					_AnswerText = value;
			}
		}

        public Answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }



    }
}
