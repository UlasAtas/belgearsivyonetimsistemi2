using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeBütSon.FORMLAR
{
    public partial class ANAMENU : Form
    {
        public ANAMENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sinavEvraklari form = new sinavEvraklari();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            muhasebeEvraklari form = new muhasebeEvraklari();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personelEvraklari form = new personelEvraklari();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bolumEvraklari form = new bolumEvraklari();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KayitliEmanetler form = new KayitliEmanetler();
            form.Show();
            this.Hide();
        }
    }
}
