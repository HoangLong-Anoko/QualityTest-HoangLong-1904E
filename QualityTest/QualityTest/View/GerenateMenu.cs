using QualityTest.Controller;
using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.View
{
    class GerenateMenu
    {
        StudentController sc = new StudentController();
        public static List<Student> ListStudents = new List<Student>();
        public void runMenu()
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.Write("Xin nhap lua chon :");
                Console.Write("1. Tao moi sinh vien ");
                Console.Write("2. In ra danh sach sinh vien :");
                Console.Write("0. Thoat");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Hen gap lai!");
                        break;
                    case 1:
                        Student newst = sc.CreateStudent();
                        ListStudents.Add(newst);
                        break;
                    case 2:
                        sc.PrintListStudent(ListStudents);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong ton tai. Moi nhap lai ");
                        break;
                }
            }

        }
    }
}
