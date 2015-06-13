using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Board
    {
        List<List<Cell>> cells;
        public List<List<Cell>> Cells
        {
            get
            {
                return cells;
            }
            set
            {
                if(value.Count != 9)
                {
                    throw new ArgumentOutOfRangeException("Must be a 9 by 9 List");
                }
                else
                {
                    foreach(List<Cell> list in value)
                    {
                        if(list.Count != 9)
                        {
                            throw new ArgumentOutOfRangeException("Must be a 9 by 9 List");
                        }
                    }
                }
                cells = value;
            }
        }

        List<Row> rows;
        internal List<Row> Rows
        {
            get
            {
                return rows;
            }
            set
            {
                rows = value;
            }
        }

        List<Column> columns;
        internal List<Column> Columns
        {
            get
            {
                return columns;
            }
            set
            {
                columns = value;
            }
        }

        List<Square> squares;
        internal List<Square> Squares
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


        public Board(List<List<Cell>> cells)
        {
            this.Cells = cells;

            //setup Rows
            Columns = new List<Column>();
            foreach(List<Cell> column in Cells)
            {

                //each Row is just a row from cells
                Column newColumn = new Column(column);
                if (newColumn.testExclusivity())
                {
                    Columns.Add(newColumn);
                }
                else
                {
                    throw new Exception("Invalid Column");
                }
            }

            Rows = new List<Row>();
            int count = Cells.Count;
            for(int i = 0; i < count; i++)
            {
                //each Column is the all of the jth indexs from every column
                List<Cell> list = new List<Cell>();
                for(int j = 0; j < count; j++)
                {
                    list.Add(Cells[j][i]);
                }
                Row newRow = new Row(list);
                if(newRow.testExclusivity())
                {
                    Rows.Add(newRow);
                }
                else
                {
                    throw new Exception("Invalid Row");
                }
                
            }

            Squares = new List<Square>();
            for (int h = 0; h < count; h += 3)
            {
                for (int i = 0; i < count; i += 3)
                {
                    List<Cell> list = new List<Cell>();
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            list.Add(Cells[h + j][i + k]);
                        }
                    }
                    Square newSquare = new Square(list);
                    if (newSquare.testExclusivity())
                    {
                        Squares.Add(newSquare);
                    }
                    else
                    {
                        throw new Exception("Invalid Square");
                    }
                }
            }
        }

        public bool solve()
        {
            return solve(0, 0);
        }

        public bool solve(int row, int col)
        {
            if (row == 9)
                return true;

            if (Cells[row][col].Solved)
            {
                if(solve(col == 8 ? (row + 1) :row, (col + 1) % 9))
                    return true;
            }
            else
            {
                for(int i = 1; i <= 9; i++)
                {
                    if(Cells[row][col].isValid(i))
                    {
                        Cells[row][col].Number = i;
                        if (solve(col == 8 ? (row + 1) : row, (col + 1) % 9))
                            return true;
                        else
                        {
                            Cells[row][col].Number = 0;
                        }
                    }
                }
            }
            return false;
        }
    }
}
