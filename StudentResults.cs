using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    class StudentResults
    {
        private String sCode;
        private String sName;
        private int forGrade;
        private String description;
        private int mark;
        private String examID;
        private int schoolTerm;


        public string SCode
        {
            get { return sCode; }
            set { sCode = value; }
        }

        public int ForGrade
        {
            get { return forGrade; }
            set { forGrade = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string ExamID
        {
            get { return examID; }
            set { examID = value; }
        }

        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }

        public int SchoolTerm
        {
            get { return schoolTerm; }
            set { schoolTerm = value; }
        }
    }
}
