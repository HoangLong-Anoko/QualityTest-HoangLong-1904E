using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Models
{
    class Student
    {
        private string rollNumber;
        private string fullName;
        private DateTime birthday;
        private string email;
        private string phone;
        private DateTime createdAt;

        //constructor
        public Student() { }
        public Student(string rollNumber, string fullName, DateTime birthday, string email, string phone, DateTime createdAt, StudentStatus status)
        {
            this.rollNumber = rollNumber;
            this.fullName = fullName;
            this.birthday = birthday;
            this.email = email;
            this.phone = phone;
            this.createdAt = createdAt;
            this.Status = status;
        }
        public enum StudentStatus { ACTIVE = 1, DEACTIVE = 0 };
        public string RollNumber { get => rollNumber; set => rollNumber = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public StudentStatus Status { get; set; }
        bool IsNewStudent()
        {

            return createdAt >= DateTime.Now.AddMonths(-2);
        }

        bool IsDeactive()
        {
            if (Status == StudentStatus.DEACTIVE) return true;
            else return false;
        }


    }
}
