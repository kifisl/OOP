using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace лр3
{
    partial class Abiturient
    {
        public readonly int id;
        static int numberOfAbiturients = 0;
        const int a = 43;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Address;
        public string PhoneNumber;
        private int[] Grades;
        public int[] grades
        {
            get
            {
                return Grades;
            }
            set
            {
                Grades = value;
            }
        }
        

        public Abiturient(int[] grades, string name = "", string surname = "", string fathername = "", string address = "",  string phonenumber = "")
        {
            ++numberOfAbiturients;
            Name = name;
            Surname = surname;
            FatherName = fathername;
            Address = address;
            Grades = grades;
            PhoneNumber = phonenumber;
            id = this.GetHashCode();
        }

        public Abiturient(Abiturient a)
        {
            ++numberOfAbiturients;
            Name = a.Name;
            Surname = a.Surname;
            FatherName = a.FatherName;
            Address = a.Address;
            Grades = a.Grades;
            PhoneNumber = a.PhoneNumber;
            id = this.GetHashCode();
        }
        static Abiturient()
        {
            Console.WriteLine("Создана первая запись");
        }

        private Abiturient()
        {
            numberOfAbiturients++;
            Console.WriteLine("Будущая запись");
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("ФИО: " + Name + " " + Surname + " " + FatherName);
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Оценки: ");
            for (int i = 0; i < Grades.Length; i++)
            {
                Console.WriteLine( Grades[i]);
            }
            
            Console.WriteLine("Номер Телефона: " + PhoneNumber);
            Console.WriteLine("ID: " + id);
        }

        public static void TypeOfClass()
        {
            Type tp = Type.GetType("лр3.Abiturient");
            Console.WriteLine(tp.AssemblyQualifiedName);
        }

        public void MidGrade()
        {
            int summ = 0;
            for (int i = 0; i < Grades.Length; i++)
             {
                summ += Grades[i];
             }

            int mid = summ / Grades.Length;
            Console.WriteLine("Средний балл: " + mid);
        }

        public void MaxMinGrade()
        {
            int max = Grades.Max();
            int min = Grades.Min();
            Console.WriteLine("Максимальный балл: " + max);
            Console.WriteLine("Минимальный балл: " + min);

        }

     


    }

}
