using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    class Student
    {

        private String sID; private String fName;
        private String mName; private String lName;
        private String email;
        private String dob;
        private int yor;
        private String address, tel, bloodgroup, parent_Name, nationalism, religion;


        private String subjectCode;
        private String subjectName;
        private String studentGrade;
        private String examID;
        private int mark; 
        private int term;

        
        public String Religion
        {
            get { return religion; }
            set { religion = value; }
        }

        public String Nationalism
        {
            get { return nationalism; }
            set { nationalism = value; }
        }

        public String Parent_Name
        {
            get { return parent_Name; }
            set { parent_Name = value; }
        }
        
        public String Bloodgroup
        {
            get { return bloodgroup; }
            set { bloodgroup = value; }
        }

        public String Tel
        {
            get { return tel; }
            set { tel = value; }
        }


        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Yor
        {
            get { return yor; }
            set { yor = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string SID
        {
            get { return sID; }
            set { sID = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string MName
        {
            get { return mName; }
            set { mName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string SubjectCode
        {
            get
            {
                return subjectCode;
            }

            set
            {
                subjectCode = value;
            }
        }

        public string SubjectName
        {
            get
            {
                return subjectName;
            }

            set
            {
                subjectName = value;
            }
        }

        public string StudentGrade
        {
            get
            {
                return studentGrade;
            }

            set
            {
                studentGrade = value;
            }
        }

        public string ExamID
        {
            get
            {
                return examID;
            }

            set
            {
                examID = value;
            }
        }

        public int Mark
        {
            get
            {
                return mark;
            }

            set
            {
                mark = value;
            }
        }

        public int Term
        {
            get
            {
                return term;
            }

            set
            {
                term = value;
            }
        }
    }
    }

