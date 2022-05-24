
namespace WinFormsCG
{
    partial class FormInputPrimitiev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputFrom = new System.Windows.Forms.TextBox();
            this.inputTo = new System.Windows.Forms.TextBox();
            this.inputd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputFrom
            // 
            this.InputFrom.Location = new System.Drawing.Point(42, 28);
            this.InputFrom.Name = "InputFrom";
            this.InputFrom.Size = new System.Drawing.Size(134, 23);
            this.InputFrom.TabIndex = 0;
            this.InputFrom.Text = "Write φ1";
            this.InputFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputFrom.TextChanged += new System.EventHandler(this.InputFrom_TextChanged);
            // 
            // inputTo
            // 
            this.inputTo.Location = new System.Drawing.Point(42, 85);
            this.inputTo.Name = "inputTo";
            this.inputTo.Size = new System.Drawing.Size(134, 23);
            this.inputTo.TabIndex = 1;
            this.inputTo.Text = "Write φ2";
            this.inputTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTo.WordWrap = false;
            this.inputTo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputd
            // 
            this.inputd.Location = new System.Drawing.Point(42, 147);
            this.inputd.Name = "inputd";
            this.inputd.Size = new System.Drawing.Size(134, 23);
            this.inputd.TabIndex = 2;
            this.inputd.Text = "Write Δφ";
            this.inputd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInputPrimitiev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputd);
            this.Controls.Add(this.inputTo);
            this.Controls.Add(this.InputFrom);
            this.Name = "FormInputPrimitiev";
            this.Text = "FormInputPrimitiev";
            this.Controls.SetChildIndex(this.InputFrom, 0);
            this.Controls.SetChildIndex(this.inputTo, 0);
            this.Controls.SetChildIndex(this.inputd, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFrom;
        private System.Windows.Forms.TextBox inputTo;
        private System.Windows.Forms.TextBox inputd;
        private System.Windows.Forms.Button button1;
    }
}