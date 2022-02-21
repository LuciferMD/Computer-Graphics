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
            Refresh();
            int widthBox = Mosaika.boxSize;

            Color[] colors = Mosaika.colors;

            int countWidthBoxes = Mosaika.mosaikaBoxWidth / widthBox+1;
            int countHeightBoxes = Mosaika.mosaikaBoxHeigth / widthBox+1;

            for (int b = 0; b < countHeightBoxes; b++)
            {
                for (int i = 0; i < countWidthBoxes; i++)
                {
                    brush = new SolidBrush(colors[random.Next(0,colors.Length)]); ///Choose random color from massive
                    if(i == countWidthBoxes-1)
                    {
                        int whg = Mosaika.mosaikaBoxWidth % widthBox ;
                        int heig = widthBox;
                        if(b == countHeightBoxes - 1)
                        {
                             heig = Mosaika.mosaikaBoxHeigth % widthBox;
                        }
                        Rectangle rectangle1 = new Rectangle(i * widthBox, b * widthBox, whg, heig);
                        graphics.FillRectangle(brush, rectangle1);

                    }
                    else if (b == countHeightBoxes - 1)
                    {
                        int heig = Mosaika.mosaikaBoxHeigth % widthBox;
                        Rectangle rectangle2 = new Rectangle(i * widthBox, b * widthBox, widthBox, heig);
                        graphics.FillRectangle(brush, rectangle2);
                    }
                    else
                    {
                    Rectangle rectangle = new Rectangle(i* widthBox, b* widthBox, widthBox, widthBox);
                    graphics.FillRectangle(brush, rectangle);   
                    }
                    
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
            int index = comboBox1.SelectedIndex;
            int numberColor = 0;
            switch (index)
            {
                case 0:
                    Mosaika.colors[numberColor] = Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = Color.Chocolate;
                    break;
                default:
                    break;
            }
        }


        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            int numberColor = 1;
            switch (index)
            {
                case 0:
                    Mosaika.colors[numberColor] = Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = Color.Chocolate;
                    break;
                default:
                    break;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox3.SelectedIndex;
            int numberColor = 2;
            switch (index)
            {
                case 0:
                    Mosaika.colors[numberColor] = Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = Color.Chocolate;
                    break;
                default:
                    break;
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox4.SelectedIndex;
            int numberColor = 3;
            switch (index)
            {
                case 0:
                    Mosaika.colors[numberColor] = Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = Color.Chocolate;
                    break;
                default:
                    break;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            int index = domainUpDown1.SelectedIndex;
            switch (index)
            {
                case 0:
                    Mosaika.boxSize = 2;
                    break;
                case 1:
                    Mosaika.boxSize = 4;
                    break;
                case 2:
                    Mosaika.boxSize = 8;
                    break;
                default:
                    break;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int width;
            bool isNum = int.TryParse(textBox5.Text, out width);
            if (isNum)
                Mosaika.mosaikaBoxWidth = width;
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int heigth;
            bool isNum = int.TryParse(textBox6.Text, out heigth);
            if (isNum)
                Mosaika.mosaikaBoxHeigth = heigth;
        }
    }
}
