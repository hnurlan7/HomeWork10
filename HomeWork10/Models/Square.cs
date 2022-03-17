using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10.Models
{
    internal class Square:Figure
    {
        private int _side;

        public int Side
        {
            get { return _side; }
            set
            {
                if (value > 0)
                {
                   _side = value;
                }
            }
        }
        public Square(int _side)
        {
            this.Side = _side;
        }

        public override int CalcArea()
        {
            return _side * _side;
        }
    }
}
