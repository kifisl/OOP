using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class MyException1 : ArgumentException
    {
        public int Value { get; }

        public MyException1(string message, int val) : base(message)
        {
            Value = val;
        }
    }
    class MyException2 : ArgumentException
    {
        public string Value { get; }

        public MyException2(string message, string val) : base(message)
        {
            Value = val;
        }
    }

    class MyDivideByZeroException : DivideByZeroException
    {
        public int Value { get; }
        public MyDivideByZeroException(string message, int val): base(message)
        {
            Value = val;
        }
    }
    class MyArgumentOutOfRangeException : ArgumentOutOfRangeException
    {
        public int Value { get; }
        public MyArgumentOutOfRangeException(string message, int val) : base(message)
        {
            Value = val;
        }
    }
}
