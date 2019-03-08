namespace CalculatorWindowForm
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
            this.window = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.decbtn = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // window
            // 
            this.window.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window.Location = new System.Drawing.Point(29, 37);
            this.window.Multiline = true;
            this.window.Name = "window";
            this.window.ReadOnly = true;
            this.window.Size = new System.Drawing.Size(400, 55);
            this.window.TabIndex = 0;
            this.window.TextChanged += new System.EventHandler(this.window_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numbers);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numbers);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numbers);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numbers);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numbers);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(233, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numbers);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(29, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numbers);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(132, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numbers);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(233, 208);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numbers);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(29, 257);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(178, 23);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.numbers);
            // 
            // decbtn
            // 
            this.decbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decbtn.Location = new System.Drawing.Point(233, 257);
            this.decbtn.Name = "decbtn";
            this.decbtn.Size = new System.Drawing.Size(75, 23);
            this.decbtn.TabIndex = 12;
            this.decbtn.Text = ".";
            this.decbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.decbtn.UseVisualStyleBackColor = true;
            this.decbtn.Click += new System.EventHandler(this.decbtn_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(335, 122);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(36, 23);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.oper);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(335, 162);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(36, 23);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.oper);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(335, 208);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(36, 23);
            this.mult.TabIndex = 15;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.oper);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(335, 257);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(36, 23);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.oper);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(406, 122);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(39, 64);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(406, 212);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(39, 68);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.decbtn);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.window);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox window;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button decbtn;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button equal;
    }
}

