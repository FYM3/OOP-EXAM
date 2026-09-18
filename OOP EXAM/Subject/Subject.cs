using OOP_EXAM.exam;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.subject
{
    internal class Subject
    {
		private int _SubjectId;
		private string _SubjectName = string.Empty;

		public int SubjectId
        {
			get { return _SubjectId; }
			set
			{
				if (value > 0)
				_SubjectId = value;
			}
		}
        public string SubjectName
        {
            get { return _SubjectName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _SubjectName = value;
            }
        }

        public Exam? Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }


        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }
    }
}
