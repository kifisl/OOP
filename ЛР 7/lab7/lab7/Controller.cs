using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    static partial class Controller
    {
        public static void GetResultSquare(UI a, int square = 0)
        {
            foreach (ControlElem i in a.elems)
            {
                square = square + i.square;
            }
            Console.WriteLine($" || Площадь занимаемая всеми элементам = {square}");

        }
        public static void PrintElems(UI a)
        {
            Console.WriteLine($" || Все элементы: ");

            foreach (ControlElem i in a.elems)
            {

                Console.WriteLine($" | {i.name}");
            }
        }
        public static void PrintCount(UI a)
        {
            int i = 0;
            foreach (ControlElem e in a.elems)
            {
                i++;
            }
            Console.WriteLine($" || Число всех элементов списка: {i}");
        }
    }
    public class UI
    {
        public List<ControlElem> elems = new List<ControlElem> { };
        public void add(ControlElem name)
        {
            elems.Add(name);
        }
        public void delete(ControlElem name)
        {
            int number = 0;
            foreach (ControlElem i in elems)
            {
                if (i == name)
                {
                    break;
                }
                number++;
            }
            elems.RemoveAt(number);
        }
        public void display()
        {
            foreach (ControlElem i in elems)
            {
                Console.WriteLine(i.name);
            }
        }
    }
}
