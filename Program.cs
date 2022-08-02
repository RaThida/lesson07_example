using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson07_example
{
    class School
    {
        public string strSchoolName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }

        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }


    }
    class Student : School
    {
        public string strStudentName;
        private float fltSchoolFees;
        public float SchoolFees
        {
            get { return fltSchoolFees; }
            set {
                if (value > 0.0f)
                    fltSchoolFees = value;
            }
        }
        public Student(string strStudentName, float fltSchoolFees, string strSchoolName, string strAddress): base(strSchoolName, strAddress)
        {
            this.strStudentName = strStudentName;
            this.fltSchoolFees = fltSchoolFees;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            Console.Write("Enter the school: ");
            string myschool = Console.ReadLine();
            Console.Write("Enter the address: ");

            string myaddress = Console.ReadLine();
            Console.Write("Enter the name of the student: ");
            string myname = Console.ReadLine();
            Console.Write("Enter the school Fee: ");
            float myschoolfee = float.Parse(Console.ReadLine());


            objS1 = new Student(myname, myschoolfee, myschool, myaddress);

            Console.WriteLine("School name: {0}", objS1.strSchoolName);
            Console.WriteLine("Address: {0}", objS1.Address);
            Console.WriteLine("Student name: {0}", objS1.strStudentName);
            Console.WriteLine("School Fees: {0}", objS1.SchoolFees);



        }
    }
}
