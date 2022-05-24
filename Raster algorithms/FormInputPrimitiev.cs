using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsCG
{
    public partial class FormInputPrimitiev : Form
    {
        public FormInputPrimitiev()
        {
            InitializeComponent();
        }

        private void InputFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.Parse(InputFrom.Text)>=0&& int.Parse(InputFrom.Text)<=360)
            {
                if (int.Parse(inputTo.Text) >= 0 && int.Parse(inputTo.Text) <= 360)
                {
                    if (double.Parse(inputd.Text) >= 0 && double.Parse(inputd.Text) <= 360)
                    {
                        Form1.InitFi(int.Parse(InputFrom.Text), int.Parse(inputTo.Text), double.Parse(inputd.Text));
                        this.Close();
                    }
                }
            }
        }
    }
}
