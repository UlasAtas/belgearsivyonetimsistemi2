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
    public partial class sinavEvraklari : Form
    {
        public sinavEvraklari()
        {
            InitializeComponent();
        }

        public void listele()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from Sinav_Tablo", new dbBaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void sinavEvraklari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDBDataSet1.Sinav_Tablo' table. You can move, or remove it, as needed.
            //this.sinav_TabloTableAdapter.Fill(this.projeDBDataSet1.Sinav_Tablo);
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ANAMENU form = new ANAMENU();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz");
            }

            else
            {
                new sinavSERVİCE().SinavKaydetS(textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);
                listele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz");
            }

            else
            {

                new sinavSERVİCE().SinavGuncelleS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox2.Text, textBox3.Text,textBox5.Text,textBox4.Text);
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new sinavSERVİCE().SinavSilS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox2.Text, textBox3.Text,textBox5.Text,textBox4.Text);
            MessageBox.Show("silme başarılı");
            listele();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Sinav_Tablo where belgeid like '" + textBox1.Text + "%' or dersAD like '" + textBox1.Text + "%' or ogrenciNUMARA like '" + textBox1.Text + "%' or ogrenciAD like'" + textBox1.Text + "%' or ogrenciNOT like'" + textBox1.Text + "%' ", (new dbBaglanti()).baglantiGetir());
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox8.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz");
            }
            else
            {
                new emanetSERVİCE().EmanetKaydetS(dataGridView1.CurrentRow.Cells[1].Value.ToString(), textBox7.Text, textBox8.Text, textBox6.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("emanet verildi");
            }
        }
    }
}
