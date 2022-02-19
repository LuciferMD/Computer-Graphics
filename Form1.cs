using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsCG
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private Random random= new Random();
        private Brush brush;
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black,10);
            random = new Random();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            right_panel.Text = "Mosaika";
            start_mosaika.Visible = true;

        }


      

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       

        private void start_mosaika_Click(object sender, EventArgs e)
        {
            int widthBox = 20;

            for (int b = 0; b < pictureBox1.Height; b++)
            {
                for (int i = 0; i < pictureBox1.Width; i++)
                {
                    brush = new SolidBrush(Color.FromArgb(255, (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));

                    Rectangle rectangle = new Rectangle(i* widthBox, b* widthBox, widthBox, widthBox);
                    graphics.FillRectangle(brush, rectangle);   
                }
            }
            
        } 

          
          


        


    }
}
