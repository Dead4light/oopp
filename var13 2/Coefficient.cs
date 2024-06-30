using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var13_2
{
    public struct Coefficient
    {
        public int Row;
        public int Column;
        public double Value;

        public Coefficient(int row, int column, double value)
        {
            Row = row;
            Column = column;
            Value = value;
        }
    }
}
