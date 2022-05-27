using ComputerGraphics.Core.Algorithms.Clipping.CohenSutherland;
using ComputerGraphics.Core.Algorithms.Clipping.WeilerAtherton;
using ComputerGraphics.Core.Algorithms.Rasterization.Primitives;
using ComputerGraphics.UI.Utils.Rasterization.Primitives.Line;
using ComputerGraphics.Utils.Rasterization.Primitives.Ellipse;
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
using static WinFormsCG.Color;

namespace WinFormsCG
{


    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private Random random = new Random();
        private Brush brush;
        private Bitmap bitmap;
      
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(System.Drawing.Color.Black, 2);
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

            //Color.ToRGB();
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
        protected static int Fi1, Fi2;
        protected static double Fi;
        public static void InitFi(int x,int y, double z)
        {
            Fi1 = x;
            Fi2 = y;
            Fi =z;
        }

      

        private void primitivesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormInputPrimitiev ForChoose = new();
            ForChoose.ShowDialog();


            Bitmap bitmap = new(pictureBox1.Width,pictureBox1.Height);
            

            void setpixel(int x, int y)
            {
           
                bitmap.SetPixel(x, y, System.Drawing.Color.FromArgb(Convert.ToInt32(RGB.Red), Convert.ToInt32(RGB.Green), Convert.ToInt32(RGB.Blue)));
            }
            double Function1(double x) 
            {
                //double radian =;
                return (1 -Math.Abs(Math.Cos(x))) / 5;
            } 

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            
            Action<int, int> stpixel = setpixel;

            int minCircle =1000;
            int maxCircle = 0;

            for (double i = Fi1; i < Fi2; i+=Fi)
            {
                
                double angle = i * Math.PI / 180;


                int x0 = (int)(Function1(angle) *Math.Cos(angle) * 100);
                int y0 = (int)(Function1(angle) * Math.Sin(angle) * 100);

                int x1 = (int)(1 * Math.Cos(angle) * 100);
                int y1 = (int)(1 * Math.Sin(angle) * 100);

                minCircle = (int)Math.Min(minCircle,(Math.Sqrt(x0 * x0 + y0*y0)));
                maxCircle = (int)Math.Max(maxCircle, (Math.Sqrt(x1 * x1 + y1 * y1)));

                Color.ToRGB(angle, 100, 100);
                LineBresenham.Draw(x0+ pictureBox1.Width/2, y0+ pictureBox1.Height/2, x1+ pictureBox1.Width/2, y1+ pictureBox1.Height/2, stpixel);
            }
            RGB.Red=0;
            RGB.Blue = 0;
            RGB.Green = 0;
            CircleBresenham.Draw(minCircle, pictureBox1.Width/2, pictureBox1.Height/2, stpixel);
            CircleBresenham.Draw(maxCircle, pictureBox1.Width / 2, pictureBox1.Height / 2, stpixel);

            pictureBox1.Image = bitmap;
           
        }

        bool isClicked = false; // идентификатор нажатия кнопки мыши

        int X = 0;
        int Y = 0;

        int X1 = 0;
        int Y1 = 0;

        Point[] points = new Point[8];
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;

            X = e.X;
            Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                X1 = e.X;
                Y1 = e.Y;
                //pictureBox1.Invalidate(); //если кнопка зажата, то перерисовываем прямоугольник 
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            //каждая последующая выходит из предыдущей
            Bitmap bitmap1 = new(pictureBox1.Width, pictureBox1.Height);

            void setpixel(int x, int y)
            {

                bitmap1.SetPixel(x, y, System.Drawing.Color.Red);
            }

            Action<int, int> stpixel = setpixel;

            int xLine = 0, yLine = 0, x1Line = 0, y1Line = 0;

            var clippedLine = (xLine, yLine, x1Line, y1Line);

            if (X>X1)
            {
                (X, X1) = (X1, X);
            }
            if (Y < Y1)
            {
                (Y, Y1) = (Y1, Y);
            }
            if(CohenSutherland.Clip((40, 40, 400, 400), (X, X1, Y1, Y), out clippedLine))
            {
                LineBresenham.Draw(clippedLine.xLine, clippedLine.yLine, clippedLine.x1Line, clippedLine.y1Line, stpixel);
            }
            

           
            pictureBox1.Image = bitmap1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           

            points[0] = new Point(X, Y);
            points[1] = new Point(X1, Y);
            points[2] = new Point(X1, Y);
            points[3] = new Point(X1, Y1);
            points[4] = new Point(X1, Y1);
            points[5] = new Point(X, Y1);
            points[6] = new Point(X, Y1);
            points[7] = new Point(X, Y);

             e.Graphics.DrawLines(pen, points);  //рисуем соединенные линии по координатам точек
           
        }

        private void richTextBoxDecodingT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cohenSutherlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Visible = true;
            pictureBox1.BackColor = System.Drawing.Color.White;

            Bitmap bitmap1 = new(pictureBox1.Width, pictureBox1.Height);
            void setpixel(int x, int y)
            {
                bitmap1.SetPixel(x, y, System.Drawing.Color.Red);
            }
            Action<int, int> stpixel = setpixel;

            int[] LinesForPolygon = {100,100,100,200,200,200,200,100 };
            int[] LinesForClipPolygon = { 220, 400, 150, 10 };


            CustomPolygon CastPolygon = new(LinesForPolygon);
            CustomPolygon CastClipPolygon = new(LinesForClipPolygon);

            IEnumerable<CustomLine> resultLines;

            resultLines = WeilerAthertonAlgorithm.Clip(CastPolygon,CastClipPolygon);

            foreach (var line in resultLines)
            {
                LineBresenham.Draw((int)line.P1.X, (int)line.P1.Y, (int)line.P2.X, (int)line.P2.Y, setpixel);
            }
            pictureBox1.Image = bitmap1;
        }
    }

    
}
