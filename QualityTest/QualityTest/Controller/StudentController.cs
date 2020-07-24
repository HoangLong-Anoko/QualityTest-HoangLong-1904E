using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace QualityTest.Controller
{
    class StudentController
    {
        Student st = new Student();
        string targetDateFormat = "dd/MM/yyyy";
        public void PrintListStudent(List<Student> students)
        {
            foreach(Student s in students)
            {
                Console.WriteLine("Roll Number: " + s.RollNumber);
                Console.WriteLine("FullName : " + s.FullName);
                Console.WriteLine("Birthday : " + s.Birthday);
                Console.WriteLine("Email : " + s.Email);
                Console.WriteLine("Phone : " + s.Phone);
                Console.WriteLine("CreatedAt: " + s.CreatedAt);
                Console.WriteLine("Status: " + s.Status);
            }
        }

        public Student CreateStudent()
        {
            
            Console.WriteLine("Nhap vao cac thong tin cua sinh vien can tao: ");
            Console.WriteLine("Roll Number: ");
            string rollNumber = Console.ReadLine();
            Console.WriteLine("Full Name: ");
            string fullName = Console.ReadLine();
            //birthday
            Console.WriteLine("Birthday: ");
            Console.WriteLine("Enter a date in the format day/month/year");
            string enteredDateString = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(enteredDateString, targetDateFormat,CultureInfo.InvariantCulture);
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            string phone = Console.ReadLine();
            //ngay nhap hoc
            Console.WriteLine("Ngay nhap hoc: ");
            Console.WriteLine("Enter a date in the format day/month/year");
            enteredDateString = Console.ReadLine();
            DateTime createdAt = DateTime.ParseExact(enteredDateString, targetDateFormat, CultureInfo.InvariantCulture);
            //status
            int statusChoice;
            bool pass = false;
            Student.StudentStatus newStatus = Student.StudentStatus.ACTIVE;
            while (!pass)
            {
                Console.WriteLine("Nhap vao trang thai sv. 1 = Active, 0 = Deactive :");
                statusChoice = int.Parse(Console.ReadLine());
                switch (statusChoice)
                {
                    case 0:
                        newStatus = Student.StudentStatus.DEACTIVE;
                        pass = true;
                        break;
                    case 1:
                        newStatus = Student.StudentStatus.ACTIVE;
                        pass = true;
                        break;
                    default: 
                        break;
                }
            }
            return new Student(rollNumber, fullName, birthday, email, phone, createdAt, newStatus);
        }
    }
}
