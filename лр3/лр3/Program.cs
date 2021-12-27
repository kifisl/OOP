using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace лр3
{
    class Program
    {
        static void Main()
        {
            Abiturient a = new Abiturient(new int[] { 4, 5, 8, 6, 9 }, "Anastasiya", "Yeliseyeva", "Denisovna", "Belaruskaya 21",  "3749034672");
            a.PrintInfo();
            a.MidGrade();
            a.MaxMinGrade();
            Abiturient b = new Abiturient(new int[] { 3, 6, 8, 5, 4 }, "Pirson", "Ilya", "", "Nastasicha 6", "63489300608");
            Abiturient c = new Abiturient(new int[] { 4, 9, 7, 2, 5 }, "Gusev", "Roman", "Nikolaev", "Mogilevskaya 36", "848902086");
            Abiturient d = new Abiturient(new int[] { 6, 9, 4, 8, 7 }, "Milos", "Margarita", "Kazimirovna", "Uborevicha 126", "32489087998");
            Console.WriteLine("");
            b.PrintInfo();
            b.MidGrade();
            b.MaxMinGrade();
            Console.WriteLine("");
            c.PrintInfo();
            c.MidGrade();
            c.MaxMinGrade();
            Console.WriteLine("");
            d.PrintInfo();
            d.MidGrade();
            d.MaxMinGrade();
            Console.WriteLine("");

            Abiturient[] all = new Abiturient[4];
            all[0] = new Abiturient(a);
            all[1] = new Abiturient(b);
            all[2] = new Abiturient(c);
            all[3] = new Abiturient(d);

            //a)
            Console.WriteLine("a) неудовлетворительные оценки: ");

            foreach(Abiturient element in all)
            {
                if(element.grades.Contains(3))
                {
                    element.PrintInfo();
                }

                if (element.grades.Contains(2))
                {
                    element.PrintInfo();
                }

                if (element.grades.Contains(1))
                {
                    element.PrintInfo();
                }
            }

            Console.WriteLine("----------------------------------------------------------------------");

            //b)
            int sum;
            Console.WriteLine("b) Введите сумму баллов: ");
            sum = Convert.ToInt32(Console.ReadLine());
            
            foreach(Abiturient element in all)
            {
                if (element.grades.Sum() > sum)
                    element.PrintInfo();
            }

            if (a.Equals(b))
            {
                Console.WriteLine("Запись 1 = записи 2");
            }
            else
                Console.WriteLine("Запись 1 != записи 2");

            if (a.Equals(c))
            {
                Console.WriteLine("Запись 1 = записи 3");
            }
            else
                Console.WriteLine("Запись 1 != записи 3");
            Console.WriteLine("---------------------------------");

            var Abb = new { Name = "Kate", Age = 19 };
            Console.WriteLine(Abb.Name + " " + Abb.Age);
        }

    }
}
