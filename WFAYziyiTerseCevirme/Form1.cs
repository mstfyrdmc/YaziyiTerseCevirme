using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAYziyiTerseCevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            lblGoster.Text = null;
            if (!String.IsNullOrEmpty(txtMetin.Text))
            {
                string metin = txtMetin.Text;

                for (int i = metin.Length - 1; i >= 0; i--)
                {

                    lblGoster.Text += metin[i];
                }
            }
            else {
                lblGoster.Text = "Lütfen Boş bırakmayınız!";
                
            }
            //lblGoster.Text = null;
        }
    }
}
