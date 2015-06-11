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

        private List<int> posibilities;

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

        public void findPosibilities()
        {
            List<int> notAllowed = new List<int>();
            foreach(Cell cell in Square.Cells)
            {
                if(cell.Solved)
                {
                    if(!notAllowed.Contains(cell.Number))
                    {
                        notAllowed.Add(cell.Number);
                    }
                }   
            }
            foreach(Cell cell in Row.Cells)
            {
                if(cell.Solved)
                {
                    if(!notAllowed.Contains(cell.Number))
                    {
                        notAllowed.Add(cell.Number);
                    }
                }
            }
            foreach(Cell cell in Column.Cells)
            {
                if (cell.Solved)
                {
                    if (!notAllowed.Contains(cell.Number))
                    {
                        notAllowed.Add(cell.Number);
                    }
                }
            }
            for(int i = 1; i<=9;i++)
            {
                if(!notAllowed.Contains(i))
                {
                    posibilities.Add(i);
                }
            }
        }
    }
}
