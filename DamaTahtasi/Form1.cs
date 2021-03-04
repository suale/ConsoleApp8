using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TahtaYap();

        }

        private void TahtaYap()
        {
            Button[,] buttons = new Button[8, 8];

            int left = 0;
            int top = 0;

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].TabStop = false;
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Width = 40;
                    buttons[i, j].Height = 40;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 40;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 40;
            }
        }
    }
}
