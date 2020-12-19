using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Algorithm_Visualizer
{
    public partial class Form1 : Form
    {
        bool IsSort = false;
        int[] arr;
        Graphics g;
        Brush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush whiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush yellowBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
        Brush pinkBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Pink);
        Brush limeBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Lime);
        Brush redBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        Brush greenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        Brush orangeBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
        Brush cyanBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Cyan);
        Brush purpleBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Purple);
        Brush blueBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IsSort = true;
            g = panel1.CreateGraphics();
            int numEntries = panel1.Width;
            int maxHeight = panel1.Height;
            arr = new int[numEntries];
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numEntries, maxHeight);
            Random rand = new Random();
            for(int i = 0;i<numEntries;i++)
            {
                arr[i] = rand.Next(0, maxHeight);
            }
            for (int i = 0; i < numEntries; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maxHeight - arr[i], 1, maxHeight);
            }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsSort == true)
            {
                Interface1 se = new Class1();
                se.start(arr, g, panel1.Height);
                IsSort = false;
            }
            //else error : you should reset before you wooooooo
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
                panel2.Visible = false;
            else
                panel2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColors_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
                panel3.Visible = false;
            else
                panel3.Visible = true;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {

        }

        private void btnPink_Click(object sender, EventArgs e)
        {

        }

        private void btnLime_Click(object sender, EventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {

        }

        private void btnOrange_Click(object sender, EventArgs e)
        {

        }

        private void btnCyan_Click(object sender, EventArgs e)
        {

        }

        private void btnPurple_Click(object sender, EventArgs e)
        {

        }

        private void btnWhite_Click(object sender, EventArgs e)
        {

        }
    }
}
