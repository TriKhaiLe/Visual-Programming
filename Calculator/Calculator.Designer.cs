﻿
namespace WindowsFormsApp1
{
    partial class Calculator
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
        /// 

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button01, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 273);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(149, 183);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 54);
            this.button12.TabIndex = 11;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(76, 183);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 54);
            this.button11.TabIndex = 10;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 183);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 54);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button00_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(149, 123);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 54);
            this.button9.TabIndex = 8;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button03_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(76, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 54);
            this.button8.TabIndex = 7;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button02_Click);
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(3, 123);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(67, 54);
            this.button01.TabIndex = 6;
            this.button01.Text = "1";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(149, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 54);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button06_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button05_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button04_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button09_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button08_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button07_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button19, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button18, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button16, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button14, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button13, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button15, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(239, 273);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(155, 240);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint_1);
            // 
            // button19
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.button19, 2);
            this.button19.Location = new System.Drawing.Point(3, 183);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(148, 54);
            this.button19.TabIndex = 6;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(80, 123);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(71, 54);
            this.button18.TabIndex = 5;
            this.button18.Text = "%";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(80, 63);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(71, 54);
            this.button16.TabIndex = 3;
            this.button16.Text = "x";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(80, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(71, 54);
            this.button14.TabIndex = 1;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(71, 54);
            this.button13.TabIndex = 0;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(3, 63);
            this.button15.Name = "button15";
            this.tableLayoutPanel2.SetRowSpan(this.button15, 2);
            this.button15.Size = new System.Drawing.Size(71, 114);
            this.button15.TabIndex = 2;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button20, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button17, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 222);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 45);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(192, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(183, 39);
            this.button20.TabIndex = 4;
            this.button20.Text = ")";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.buttonRPar_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(183, 39);
            this.button17.TabIndex = 3;
            this.button17.Text = "(";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.buttonLPar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 141);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(372, 56);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 517);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}