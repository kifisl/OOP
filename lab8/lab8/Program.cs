using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace lab8
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollectionType<string> obj1 = new CollectionType<string>();
                IGeneric<string> a;
                obj1.Add("бусь");
                obj1.Add("каки");
                obj1.Add("попа");
                a = obj1;
                a.Show();
                obj1.SaveInFile();

                Console.WriteLine();
                CollectionType<Geometric_figure> plGr = new CollectionType<Geometric_figure>();
                plGr.Add(new Circle());
                plGr.Add(new Rectangle());

                Geometric_figure figure = new Figures(12);
                plGr.Add(figure);
                plGr.Show();

                Console.WriteLine();
                plGr.Delete(figure);
                plGr.Show();
                plGr.SaveInFile();

                CollectionType<Geometric_figure> pl2 = new CollectionType<Geometric_figure>();
                LoadFromFile(ref pl2);
                Console.WriteLine("\nЭлементы файла 1.txt:");
                pl2.Show();
            }

            catch (CollectionException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nFINALLY");
            }
            Console.ReadLine();
        }
    }
}