using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Row : ExclusiveZone
    {
        public Row(List<Cell> list)
            : base(list)
        {
            foreach(Cell cell in list)
            {
                cell.Row = this;
            }
        }
    }
}
