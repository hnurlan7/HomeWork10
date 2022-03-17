using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10.Models
{
    internal class Rectangular : Figure
    {
        private int _width;
        private int _length;

        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }

            }
        }
        public int Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
               
            }
        }
        public Rectangular(int _width, int _length)
        {
            this.Width = _width;
            this.Length = _length;
        }

        public override int CalcArea()
        {
            return _width * _length;
        }
    }
}
