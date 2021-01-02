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
    public partial class Form2 : Form
    {
        Form1 gec1 = new Form1();

        String ilkOyuncu;
        String ikinciOyuncu;

        public string ilkOyuncuBilgi
        {
            get { return ilkOyuncu; }
            set { ilkOyuncu = value; }
        }
        public string ikinciOyuncuBilgi
        {
            get { return ikinciOyuncu; }
            set { ilkOyuncu = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.ilkOyuncu = textBox1.Text;
            this.ikinciOyuncu = textBox3.Text;

            this.Hide();
        }
    }
}
