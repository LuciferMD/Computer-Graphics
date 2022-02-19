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

    internal static class Mosaika
    {
        public static int mosaikaBoxWidth { get; set; }
        public static int mosaikaBoxHeigth { get; set; }

        public static int boxSize { get; set; }

        public static Color[] colors = { Color.Crimson, Color.Chocolate, Color.Coral, Color.White };
        static Mosaika()
        {
            mosaikaBoxWidth = 300;
            mosaikaBoxHeigth = 300;
            boxSize = 4;
        }
    }

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
            
            start_mosaika.Visible = true;
            MosaikaPanel.Visible = true;
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
            
            int widthBox = Mosaika.boxSize;

            Color[] colors = Mosaika.colors;

            int countWidthBoxes = Mosaika.mosaikaBoxWidth / widthBox;
            int countHeightBoxes = Mosaika.mosaikaBoxHeigth / widthBox;

            for (int b = 0; b < countHeightBoxes; b++)
            {
                for (int i = 0; i < countWidthBoxes; i++)
                {
                    brush = new SolidBrush(colors[random.Next(0,colors.Length)]); ///Choose random color from massive

                    Rectangle rectangle = new Rectangle(i* widthBox, b* widthBox, widthBox, widthBox);
                    graphics.FillRectangle(brush, rectangle);   
                }
            }
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
