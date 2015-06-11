using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Square : ExclusiveZone
    {
        public Square(List<Cell> list)
            : base(list)
        {
            foreach(Cell cell in list)
            {
                cell.Square = this;
            }
        }
    }
}
