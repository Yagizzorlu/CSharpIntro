using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 1 çalıştı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı");   //İşlem 1 e bastığımızda İşlem 1 çalıştı yazar. O an işlem 2 ye basınca İşlem 2 çalıştı yazmaz.
        }
    }
}
