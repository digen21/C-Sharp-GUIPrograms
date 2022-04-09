using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        double fnum;
        String op;
        public Form2()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form1 Mdiparent { get; set; }

        private void click(object sender, EventArgs e)
        {
			//	1.		creating object for selectd 1-9 0 and ".".......
			//	2.		for this first use grouo button and then select  buttons 1..9..0 and dot....
			//	3.		the double click on num1 button and rename button1_click to button_click...
			//	4.		you will see the the bulb option there when you put your cursor on that renamed name
			// 	5.		select on first option (rename button_Click....)
			//	6.		then go to form design of claculaot and go to event tab at the right side of proprerties.. 
			//	7.		click on click event and select "button_Click".....
			//	8.		then run with f5 and check all the buttons are working or not.....
			
            Button grp = (Button)sender;
            box.Text += grp.Text;
        }
        //private void button_Click(object sender, EventArgs e)
        //{
        //    Button group = (Button)sender;
        //    box.Text += group.Text; 
        //}

        private void multi_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToDouble(box.Text);
            box.Text = "";
            op = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToDouble(box.Text);
            box.Text = "";
            op = "*";
        }

        private void div_Click_1(object sender, EventArgs e)
        {
            //double                  displayname of Calculator
            

            fnum = Convert.ToDouble(box.Text);
            box.Text = "";
            op = "/";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToDouble(box.Text);
            box.Text = "";
            op = "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToDouble(box.Text);
            box.Text = "";
            op = "-";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToDouble(box.Text);
            box.Text = "";
            op = "%";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double res = 0;
            double snum;
            snum = Convert.ToDouble(box.Text);
            switch (op)
            {
                case "+":
                    res = (fnum + snum); break;
//--------------------------------------------------------------------------------------------                
                case "-":
                    res = (fnum + snum); break;
//--------------------------------------------------------------------------------------------
                case "*":
                    res = (fnum * snum); break;
//--------------------------------------------------------------------------------------------
                case "/":
                    if (snum == 0)
                    {
                        box.Text = "Can not be divided by zero...";
                    }
                    else
                    {
                        res = (fnum / snum);
                    }
                    break;
//--------------------------------------------------------------------------------------------
                case "%":
                    res = (fnum % snum); break; 
                    
            }
            //Declaring Result
            box.Text = res.ToString();

//--------------------------------------------------------------------------------------------
            //Using If - Else Condition

            //if (op == "+")
            //{
            //    res = (fnum + snum);
            //    box.Text = Convert.ToString(res);
            //    fnum = res;
            //}
            //if (op == "*")
            //{
            //    res = (fnum * snum);
            //    box.Text = Convert.ToString(res);
            //    res = fnum;
            //}
            //if (op == "/")
            //{
            //    if (snum == 0)
            //    {
            //        box.Text = "Can not be devided by zero...";
            //    }
            //    else
            //    {
            //        res = (fnum / snum);
            //        box.Text = Convert.ToString(res);
            //        fnum = res;
            //    }
            //}
            //if (op == "-")
            //{
            //    res = (fnum - snum);
            //    box.Text = Convert.ToString(res);
            //    fnum = res;
            //}
            //if (op == "%")
            //{
            //    res = (fnum % snum);
            //    box.Text = Convert.ToString(res);
            //    fnum = res;
            //}
        }

        private void clear_Click(object sender, EventArgs e)
        {

            //for clearing display
            box.Clear();
        }

     

    }
}
S
