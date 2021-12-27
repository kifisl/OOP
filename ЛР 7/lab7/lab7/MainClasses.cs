using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public abstract partial class ControlElem : UI
    {
        public abstract string name { get; set; }
        public abstract int square { get; set; }
        public abstract bool status { get; set; }
    }
    class Checktbox : ControlElem
    {
        public override bool status { get; set; }
        private string val;
        public override string name 
        { 
            get { return val;} 
            set { if (value != "Checktbox") {throw new MyException2("Недопустимое имя элемента для данного типа", value); }
                else { val = value; }
            }
        }
        public override int square { get; set; }
        public Checktbox(string Name, int Square, bool Status)
        {
            name = Name;
            square = Square;
            status = Status;
        }

    }
    class Radiobutton : ControlElem
    {
        public override bool status { get; set; }
        private string val;
        public override string name
        {
            get { return val; }
            set
            {
                if (value != "Radiobutton") { throw new MyException2("Недопустимое имя элемента для данного типа", value); }
                else { val = value; }
            }
        }
        public override int square { get; set; }
        public Radiobutton(string Name, int Square, bool Status)
        {
            name = Name;
            square = Square;
            status = Status;
        }
    }
    class Button : ControlElem
    {
        public override bool status { get; set; }
        private string val;
        public override string name
        {
            get { return val; }
            set
            {
                if (value != "Button") { throw new MyException2("Недопустимое имя элемента для данного типа", value); }
                else { val = value; }
            }
        }
        public override int square { get; set; }
        public Button(string Name, int Square, bool Status)
        {
            name = Name;
            square = Square;
            status = Status;
        }
    }
}