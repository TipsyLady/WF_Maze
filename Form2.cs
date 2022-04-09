using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Maze
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Level_2 is done! Game is over");
            Application.Exit();


        }

        private void MoveToStart()
        {
            Point StartPoint = panel1.Location;
            StartPoint.Offset(15, 50);
            Cursor.Position = PointToScreen(StartPoint);
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Form_Closing(object sender, EventArgs e)
        {
        }
    }
}
