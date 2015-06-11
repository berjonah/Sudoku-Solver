using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Cell
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
                if(value < 0 || value > 9)
                {
                    throw new ArgumentOutOfRangeException("Value must be between 1 and 9");
                }
                else
                {
                    number = value;
                }
            }
        }

        private Row row;
        public Row Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        private Column column;
        public Column Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }

        private Square square;
        public Square Square
        {
            get
            {
                return square;
            }
            set
            {
                square = value;
            }
        }

        public Cell(bool solved)
        {
            this.Solved = solved;
        }

        public Cell(bool solved, int number)
            : this(solved)
        {
            this.Number = number;
        }

        public Cell(int number)
        {
            if(number == 0)
            {
                this.Solved = false;
            }
            else
            {
                this.Solved = true;
                this.Number = number;
            }
        }

        public bool isValid(int el)
        {
            if(!Column.isIn(el) && !Row.isIn(el) && !Square.isIn(el))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
