
namespace WinFormsCG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lZ77ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.primitivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelbmp = new System.Windows.Forms.Panel();
            this.buttonSaveBmp = new System.Windows.Forms.Button();
            this.buttonOpenFileBmp = new System.Windows.Forms.Button();
            this.right_panel = new System.Windows.Forms.GroupBox();
            this.start_mosaika = new System.Windows.Forms.Button();
            this.MosaikaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hslRGB = new System.Windows.Forms.Button();
            this.RgbHsl = new System.Windows.Forms.Button();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Lab3panel = new System.Windows.Forms.Panel();
            this.richTextBoxDecodingT = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEncodingT = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelbmp.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.MosaikaPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Lab3panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lab1ToolStripMenuItem,
            this.lab2ToolStripMenuItem,
            this.lab3ToolStripMenuItem,
            this.lab3ToolStripMenuItem1,
            this.lab3ToolStripMenuItem2,
            this.lab3ToolStripMenuItem3});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.taskToolStripMenuItem.Text = "Task";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
            // 
            // lab1ToolStripMenuItem
            // 
            this.lab1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task1ToolStripMenuItem});
            this.lab1ToolStripMenuItem.Name = "lab1ToolStripMenuItem";
            this.lab1ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.lab1ToolStripMenuItem.Text = "Lab1";
            // 
            // task1ToolStripMenuItem
            // 
            this.task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            this.task1ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.task1ToolStripMenuItem.Text = "Mosaika";
            this.task1ToolStripMenuItem.Click += new System.EventHandler(this.task1ToolStripMenuItem_Click);
            // 
            // lab2ToolStripMenuItem
            // 
            this.lab2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorConversionToolStripMenuItem,
            this.bMPToolStripMenuItem});
            this.lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            this.lab2ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.lab2ToolStripMenuItem.Text = "Lab2";
            // 
            // colorConversionToolStripMenuItem
            // 
            this.colorConversionToolStripMenuItem.Name = "colorConversionToolStripMenuItem";
            this.colorConversionToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.colorConversionToolStripMenuItem.Text = "Color Conversion";
            this.colorConversionToolStripMenuItem.Click += new System.EventHandler(this.colorConversionToolStripMenuItem_Click);
            // 
            // bMPToolStripMenuItem
            // 
            this.bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            this.bMPToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.bMPToolStripMenuItem.Text = "BMP";
            this.bMPToolStripMenuItem.Click += new System.EventHandler(this.bMPToolStripMenuItem_Click_1);
            // 
            // lab3ToolStripMenuItem
            // 
            this.lab3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lZ77ToolStripMenuItem});
            this.lab3ToolStripMenuItem.Name = "lab3ToolStripMenuItem";
            this.lab3ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.lab3ToolStripMenuItem.Text = "Lab3";
            // 
            // lZ77ToolStripMenuItem
            // 
            this.lZ77ToolStripMenuItem.Name = "lZ77ToolStripMenuItem";
            this.lZ77ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.lZ77ToolStripMenuItem.Text = "LZ77";
            this.lZ77ToolStripMenuItem.Click += new System.EventHandler(this.lZ77ToolStripMenuItem_Click);
            // 
            // lab3ToolStripMenuItem1
            // 
            this.lab3ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primitivesToolStripMenuItem});
            this.lab3ToolStripMenuItem1.Name = "lab3ToolStripMenuItem1";
            this.lab3ToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.lab3ToolStripMenuItem1.Text = "Lab4";
            // 
            // primitivesToolStripMenuItem
            // 
            this.primitivesToolStripMenuItem.Name = "primitivesToolStripMenuItem";
            this.primitivesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.primitivesToolStripMenuItem.Text = "Primitivies";
            this.primitivesToolStripMenuItem.Click += new System.EventHandler(this.primitivesToolStripMenuItem_Click);
            // 
            // lab3ToolStripMenuItem2
            // 
            this.lab3ToolStripMenuItem2.Name = "lab3ToolStripMenuItem2";
            this.lab3ToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.lab3ToolStripMenuItem2.Text = "Lab5";
            this.lab3ToolStripMenuItem2.Click += new System.EventHandler(this.lab3ToolStripMenuItem2_Click);
            // 
            // lab3ToolStripMenuItem3
            // 
            this.lab3ToolStripMenuItem3.Name = "lab3ToolStripMenuItem3";
            this.lab3ToolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.lab3ToolStripMenuItem3.Text = "Lab6";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.aboutToolStripMenuItem.Text = "About a program";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 418);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.panelbmp);
            this.panel1.Controls.Add(this.right_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(679, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 418);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelbmp
            // 
            this.panelbmp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelbmp.Controls.Add(this.buttonSaveBmp);
            this.panelbmp.Controls.Add(this.buttonOpenFileBmp);
            this.panelbmp.Location = new System.Drawing.Point(0, 0);
            this.panelbmp.Name = "panelbmp";
            this.panelbmp.Size = new System.Drawing.Size(159, 418);
            this.panelbmp.TabIndex = 16;
            this.panelbmp.Visible = false;
            // 
            // buttonSaveBmp
            // 
            this.buttonSaveBmp.Location = new System.Drawing.Point(12, 335);
            this.buttonSaveBmp.Name = "buttonSaveBmp";
            this.buttonSaveBmp.Size = new System.Drawing.Size(138, 35);
            this.buttonSaveBmp.TabIndex = 1;
            this.buttonSaveBmp.Text = "Save";
            this.buttonSaveBmp.UseVisualStyleBackColor = true;
            this.buttonSaveBmp.Click += new System.EventHandler(this.buttonSaveBmp_Click);
            // 
            // buttonOpenFileBmp
            // 
            this.buttonOpenFileBmp.Location = new System.Drawing.Point(12, 374);
            this.buttonOpenFileBmp.Name = "buttonOpenFileBmp";
            this.buttonOpenFileBmp.Size = new System.Drawing.Size(138, 36);
            this.buttonOpenFileBmp.TabIndex = 0;
            this.buttonOpenFileBmp.Text = "Open";
            this.buttonOpenFileBmp.UseVisualStyleBackColor = true;
            this.buttonOpenFileBmp.Click += new System.EventHandler(this.buttonOpenFileBmp_Click);
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.start_mosaika);
            this.right_panel.Location = new System.Drawing.Point(3, 4);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(153, 411);
            this.right_panel.TabIndex = 0;
            this.right_panel.TabStop = false;
            this.right_panel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // start_mosaika
            // 
            this.start_mosaika.Location = new System.Drawing.Point(6, 372);
            this.start_mosaika.Name = "start_mosaika";
            this.start_mosaika.Size = new System.Drawing.Size(138, 33);
            this.start_mosaika.TabIndex = 0;
            this.start_mosaika.Text = "start";
            this.start_mosaika.UseVisualStyleBackColor = true;
            this.start_mosaika.Visible = false;
            this.start_mosaika.Click += new System.EventHandler(this.start_mosaika_Click);
            // 
            // MosaikaPanel
            // 
            this.MosaikaPanel.AllowDrop = true;
            this.MosaikaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MosaikaPanel.Controls.Add(this.textBox1);
            this.MosaikaPanel.Controls.Add(this.comboBox1);
            this.MosaikaPanel.Controls.Add(this.textBox2);
            this.MosaikaPanel.Controls.Add(this.comboBox2);
            this.MosaikaPanel.Controls.Add(this.textBox3);
            this.MosaikaPanel.Controls.Add(this.comboBox3);
            this.MosaikaPanel.Controls.Add(this.textBox4);
            this.MosaikaPanel.Controls.Add(this.comboBox4);
            this.MosaikaPanel.Controls.Add(this.domainUpDown1);
            this.MosaikaPanel.Controls.Add(this.textBox5);
            this.MosaikaPanel.Controls.Add(this.textBox6);
            this.MosaikaPanel.Location = new System.Drawing.Point(682, 28);
            this.MosaikaPanel.Name = "MosaikaPanel";
            this.MosaikaPanel.Size = new System.Drawing.Size(153, 345);
            this.MosaikaPanel.TabIndex = 1;
            this.MosaikaPanel.Tag = "lab1";
            this.MosaikaPanel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(144, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Color 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Green",
            "Yellow",
            "Brown",
            "Crimson",
            "Coral",
            "Chocolate"});
            this.comboBox1.Location = new System.Drawing.Point(3, 29);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(144, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(144, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Color 2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Green",
            "Yellow",
            "Brown",
            "Crimson",
            "Coral",
            "Chocolate"});
            this.comboBox2.Location = new System.Drawing.Point(3, 86);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(144, 23);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.TabStop = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 117);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(144, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Color 3";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Green",
            "Yellow",
            "Brown",
            "Crimson",
            "Coral",
            "Chocolate"});
            this.comboBox3.Location = new System.Drawing.Point(3, 143);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox3.Size = new System.Drawing.Size(144, 23);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.TabStop = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 174);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(144, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Color 4";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Green",
            "Yellow",
            "Brown",
            "Crimson",
            "Coral",
            "Chocolate"});
            this.comboBox4.Location = new System.Drawing.Point(3, 200);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox4.Size = new System.Drawing.Size(144, 23);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.TabStop = false;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("2 * 2");
            this.domainUpDown1.Items.Add("4 * 4");
            this.domainUpDown1.Items.Add("8 * 8");
            this.domainUpDown1.Location = new System.Drawing.Point(3, 238);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(144, 23);
            this.domainUpDown1.TabIndex = 9;
            this.domainUpDown1.Text = "Box Size";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 274);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 23);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Mosaika width";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 310);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 23);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Mosaika height";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hslRGB);
            this.panel2.Controls.Add(this.RgbHsl);
            this.panel2.Controls.Add(this.textBoxL);
            this.panel2.Controls.Add(this.textBoxS);
            this.panel2.Controls.Add(this.textBoxH);
            this.panel2.Controls.Add(this.textBox13);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBoxB);
            this.panel2.Controls.Add(this.textBoxG);
            this.panel2.Controls.Add(this.textBoxR);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 415);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // hslRGB
            // 
            this.hslRGB.Location = new System.Drawing.Point(420, 327);
            this.hslRGB.Name = "hslRGB";
            this.hslRGB.Size = new System.Drawing.Size(162, 43);
            this.hslRGB.TabIndex = 15;
            this.hslRGB.Text = "HSL -> RGB";
            this.hslRGB.UseVisualStyleBackColor = true;
            this.hslRGB.Click += new System.EventHandler(this.hslRGB_Click);
            // 
            // RgbHsl
            // 
            this.RgbHsl.Location = new System.Drawing.Point(95, 327);
            this.RgbHsl.Name = "RgbHsl";
            this.RgbHsl.Size = new System.Drawing.Size(162, 43);
            this.RgbHsl.TabIndex = 14;
            this.RgbHsl.Text = "RGB -> HSL";
            this.RgbHsl.UseVisualStyleBackColor = true;
            this.RgbHsl.Click += new System.EventHandler(this.RgbHsl_Click);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(526, 278);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(116, 23);
            this.textBoxL.TabIndex = 13;
            this.textBoxL.Text = "(0..1)%";
            this.textBoxL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(526, 178);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(116, 23);
            this.textBoxS.TabIndex = 12;
            this.textBoxS.Text = "(0..1)%";
            this.textBoxS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(526, 90);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(116, 23);
            this.textBoxH.TabIndex = 11;
            this.textBoxH.Text = "(0..360)";
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.AccessibleDescription = "";
            this.textBox13.Location = new System.Drawing.Point(357, 278);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(134, 23);
            this.textBox13.TabIndex = 10;
            this.textBox13.Text = "Write L";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.AccessibleDescription = "";
            this.textBox12.Location = new System.Drawing.Point(357, 178);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(134, 23);
            this.textBox12.TabIndex = 9;
            this.textBox12.Text = "Write S";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.AccessibleDescription = "";
            this.textBox11.Location = new System.Drawing.Point(357, 90);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(134, 23);
            this.textBox11.TabIndex = 8;
            this.textBox11.Text = "Write H";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.AccessibleDescription = "";
            this.textBox10.Location = new System.Drawing.Point(357, 33);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(285, 23);
            this.textBox10.TabIndex = 7;
            this.textBox10.Text = "HSL";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(192, 278);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(116, 23);
            this.textBoxB.TabIndex = 6;
            this.textBoxB.Text = "(0..255)";
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(192, 178);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(116, 23);
            this.textBoxG.TabIndex = 5;
            this.textBoxG.Text = "(0..255)";
            this.textBoxG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(192, 89);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(116, 23);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Text = "(0..255)";
            this.textBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.AccessibleDescription = "";
            this.textBox9.Location = new System.Drawing.Point(23, 278);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(134, 23);
            this.textBox9.TabIndex = 3;
            this.textBox9.Text = "Write B";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.AccessibleDescription = "";
            this.textBox8.Location = new System.Drawing.Point(23, 178);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(134, 23);
            this.textBox8.TabIndex = 2;
            this.textBox8.Text = "Write G";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.AccessibleDescription = "";
            this.textBox7.Location = new System.Drawing.Point(23, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(285, 23);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "RGB";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.AccessibleDescription = "";
            this.textBox15.Location = new System.Drawing.Point(23, 90);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(134, 23);
            this.textBox15.TabIndex = 0;
            this.textBox15.Text = "Write R";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lab3panel
            // 
            this.Lab3panel.Controls.Add(this.richTextBoxDecodingT);
            this.Lab3panel.Controls.Add(this.richTextBoxEncodingT);
            this.Lab3panel.Location = new System.Drawing.Point(0, 24);
            this.Lab3panel.Name = "Lab3panel";
            this.Lab3panel.Size = new System.Drawing.Size(838, 418);
            this.Lab3panel.TabIndex = 16;
            this.Lab3panel.Visible = false;
            // 
            // richTextBoxDecodingT
            // 
            this.richTextBoxDecodingT.Location = new System.Drawing.Point(23, 33);
            this.richTextBoxDecodingT.Name = "richTextBoxDecodingT";
            this.richTextBoxDecodingT.Size = new System.Drawing.Size(384, 346);
            this.richTextBoxDecodingT.TabIndex = 1;
            this.richTextBoxDecodingT.Text = "";
            this.richTextBoxDecodingT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxDecodingT_KeyPress);
            // 
            // richTextBoxEncodingT
            // 
            this.richTextBoxEncodingT.Location = new System.Drawing.Point(442, 33);
            this.richTextBoxEncodingT.Name = "richTextBoxEncodingT";
            this.richTextBoxEncodingT.Size = new System.Drawing.Size(384, 346);
            this.richTextBoxEncodingT.TabIndex = 0;
            this.richTextBoxEncodingT.Text = "";
            this.richTextBoxEncodingT.TextChanged += new System.EventHandler(this.richTextBoxEncodingT_TextChanged);
            this.richTextBoxEncodingT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxEncodingT_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 442);
            this.Controls.Add(this.Lab3panel);
            this.Controls.Add(this.MosaikaPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Comuter Graphics";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelbmp.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.MosaikaPanel.ResumeLayout(false);
            this.MosaikaPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Lab3panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox right_panel;
        private System.Windows.Forms.Button start_mosaika;
        private System.Windows.Forms.FlowLayoutPanel MosaikaPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem lab2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorConversionToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button RgbHsl;
        private System.Windows.Forms.Button hslRGB;
        private System.Windows.Forms.Panel panelbmp;
        private System.Windows.Forms.ToolStripMenuItem bMPToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpenFileBmp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveBmp;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lZ77ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem3;
        private System.Windows.Forms.Panel Lab3panel;
        private System.Windows.Forms.RichTextBox richTextBoxDecodingT;
        private System.Windows.Forms.RichTextBox richTextBoxEncodingT;
        private System.Windows.Forms.ToolStripMenuItem primitivesToolStripMenuItem;
    }
}

