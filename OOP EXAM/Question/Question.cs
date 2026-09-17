using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.question
{
    internal class Question
    {
		private string _Header = string.Empty;
        private string _Body = string.Empty;
        private int _Mark;

        public string Header
        {
			get { return _Header; }
			set
			{
				if (!string.IsNullOrEmpty(value))
					_Header = value;
			}
		}
		public string Body
        {
			get { return _Body; }
			set
			{
				if (!string.IsNullOrEmpty(value))
					_Body = value;
			}
		}
        public int Mark
        {
			get { return _Mark; }
			set
			{
				if (value >= 0)
				_Mark = value;
			}
		}

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

    }
}
