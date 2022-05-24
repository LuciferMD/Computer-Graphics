using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resorces.LZ77;

namespace WinFormsCG
{


    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private Random random = new Random();
        private Brush brush;
        private Bitmap bitmap ;
        
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(System.Drawing.Color.Black, 10);
            random = new Random();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            start_mosaika.Visible = true;
            MosaikaPanel.Visible = true;
        }


        private void bMPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panelbmp.Visible = true;
            
        }

        private void lZ77ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab3panel.Visible = true;
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_mosaika.Visible = false;
            MosaikaPanel.Visible = false;
            panel2.Visible = false;
            panelbmp.Visible = false;
            Lab3panel.Visible = false;
            //pictureBox1.BackColor = System.Drawing.Color.;


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

            System.Drawing.Color[] colors = Mosaika.colors;

            int countWidthBoxes = Mosaika.mosaikaBoxWidth / widthBox + 1;
            int countHeightBoxes = Mosaika.mosaikaBoxHeigth / widthBox + 1;

            for (int b = 0; b < countHeightBoxes; b++)
            {
                for (int i = 0; i < countWidthBoxes; i++)
                {
                    brush = new SolidBrush(colors[random.Next(0, colors.Length)]); ///Choose random color from massive
                    if (i == countWidthBoxes - 1)
                    {
                        int whg = Mosaika.mosaikaBoxWidth % widthBox;
                        int heig = widthBox;
                        if (b == countHeightBoxes - 1)
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
                        Rectangle rectangle = new Rectangle(i * widthBox, b * widthBox, widthBox, widthBox);
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
                    Mosaika.colors[numberColor] = System.Drawing.Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Chocolate;
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
                    Mosaika.colors[numberColor] = System.Drawing.Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Chocolate;
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
                    Mosaika.colors[numberColor] = System.Drawing.Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Chocolate;
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
                    Mosaika.colors[numberColor] = System.Drawing.Color.Red;
                    break;
                case 1:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Black;
                    break;
                case 2:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Green;
                    break;
                case 3:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Yellow;
                    break;
                case 4:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Brown;
                    break;
                case 5:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Crimson;
                    break;
                case 6:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Coral;
                    break;
                case 7:
                    Mosaika.colors[numberColor] = System.Drawing.Color.Chocolate;
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

        private void colorConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }



        private void RgbHsl_Click(object sender, EventArgs e)
        {
            byte R;
            byte G;
            byte B;

            bool isByte = byte.TryParse(textBoxR.Text, out R);
            if (isByte)
                Color.RGB.Red = R;
            bool isByte1 = byte.TryParse(textBoxG.Text, out G);
            if (isByte1)
                Color.RGB.Green = G;
            bool isByte2 = byte.TryParse(textBoxB.Text, out B);
            if (isByte2)
                Color.RGB.Blue = B;

            Color.FromRGB();
            textBoxH.Text = Color.HSL.Hue.ToString("F0");
            textBoxS.Text = Color.HSL.Saturation.ToString("F2");
            textBoxL.Text = Color.HSL.Luminosity.ToString("F2");
        }



        private void hslRGB_Click(object sender, EventArgs e)
        {
            float H;
            bool isfloat = float.TryParse(textBoxH.Text, out H);
            if (isfloat)
                Color.HSL.Hue = H;

            float S;
            bool isfloat1 = float.TryParse(textBoxS.Text, out S);
            if (isfloat1)
                Color.HSL.Saturation = S;

            float L;
            bool isfloat2 = float.TryParse(textBoxL.Text, out L);
            if (isfloat2)
                Color.HSL.Luminosity = L;

            Color.ToRGB();
            textBoxR.Text = Color.RGB.Red.ToString();
            textBoxG.Text = Color.RGB.Green.ToString();
            textBoxB.Text = Color.RGB.Blue.ToString();
        }

        private void richTextBoxEncodingT_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFileBmp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filepath = openFileDialog1.FileName;

            Bmp.OpenBmpImage(filepath);

            bitmap = new( Convert.ToInt32(Bmp.width),Bmp.height);

            for (int x = 0; x < Bmp.height; x++)
            {
                for (int y = 0; y < Bmp.width; y++)
                {
                    bitmap.SetPixel(y, x, System.Drawing.Color.FromArgb(Convert.ToInt32(Bmp.row.Pop()), Convert.ToInt32(Bmp.row.Pop()), Convert.ToInt32(Bmp.row.Pop())));
                 
                }
            }
            pictureBox1.Image = bitmap;
            
        }
        private void buttonSaveBmp_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
   
                Bmp.width= Convert.ToUInt16(pictureBox1.Image.Width);
                Bmp.height = pictureBox1.Image.Height;
                Bmp.offset = 54;
                Bmp.headerSize = 40;
                Bmp.fileSize =Convert.ToUInt32(Bmp.height * Bmp.width * 3 + 54);
                Bmp.row.Clear();


                for (int x = 0; x < Bmp.height; x++)
                {
                    for (int y = 0; y < Bmp.width; y++)
                    {

                        Bmp.row.Push(Convert.ToByte(bitmap.GetPixel(y, x).B));
                        Bmp.row.Push(Convert.ToByte(bitmap.GetPixel(y, x).G));
                        Bmp.row.Push(Convert.ToByte(bitmap.GetPixel(y, x).R));

                    }
                }
                Bmp.SaveBmpImage(dialog.FileName);
            }

        }

        private void lab3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
  

        }



        private void richTextBoxDecodingT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string text = richTextBoxDecodingT.Text;
                richTextBoxEncodingT.Text = string.Empty;
                text = text.Replace("\n", "");
                richTextBoxEncodingT.Text = LZ77.Encode(text);        
                
            }
        }

        private void richTextBoxEncodingT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string text = richTextBoxEncodingT.Text;
                richTextBoxDecodingT.Text = string.Empty;
                text = text.Replace("\n", "");
                richTextBoxDecodingT.Text = LZ77.Decode(text);


            }
        }

        private void primitivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
