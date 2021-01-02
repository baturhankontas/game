using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                Form2 gecisyap = new Form2();
                this.Hide();
                gecisyap.Show();
            }
            if (radioButton2.Checked)
            {
                Form2 gecisyap = new Form2();
                this.Hide();
                gecisyap.Show();
            }
            /*else
            { MessageBox.Show("Click only one radio button"); }*/


        }
        public void goster() 
        {
            groupBox1.Visible=false;
            groupBox2.Visible=true;
        }

        
    }
}
