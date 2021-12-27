using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр3
{
    partial class Abiturient
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Abiturient b = obj as Abiturient;
            if (b == null)
                return false;
            return this.Name == b.Name && this.Surname == b.Surname && this.FatherName == b.FatherName &&
            this.Address == b.Address && this.PhoneNumber == b.PhoneNumber && this.Grades == b.Grades;
        }



        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Fathername: {FatherName}"; ;
        }
    }
}
