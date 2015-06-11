using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Sudoku_Solver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            String[] lines = File.ReadAllLines(args[0]);
            int count = lines.Length;
            String[][] textNumbers = new String[count][];
            for(int i = 0; i<count;i++)
            {
                textNumbers[i] = lines[i].Split(',');
            }

            List<List<Cell>> list = new List<List<Cell>>();
            for(int i = 0; i<count;i++)
            {
                list.Add(new List<Cell>());
                for(int j=0; j<count;j++)
                {
                    list[i].Add(new Cell(int.Parse(textNumbers[i][j])));
                }
            }

            Board board = new Board(list);
            bool foo = board.solve(0,0);
        }
    }
}
