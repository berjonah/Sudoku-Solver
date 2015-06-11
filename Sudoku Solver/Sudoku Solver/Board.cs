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
            Rows = new List<Row>();
            foreach(List<Cell> row in Cells)
            {
                //each Row is just a row from cells
                Rows.Add(new Row(row));
            }

            Columns = new List<Column>();
            int count = Cells.Count;
            for(int i = 0; i < count; i++)
            {
                //each Column is the all of the ith indexs from every row
                List<Cell> list = new List<Cell>();
                for(int j = 0; j < count; j++)
                {
                    list.Add(Cells[i][j]);
                }
                Columns.Add(new Column(list));
            }

            Squares = new List<Square>();
            for(int i = 0; i < count; i+=3)
            {
                List<Cell> list = new List<Cell>();
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        list.Add(Cells[i + j][i + k]);
                    }
                }
                Squares.Add(new Square(list));
            }
        }

    }
}
