using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationControl2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
            this.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveStep = 10;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox1.Left -= moveStep;
                    break;
                case Keys.Right:
                    pictureBox1.Left += moveStep;
                    break;
                case Keys.Up:
                    pictureBox1.Top -= moveStep;
                    break;
                case Keys.Down:
                    pictureBox1.Top += moveStep;
                    break;
            }

        }
    }
}
