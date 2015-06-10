using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Square
    {
        private bool solved;
        public bool Solved
        {
            get
            {
                return solved;
            }
            set
            {
                solved = value;
            }
        }

        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if(value < 1 || value > 9)
                {
                    throw new ArgumentOutOfRangeException("Value must be between 1 and 9");
                }
                else
                {
                    number = value;
                }
            }
        }

        private int[] posibilities;

        public Square(bool solved)
        {
            this.Solved = solved;
        }

        public Square(bool solved, int number)
            : this(solved)
        {
            this.Number = number;
        }
    }
}
