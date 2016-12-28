using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame21
{
    public partial class PopupAce : Form
    {
        

        public PopupAce()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.GetValues.aceValue = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.GetValues.aceValue = 11;
            this.Close();
        }
    }
}
