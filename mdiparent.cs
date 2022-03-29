//The MdiParent (Connecting Multiple Pages......)

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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connecting 1st Form
            Form2 ob1 = new Form2();
            ob1.Mdiparent = this;
            ob1.Show();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connecting 2nd Form
            sic ob2 = new sic();
            ob2.MdiParent = this;
            ob2.Show();
        }

        private void partCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //concting 3rd page
            tictac ob3 = new tictac();
            ob3.MdiParent = this;
            ob3.Show();
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction.....");
        }
    }
}
