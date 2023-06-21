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
using MySql.Data.MySqlClient;

namespace ProjeBütSon.FORMLAR
{
    public partial class personelEvraklari : Form
    {
        public personelEvraklari()
        {
            InitializeComponent();
        }

        public void listele()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from Personel_Tablo", new dbBaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void personelEvraklari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDBDataSet1.Personel_Tablo' table. You can move, or remove it, as needed.
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
            new personelSERVİCE().PersonelKaydetS(textBox2.Text, textBox3.Text, textBox4.Text);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("boş alamları doldurunuz");
            }

            else
            {

                new personelSERVİCE().PersonelGuncelleS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox2.Text, textBox3.Text, textBox4.Text);
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                new personelSERVİCE().PersonelSilS(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("silme başarılı");
                listele();
            
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Personel_Tablo where personelİD like '" + textBox1.Text + "%' or personelAD like '" + textBox1.Text + "%' or personelTELNO like '" + textBox1.Text + "%' or personelGOREV like'" + textBox1.Text + "%' ", (new dbBaglanti()).baglantiGetir());
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new emanetSERVİCE().EmanetKaydetS( dataGridView1.CurrentRow.Cells[1].Value.ToString(), textBox6.Text,textBox8.Text, textBox5.Text,dataGridView1.CurrentRow.Cells[0].Value.ToString());

        }
    }
}
