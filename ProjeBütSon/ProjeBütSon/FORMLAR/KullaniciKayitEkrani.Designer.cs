namespace ProjeBütSon.FORMLAR
{
    partial class KullaniciKayitEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kullaniciTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDBDataSet1 = new ProjeBütSon.ProjeDBDataSet1();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gorevtxt = new System.Windows.Forms.TextBox();
            this.sifretxt2 = new System.Windows.Forms.TextBox();
            this.Kullaniciaditxt2 = new System.Windows.Forms.TextBox();
            this.kullanici_TabloTableAdapter = new ProjeBütSon.ProjeDBDataSet1TableAdapters.Kullanici_TabloTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 21;
            this.button3.Text = "sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kullaniciTabloBindingSource
            // 
            this.kullaniciTabloBindingSource.DataMember = "Kullanici_Tablo";
            this.kullaniciTabloBindingSource.DataSource = this.projeDBDataSet1;
            // 
            // projeDBDataSet1
            // 
            this.projeDBDataSet1.DataSetName = "ProjeDBDataSet1";
            this.projeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(178, 362);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 16);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Geri Don";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "görevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı adı";
            // 
            // gorevtxt
            // 
            this.gorevtxt.Location = new System.Drawing.Point(145, 208);
            this.gorevtxt.Name = "gorevtxt";
            this.gorevtxt.Size = new System.Drawing.Size(181, 22);
            this.gorevtxt.TabIndex = 13;
            // 
            // sifretxt2
            // 
            this.sifretxt2.Location = new System.Drawing.Point(147, 136);
            this.sifretxt2.Name = "sifretxt2";
            this.sifretxt2.Size = new System.Drawing.Size(181, 22);
            this.sifretxt2.TabIndex = 12;
            // 
            // Kullaniciaditxt2
            // 
            this.Kullaniciaditxt2.Location = new System.Drawing.Point(147, 72);
            this.Kullaniciaditxt2.Name = "Kullaniciaditxt2";
            this.Kullaniciaditxt2.Size = new System.Drawing.Size(181, 22);
            this.Kullaniciaditxt2.TabIndex = 11;
            // 
            // kullanici_TabloTableAdapter
            // 
            this.kullanici_TabloTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 306);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KullaniciKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gorevtxt);
            this.Controls.Add(this.sifretxt2);
            this.Controls.Add(this.Kullaniciaditxt2);
            this.Name = "KullaniciKayitEkrani";
            this.Text = "KullaniciKayitEkrani";
            this.Load += new System.EventHandler(this.KullaniciKayitEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gorevtxt;
        private System.Windows.Forms.TextBox sifretxt2;
        private System.Windows.Forms.TextBox Kullaniciaditxt2;
        private ProjeDBDataSet1 projeDBDataSet1;
        private System.Windows.Forms.BindingSource kullaniciTabloBindingSource;
        private ProjeDBDataSet1TableAdapters.Kullanici_TabloTableAdapter kullanici_TabloTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}