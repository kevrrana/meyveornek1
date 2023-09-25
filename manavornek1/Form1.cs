using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manavornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMeyveler_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Add(txtMeyveler.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Clear();
        }

        private void btnSeçileniSil_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Remove(lstSepet.SelectedItem);        }
    }
}
