using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    abstract class ExclusiveZone
    {
        //has 9 squares
        private List<Cell> cells;
        public List<Cell> Cells
        {
            get
            {
                return cells;
            }
            set
            {
                cells = value;
            }
        }

        public ExclusiveZone(List<Cell> list)
        {
            if(list.Count != 9)
            {
                throw new ArgumentOutOfRangeException("Argument must contain List of 9 cells");
            }
            else
            {
                Cells = list;
            }
        }
        public bool testExclusivity()
        {
            List<int> found = new List<int>();
            foreach(Cell test in Cells)
            {
                if(test.Solved)
                {
                    if(!found.Contains(test.Number))
                    {
                        found.Add(test.Number);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool isIn(int el)
        {
            foreach(Cell cell in Cells)
            {
                if(cell.Number == el)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
