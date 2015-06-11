using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Cell> list = new List<Cell>();
            for(int i = 0; i < 9; i++)
            {
                list.Add(new Cell(true,9));
            }
            Square square = new Square(list);
        }
    }
}
