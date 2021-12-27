using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab7
{
    enum Elements
    {
        Radiobutton = 1,
        Button,
        Checktbox,
        Circle,
        Rectangle,
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[2];
            int a = 7;
            int[] aa = null;

            UI elems = new UI();
            ControlElem E1 = new Radiobutton("Radiobutton", 1, false);
            ControlElem E2 = new Radiobutton("Radiobutton", 2, false);
            ControlElem E3 = new Button("Button", 3, false);
            ControlElem E4 = new Button("Button", 4, false);
            ControlElem E5 = new Checktbox("Checktbox", 5, false);
            ControlElem E6 = new Checktbox("Checktbox", 6, false);
            elems.add(E1);
            elems.add(E2);
            elems.add(E3);
            elems.add(E4);
            elems.add(E5);
            elems.add(E6);

            Controller.GetResultSquare(elems);
            Console.WriteLine();
            Controller.PrintElems(elems);
            Console.WriteLine();
            Controller.PrintCount(elems);
            Console.WriteLine();

            Console.Write(" || Значения Enum: ");
            foreach (int i in Enum.GetValues(typeof(Elements)))
                Console.Write($"{i} ");

            Console.WriteLine("\n\n -\t-\t-\t-\t-\t-\t-\t-\n");

            try
            {
                arr[3] = 5;

                try {arr[3] = 10;}
                catch (MyException1 ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
                catch (IndexOutOfRangeException) { Console.WriteLine("Ошибка! IndexOutOfRangeException"); }
                catch (DivideByZeroException) { Console.WriteLine("Ошибка! DivideByZeroException"); }
                catch (Exception ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            }
            catch (MyException1 ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            catch (IndexOutOfRangeException) { Console.WriteLine("Ошибка! IndexOutOfRangeException"); }
            catch (DivideByZeroException) { Console.WriteLine("Ошибка! DivideByZeroException"); }
            catch (Exception ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            finally { Console.WriteLine(); }


            try { Button lm = new Button("Govno", 4, false); }
            catch (MyException2 ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            catch (IndexOutOfRangeException) { Console.WriteLine("Ошибка! IndexOutOfRangeException"); }
            catch (DivideByZeroException) { Console.WriteLine("Ошибка! DivideByZeroException"); }
            catch (Exception ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            finally { Console.WriteLine(); }

            try { zero pd = new zero { Val = 0 }; }
            catch (MyDivideByZeroException pd) { Console.WriteLine($"Ошибка! {pd.Message}"); }
            catch (IndexOutOfRangeException) { Console.WriteLine("Ошибка! IndexOutOfRangeException"); }
            catch (DivideByZeroException) { Console.WriteLine("Ошибка! DivideByZeroException"); }
            catch (Exception ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            finally { Console.WriteLine(); }

            try { massive p = new massive { Val = 23 }; }
            catch (MyArgumentOutOfRangeException p)
            {
                Console.WriteLine($"Ошибка! {p.Message}");
                Console.Write(p.TargetSite + "\n");
                Console.Write(p.StackTrace + "\n");
                Console.Write(p.HelpLink + "\n");
            }
            catch (IndexOutOfRangeException) { Console.WriteLine("Ошибка! IndexOutOfRangeException"); }
            catch (DivideByZeroException) { Console.WriteLine("Ошибка! DivideByZeroException"); }
            catch (Exception ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            finally { Console.WriteLine(); }

            try { a = a / 0; }
            catch (MyArgumentOutOfRangeException p) { Console.WriteLine($"Ошибка! {p.Message}"); }
            catch (IndexOutOfRangeException) { Console.WriteLine("Ошибка! IndexOutOfRangeException"); }
            catch (DivideByZeroException) { Console.WriteLine("Ошибка! DivideByZeroException"); }
            catch (Exception ex) { Console.WriteLine($"Ошибка! {ex.Message}"); }
            finally { Console.WriteLine(); }

            Debugger.Break();

            Debug.Assert(aa != null, "Ошибка! Массив не может быть пустым");

        }
    }
    

}