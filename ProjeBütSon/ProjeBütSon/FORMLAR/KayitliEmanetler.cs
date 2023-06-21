using ProjeBütSon.DAL;
using ProjeBütSon.SERVİCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace ProjeBütSon.FORMLAR
{
    public partial class KayitliEmanetler : Form
    {
        public KayitliEmanetler()
        {
            InitializeComponent();
        }

        public void listele()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from emanetci2", new dbBaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ANAMENU form = new ANAMENU();
            form.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new emanetSERVİCE().EmanetSilS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),textBox2.Text,textBox3.Text, textBox4.Text,textBox5.Text,textBox6.Text);
            MessageBox.Show("silme başarılı");
            listele();
        }

        private void KayitliEmanetler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDBDataSet4.Emanet_Tablo' table. You can move, or remove it, as needed.
            //this.emanet_TabloTableAdapter2.Fill(this.projeDBDataSet4.Emanet_Tablo);
            // TODO: This line of code loads data into the 'projeDBDataSet3.Emanet_Tablo' table. You can move, or remove it, as needed.
            //this.emanet_TabloTableAdapter1.Fill(this.projeDBDataSet3.Emanet_Tablo);
            // TODO: This line of code loads data into the 'projeDBDataSet1.Muhasebe_Tablo' table. You can move, or remove it, as needed.
            //this.muhasebe_TabloTableAdapter.Fill(this.projeDBDataSet1.Muhasebe_Tablo);
            // TODO: This line of code loads data into the 'projeDBDataSet2.Emanet_Tablo' table. You can move, or remove it, as needed.
            listele();

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from emanetci2 where id like '" + textBox1.Text + "%' or evrakaciklama like '" + textBox1.Text + "%' or emanetciad like '" + textBox1.Text + "%'  or emanetcisoyad like '"+ textBox1.Text + "%' or emanetcitelno like '" + textBox1.Text + "%' or evrakid like '" + textBox1.Text + "%' ", (new dbBaglanti()).baglantiGetir());
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
