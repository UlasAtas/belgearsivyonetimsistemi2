using MySql.Data.MySqlClient;
using ProjeBütSon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeBütSon.FORMLAR
{
    public partial class FakulteSKsorgu : Form
    {
        public FakulteSKsorgu()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GİRİS giris = new GİRİS();
            this.Hide();
            giris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("select * from admin", new dbBaglanti().baglantiGetir());
            MySqlDataReader reader = command.ExecuteReader();
            bool sonuc = false;

            while (reader.Read())
            {
                if (reader[1].ToString().Trim() == Kullanıciaditxt.Text && reader[2].ToString().Trim() == sifretxt.Text)
                {
                    sonuc = true;
                    KullaniciKayitEkrani ke = new KullaniciKayitEkrani();
                    this.Hide();
                    ke.Show();
                    break;
                }

            }

            if (sonuc)
            {
                sonuc = false;
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
        }

        
    }
}
