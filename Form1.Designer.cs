
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.MosaikaPanel.SuspendLayout();
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
            this.lab1ToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.taskToolStripMenuItem.Text = "Task";
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.aboutToolStripMenuItem.Text = "About a program";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 418);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.right_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(679, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 418);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.MosaikaPanel.Controls.Add(this.textBox1);
            this.MosaikaPanel.Controls.Add(this.comboBox1);
            this.MosaikaPanel.Controls.Add(this.textBox2);
            this.MosaikaPanel.Controls.Add(this.comboBox2);
            this.MosaikaPanel.Controls.Add(this.textBox3);
            this.MosaikaPanel.Controls.Add(this.comboBox3);
            this.MosaikaPanel.Controls.Add(this.textBox4);
            this.MosaikaPanel.Controls.Add(this.comboBox4);
            this.MosaikaPanel.Controls.Add(this.domainUpDown1);
            this.MosaikaPanel.Location = new System.Drawing.Point(682, 28);
            this.MosaikaPanel.Name = "MosaikaPanel";
            this.MosaikaPanel.Size = new System.Drawing.Size(153, 366);
            this.MosaikaPanel.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 442);
            this.Controls.Add(this.MosaikaPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Comuter Graphics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.MosaikaPanel.ResumeLayout(false);
            this.MosaikaPanel.PerformLayout();
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
    }
}

