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
        private Square[] squares;
        public Square[] Squares
        {
            get
            {
                return squares;
            }
            set
            {
                squares = value;
            }
        }

        public ExclusiveZone(Square[] inSquares)
        {
            if(inSquares.Length!=9)
            {
                throw new ArgumentOutOfRangeException("Argument must contain array of 9 squares");
            }
            else
            {
                Squares = inSquares;
            }
        }
        bool testExclusivity()
        {
            List<int> found = new List<int>();
            foreach(Square test in Squares)
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
    }
}
