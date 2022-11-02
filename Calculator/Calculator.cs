using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(Environment.NewLine + "+" + Environment.NewLine);
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.AppendText("0");

            }
        }

        private void button01_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.AppendText("1");

            }
        }

        private void button02_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.AppendText("2");

            }
        }

        private void button03_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.AppendText("3");

            }
        }

        private void button04_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.AppendText("4");

            }
        }

        private void button05_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.AppendText("5");

            }
        }

        private void button06_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.AppendText("6");

            }
        }

        private void button07_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.AppendText("7");

            }
        }

        private void button08_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.AppendText("8");

            }
        }

        private void button09_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.AppendText("9");

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string add = Environment.NewLine + "+" + Environment.NewLine;
            textBox1.AppendText(add);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string sub = Environment.NewLine + "-" + Environment.NewLine;
            textBox1.AppendText(sub);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string div = Environment.NewLine + "/" + Environment.NewLine;
            textBox1.AppendText(div);
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            string mul = Environment.NewLine + "*" + Environment.NewLine;
            textBox1.AppendText(mul);

        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            string mod = Environment.NewLine + "%" + Environment.NewLine;
            textBox1.AppendText(mod);

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "Out.exe";
            Button ButtonObject = (Button)sender;

            textBox2.Text = "";
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            //Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;


            string src1 = File.ReadAllText("in1.txt");
            string src2 = File.ReadAllText("in2.txt");
            string fullSrc = src1 + textBox1.Text + src2;

            //File.WriteAllText("out.txt", fullSrc);

            //string fullSrc = File.ReadAllText("in.txt");
            //

            CompilerResults results = icc.CompileAssemblyFromSource(parameters, fullSrc);

            if (results.Errors.Count > 0)
            {
                textBox2.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    textBox2.Text = textBox2.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                //Successful Compile
                Process.Start(Output);


                Timer timer = new Timer();
                timer.Interval = 800;
                timer.Tick += new EventHandler(TimerOnTick);
                timer.Enabled = true;
            }
        }

        void TimerOnTick(object obj, EventArgs ea)
        {
            Timer timer = (Timer)obj;
            timer.Stop();
            timer.Tick -= new EventHandler(TimerOnTick);
            textBox2.ForeColor = Color.Blue;
            textBox2.Text = File.ReadAllText("out.txt");
        }

        private void buttonLPar_Click(object sender, EventArgs e)
        {
            string lPar = "(";
            textBox1.AppendText(lPar);

        }

        private void buttonRPar_Click(object sender, EventArgs e)
        {
            string rPar = ")";
            textBox1.AppendText(rPar);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            string point = ".";
            textBox1.AppendText(point);
        }
    }
}
