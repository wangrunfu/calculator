using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form1 : Form
    {
        double num1 = Math.E;
        string type="";
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string txt = btn.Text;
           //Console.WriteLine(button5.Text);
            //Console.WriteLine(btn.Text);
            if(txt=="+"||txt=="-"||txt=="*"||txt=="/"||txt=="log"||txt=="x^y")
            {
                double n;
                if(double.TryParse(textBox1.Text,out n)==false)
                {
                    textBox1.Text = "error: cannot calculate!";
                }
                else
                {
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    type = txt;
                }
            }
            else if(txt=="sin"||txt=="cos"||txt=="tan"||txt=="ln")
            {
                if (textBox1.Text != ""||type!="")
                {
                    textBox1.Text = "error: cannot calculate";
                }
                else
                {
                    type = txt;
                    textBox1.Text = type;
                }   
            }
            else if(txt=="clear")
            {
                textBox1.Text = "";
                result = 0;
                type = "";
            }
            else if(txt=="delete")
            {
                string str = textBox1.Text;
                if (str.Length > 0)
                {
                    str = str.Substring(0, str.Length - 1);
                    textBox1.Text = str;
                }
            }
            else if(txt=="=")
            {
                if (type == "")
                {
                    double n;
                    if (double.TryParse(textBox1.Text, out n) == false)
                    {
                        textBox1.Text = "error: number is error";
                    }
                    else
                    {
                        string str = textBox1.Text;
                        textBox1.Text = str;
                    }
                }
                else
                {
                    if (type == "+" || type == "-" || type == "*" || type == "/" || type == "log" || type == "x^y")
                    {
                        double n;
                        if (double.TryParse(textBox1.Text, out n) == false)
                        {
                            textBox1.Text = "error: cannot calculate";
                        }
                        else
                        {
                            double num2 = double.Parse(textBox1.Text);
                            if (type == "+")
                            {
                                result = num1 + num2;
                            }
                            else if (type == "-")
                            {
                                result = num1 - num2;
                            }
                            else if (type == "*")
                            {
                                result = num1 * num2;
                            }
                            else if (type == "/")
                            {
                                if (num2==0)
                                {
                                    textBox1.Text = "error: divided by 0";return;
                                }
                                else
                                {
                                    result = num1 / num2;
                                }
                            }
                            else if (type == "log")
                            {
                                result = Math.Log(num2, num1);
                            }
                            else if (type == "x^y")
                            {
                                result = Math.Pow(num1, num2);
                            }
                        }
                    }
                    else if (type == "sin" || type == "cos" || type == "tan")
                    {
                        string str = textBox1.Text;
                        str = str.Substring(3);
                        double n;
                        if (double.TryParse(str, out n) == false)
                        {
                            textBox1.Text = "error: cannot calculate";
                        }
                        else
                        {
                            double num2 = double.Parse(str);
                            if (type == "sin")
                            {
                                result = Math.Sin(num2 * Math.PI / 180);
                            }
                            else if (type == "cos")
                            {
                                result = Math.Cos(num2 * Math.PI / 180);
                            }
                            else if (type == "tan")
                            {
                                result = Math.Tan(num2 * Math.PI / 180);
                            }
                        }
                    }
                    else if (type == "ln")
                    {
                        string str = textBox1.Text;
                        str = str.Substring(2);
                        double n;
                        if (double.TryParse(str, out n) == false)
                        {
                            textBox1.Text = "error: cannot calculate";
                        }
                        else if (type == "ln")
                        {
                            double num2 = double.Parse(str);
                            result = Math.Log(num2, Math.E);
                        }
                    }
                    textBox1.Text = result.ToString();
                }
            }
            else
            {
                string tempstr = textBox1.Text;
                tempstr = tempstr + txt;
                textBox1.Text = tempstr;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button5_Click);
            this.button2.Click += new System.EventHandler(this.button5_Click);
            this.button3.Click += new System.EventHandler(this.button5_Click);
            this.button4.Click += new System.EventHandler(this.button5_Click);
            this.button6.Click += new System.EventHandler(this.button5_Click);
            this.button7.Click += new System.EventHandler(this.button5_Click);
            this.button8.Click += new System.EventHandler(this.button5_Click);
            this.button9.Click += new System.EventHandler(this.button5_Click);
            this.button10.Click += new System.EventHandler(this.button5_Click);
            this.button11.Click += new System.EventHandler(this.button5_Click);
            this.button12.Click += new System.EventHandler(this.button5_Click);
            this.button13.Click += new System.EventHandler(this.button5_Click);
            this.button14.Click += new System.EventHandler(this.button5_Click);
            this.button15.Click += new System.EventHandler(this.button5_Click);
            this.button16.Click += new System.EventHandler(this.button5_Click);
            this.button17.Click += new System.EventHandler(this.button5_Click);
            this.button18.Click += new System.EventHandler(this.button5_Click);
            this.button19.Click += new System.EventHandler(this.button5_Click);
            this.button20.Click += new System.EventHandler(this.button5_Click);
            this.button21.Click += new System.EventHandler(this.button5_Click);
            this.button22.Click += new System.EventHandler(this.button5_Click);
            this.button23.Click += new System.EventHandler(this.button5_Click);
            this.button24.Click += new System.EventHandler(this.button5_Click);
        }
    }
}
