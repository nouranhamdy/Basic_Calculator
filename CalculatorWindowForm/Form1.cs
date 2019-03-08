using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal n1,n2,result;
        char op;
        Boolean operated = false;
        private void numbers(object sender, EventArgs e)
        {
            Button numbtn = (Button)sender;
            //if (operated)
            //    n2 = decimal.Parse(window.Text);
            if (window.Text == "0" || !string.IsNullOrEmpty(window.Text) &&op==null )
                window.Clear();
            if (operated == true)
                window.Clear();
            window.Text += numbtn.Text;             
            operated = false;
            
        }

        private void oper(object sender, EventArgs e)
        {
            Button operbtn = (Button)sender;
            if (!string.IsNullOrEmpty(window.Text))
            {

                n1 = decimal.Parse(window.Text);
                switch (operbtn.Text)
                {
                    case "+":
                        op = '+';
                        break;
                    case "-":
                        op = '-';
                        break;
                    case "*":
                        op = '*';
                        break;
                    case "/":
                        op = '/';
                        break;
                }
                operated = true;
            }
        }

        private void clearbtn(object sender, EventArgs e)
        {
            window.Clear();
        }

        private void window_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            window.Text = "0";
        }

        private void decbtn_Click(object sender, EventArgs e)
        {
            Button decbtn = (Button)sender;
            window.Text += decbtn.Text;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            n2= decimal.Parse(window.Text);
            //result=0;
            switch (op)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 /n2;
                    break;
            }
            window.Text = result.ToString();
        }
    }
}
