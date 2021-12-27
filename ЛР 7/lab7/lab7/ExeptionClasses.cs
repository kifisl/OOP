using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class zero
    {
        private int val;
        public int Val
        {
            get { return val; }
            set
            {
                if (value == 0)
                    throw new MyException1("Деление ноль на ноль", value);
                else
                    val = value;
            }
        }
    }
    class massive
    {
        private int val;
        public int Val
        {
            get { return val; }
            set
            {
                if (value > 40 || value < 24)
                    throw new MyArgumentOutOfRangeException("Выход за границы допустимых значений", value);
                else
                    val = value;
            }
        }
        
    }
}
