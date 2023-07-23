using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                double a ,b,c,d;
                string num1 = textBox1.Text.Trim();
                string num2 = textBox2.Text.Trim();

                string[] num1plus = num1.Split('+');
                string[] num1minus = num1.Split('-');
                if(num1plus.Length>1)
                {
                    
                    a = double.Parse(num1plus[0]);
                    string bvalue = num1plus[1];
                    string[] secondPart = bvalue.Split('i');
                    b = double.Parse(secondPart[0]);
                }
                else
                {
                    if(num1minus.Length==3) {
                        a = int.Parse(num1minus[1]);
                        a = a * -1;
                        string bvalue = num1minus[2];
                        string[] secondPart = bvalue.Split('i');
                        b = double.Parse(secondPart[0]);
                        b = b * -1;
                    }
                    else
                    {
                        a = int.Parse(num1minus[0]);
                        
                        string bvalue = num1minus[1];
                        string[] secondPart = bvalue.Split('i');
                        b = double.Parse(secondPart[0]);
                        b = b * -1;
                    }
                   
                }

                string[] num2plus = num2.Split('+');
                string[] num2minus = num2.Split('-');
                if (num2plus.Length > 1)
                {
                    c = int.Parse(num2plus[0]);
                    string bvalue = num2plus[1];
                    string[] secondPart = bvalue.Split('i');
                    d = double.Parse(secondPart[0]);
                }
                else
                {
                    if (num2minus.Length == 3)
                    {
                        c = double.Parse(num2minus[1]);
                        c = c * -1;
                        string bvalue = num2minus[2];
                        string[] secondPart = bvalue.Split('i');
                        d = double.Parse(secondPart[0]);
                        d = d * -1;
                    }
                    else
                    {
                        c = double.Parse(num2minus[0]);
                        string bvalue = num2minus[1];
                        string[] secondPart = bvalue.Split('i');
                        d = double.Parse(secondPart[0]);
                        d = d * -1;
                    }
                    
                }
                double realSum = a + c;
                double imagniarySum = b + d;
                string sign = "+";
                
                string result= realSum.ToString() + sign + imagniarySum.ToString()+"i";
                textBox3.Text = result;
               
            }
        }
        // this is the negative button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                double a, b, c, d;
                string num1 = textBox1.Text.Trim();
                string num2 = textBox2.Text.Trim();

                string[] num1plus = num1.Split('+');
                string[] num1minus = num1.Split('-');
                if (num1plus.Length > 1)
                {

                    a = double.Parse(num1plus[0]);
                    string bvalue = num1plus[1];
                    string[] secondPart = bvalue.Split('i');
                    b = double.Parse(secondPart[0]);
                }
                else
                {
                    if (num1minus.Length == 3)
                    {
                        a = int.Parse(num1minus[1]);
                        a = a * -1;
                        string bvalue = num1minus[2];
                        string[] secondPart = bvalue.Split('i');
                        b = double.Parse(secondPart[0]);
                        b = b * -1;
                    }
                    else
                    {
                        a = int.Parse(num1minus[0]);

                        string bvalue = num1minus[1];
                        string[] secondPart = bvalue.Split('i');
                        b = double.Parse(secondPart[0]);
                        b = b * -1;
                    }

                }

                string[] num2plus = num2.Split('+');
                string[] num2minus = num2.Split('-');
                if (num2plus.Length > 1)
                {
                    c = int.Parse(num2plus[0]);
                    string bvalue = num2plus[1];
                    string[] secondPart = bvalue.Split('i');
                    d = double.Parse(secondPart[0]);
                }
                else
                {
                    if (num2minus.Length == 3)
                    {
                        c = double.Parse(num2minus[1]);
                        c = c * -1;
                        string bvalue = num2minus[2];
                        string[] secondPart = bvalue.Split('i');
                        d = double.Parse(secondPart[0]);
                        d = d * -1;
                    }
                    else
                    {
                        c = double.Parse(num2minus[0]);
                        string bvalue = num2minus[1];
                        string[] secondPart = bvalue.Split('i');
                        d = double.Parse(secondPart[0]);
                        d = d * -1;
                    }

                }
                double realSum = a - c;
                double imagniarySum = b - d;
                string sign = "+";
                
                string result = realSum.ToString() + sign + imagniarySum.ToString() + "i";
                textBox3.Text = result;





            }
        }
    }
}
