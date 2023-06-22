using MySql.Data.MySqlClient;
using ProjeBütSon.DAL;
using ProjeBütSon.SERVİCE;
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
    public partial class KullaniciKayitEkrani : Form
    {
        public KullaniciKayitEkrani()
        {
            InitializeComponent();
        }

        public void listele()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from kullanicilar2", new dbBaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void KullaniciKayitEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDBDataSet1.Kullanici_Tablo' table. You can move, or remove it, as needed.
            //this.kullanici_TabloTableAdapter.Fill(this.projeDBDataSet1.Kullanici_Tablo);
            listele();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GİRİS form = new GİRİS();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Kullaniciaditxt2.Text == "" || sifretxt2.Text == "" || gorevtxt.Text == "")
            {
                MessageBox.Show("tüm alanları doldurunuz");
            }

            else
            {
                new kullaniciSERVİCE().kullaniciKaydet(Kullaniciaditxt2.Text, sifretxt2.Text, gorevtxt.Text);
                MessageBox.Show("kayıt başarılı");                
                listele();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Kullaniciaditxt2.Text == "" || sifretxt2.Text == "" || gorevtxt.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz");
            }

            else
            {

                new kullaniciSERVİCE().kullaniciGuncelle(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Kullaniciaditxt2.Text, sifretxt2.Text, gorevtxt.Text);
                MessageBox.Show("güncelleme başarılı");
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new kullaniciSERVİCE().kullaniciSil(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Kullaniciaditxt2.Text, sifretxt2.Text, gorevtxt.Text);
            MessageBox.Show("silme başarılı");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kullaniciaditxt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sifretxt2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gorevtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        
    }
}
