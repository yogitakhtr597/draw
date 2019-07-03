namespace shapes
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.increment = new System.Windows.Forms.TextBox();
            this.lenght = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.number_of_lines = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(799, 397);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.increment);
            this.panel2.Controls.Add(this.lenght);
            this.panel2.Controls.Add(this.angle);
            this.panel2.Controls.Add(this.number_of_lines);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 54);
            this.panel2.TabIndex = 1;
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(605, 27);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(72, 20);
            this.increment.TabIndex = 8;
            this.increment.Text = "0";
            // 
            // lenght
            // 
            this.lenght.Location = new System.Drawing.Point(425, 27);
            this.lenght.Name = "lenght";
            this.lenght.Size = new System.Drawing.Size(54, 20);
            this.lenght.TabIndex = 7;
            this.lenght.Text = "0";
            this.lenght.TextChanged += new System.EventHandler(this.lenght_TextChanged);
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(261, 27);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(45, 20);
            this.angle.TabIndex = 6;
            this.angle.Text = "0";
            // 
            // number_of_lines
            // 
            this.number_of_lines.Location = new System.Drawing.Point(92, 23);
            this.number_of_lines.Name = "number_of_lines";
            this.number_of_lines.Size = new System.Drawing.Size(47, 20);
            this.number_of_lines.TabIndex = 5;
            this.number_of_lines.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(518, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "increment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(359, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "lenght";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(196, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "lines";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "let\'s draw";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox increment;
        private System.Windows.Forms.TextBox lenght;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.TextBox number_of_lines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

