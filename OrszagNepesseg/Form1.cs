using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OrszagNepesseg
{
    public partial class Form1 : Form
    {
        List<Orszag> orszags = new List<Orszag>();

        public Form1()
        {
            InitializeComponent();
        }

        private void mKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mFajl_Click(object sender, EventArgs e)
        {
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                lbAdatok.Items.Clear();
                using (StreamReader sr = new StreamReader(ofdMegnyitas.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        orszags.Add(new Orszag(sr.ReadLine(), Convert.ToInt32(sr.ReadLine()), sr.ReadLine()));
                    }
                }

                foreach (var orszag in orszags)
                {
                    lbAdatok.Items.Add(orszag.ToString());
                }
            }
        }

        private void btnMegszamol_Click(object sender, EventArgs e)
        {
            if (rbTobb.Checked)
            {

            }
            else
            {

            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rbTobb.Checked = true;
        }
    }
}
