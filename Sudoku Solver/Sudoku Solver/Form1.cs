using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    public partial class Form1 : Form
    {
        private List<List<TextBox>> boxes;
        public Form1()
        {
            InitializeComponent();

            boxes = new List<List<TextBox>>();
            for (int i = 0; i < 9; i++)
            {
                boxes.Add(new List<TextBox>());
            }

            #region Make List
            boxes[0].Add(box00);
            boxes[0].Add(box01);
            boxes[0].Add(box02);
            boxes[0].Add(box03);
            boxes[0].Add(box04);
            boxes[0].Add(box05);
            boxes[0].Add(box06);
            boxes[0].Add(box07);
            boxes[0].Add(box08);

            boxes[1].Add(box10);
            boxes[1].Add(box11);
            boxes[1].Add(box12);
            boxes[1].Add(box13);
            boxes[1].Add(box14);
            boxes[1].Add(box15);
            boxes[1].Add(box16);
            boxes[1].Add(box17);
            boxes[1].Add(box18);

            boxes[2].Add(box20);
            boxes[2].Add(box21);
            boxes[2].Add(box22);
            boxes[2].Add(box23);
            boxes[2].Add(box24);
            boxes[2].Add(box25);
            boxes[2].Add(box26);
            boxes[2].Add(box27);
            boxes[2].Add(box28);

            boxes[3].Add(box30);
            boxes[3].Add(box31);
            boxes[3].Add(box32);
            boxes[3].Add(box33);
            boxes[3].Add(box34);
            boxes[3].Add(box35);
            boxes[3].Add(box36);
            boxes[3].Add(box37);
            boxes[3].Add(box38);

            boxes[4].Add(box40);
            boxes[4].Add(box41);
            boxes[4].Add(box42);
            boxes[4].Add(box43);
            boxes[4].Add(box44);
            boxes[4].Add(box45);
            boxes[4].Add(box46);
            boxes[4].Add(box47);
            boxes[4].Add(box48);

            boxes[5].Add(box50);
            boxes[5].Add(box51);
            boxes[5].Add(box52);
            boxes[5].Add(box53);
            boxes[5].Add(box54);
            boxes[5].Add(box55);
            boxes[5].Add(box56);
            boxes[5].Add(box57);
            boxes[5].Add(box58);

            boxes[6].Add(box60);
            boxes[6].Add(box61);
            boxes[6].Add(box62);
            boxes[6].Add(box63);
            boxes[6].Add(box64);
            boxes[6].Add(box65);
            boxes[6].Add(box66);
            boxes[6].Add(box67);
            boxes[6].Add(box68);

            boxes[7].Add(box70);
            boxes[7].Add(box71);
            boxes[7].Add(box72);
            boxes[7].Add(box73);
            boxes[7].Add(box74);
            boxes[7].Add(box75);
            boxes[7].Add(box76);
            boxes[7].Add(box77);
            boxes[7].Add(box78);

            boxes[8].Add(box80);
            boxes[8].Add(box81);
            boxes[8].Add(box82);
            boxes[8].Add(box83);
            boxes[8].Add(box84);
            boxes[8].Add(box85);
            boxes[8].Add(box86);
            boxes[8].Add(box87);
            boxes[8].Add(box88);
            #endregion
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            boxes[0][1].Text = boxes[0][0].Text;
            //List<List<Cell>> list = new List<List<Cell>>();
            //for(int i = 0; i < 9; i++)
            //{
            //    list.Add(new List<Cell>());
            //    for(int j = 0; j < 9; j++)
            //    {
            //        if(boxes[i][j].Text != "")
            //        {
            //            int foo = int.Parse(boxes[i][j].Text);
            //            list[i].Add(new Cell(foo));
            //        }
            //        else
            //        {
            //            list[i].Add(new Cell(0));
            //        }
            //    }
            //}

            //Board board = new Board(list);
            //bool bar = board.solve();

            //for(int i = 0; i < 9; i++)
            //{
            //    for(int j = 0; j < 9; j++)
            //    {
            //        boxes[i][j].Text = board.Cells[i][j].Number.ToString();
            //    }
            //}
        }
    }
}
