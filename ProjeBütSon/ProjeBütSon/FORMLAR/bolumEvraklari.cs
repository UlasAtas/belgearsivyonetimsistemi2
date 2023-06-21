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
    public partial class bolumEvraklari : Form
    {
        public bolumEvraklari()
        {
            InitializeComponent();
        }

        public void listele()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from Bolum_Tablo", new dbBaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void bolumEvraklari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDBDataSet1.Bolum_Tablo' table. You can move, or remove it, as needed.
            listele();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ANAMENU form = new ANAMENU();
            form.Show();
            this.Close();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Bolum_Tablo where id like '" + textBox1.Text + "%' or bolumAD like '" + textBox1.Text + "%' or bolumdekan like '" + textBox1.Text + "%' ", (new dbBaglanti()).baglantiGetir());
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
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new emanetSERVİCE().EmanetKaydetS( dataGridView1.CurrentRow.Cells[1].Value.ToString(), textBox9.Text,textBox4.Text, textBox8.Text,dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new bolumSERVİCE().BolumKaydetS(textBox2.Text, textBox3.Text);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("boş alamları doldurunuz");
            }

            else
            {

                new bolumSERVİCE().BolumGuncelleS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox2.Text, textBox3.Text);
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new bolumSERVİCE().BolumSilS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox2.Text, textBox3.Text);
            MessageBox.Show("silme başarılı");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
