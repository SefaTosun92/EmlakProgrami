
namespace EmlakProgrami
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMetrekare = new System.Windows.Forms.TextBox();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.comboBoxSatilikKiralik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOdaSayisi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNotlar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.comboBoxBlok = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDaireNo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonilkbahar = new System.Windows.Forms.Button();
            this.buttonYaz = new System.Windows.Forms.Button();
            this.buttonSonbahar = new System.Windows.Forms.Button();
            this.buttonKis = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDuzelt = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dairelerin Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Site:";
            // 
            // textBoxMetrekare
            // 
            this.textBoxMetrekare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMetrekare.Location = new System.Drawing.Point(176, 364);
            this.textBoxMetrekare.Name = "textBoxMetrekare";
            this.textBoxMetrekare.Size = new System.Drawing.Size(145, 20);
            this.textBoxMetrekare.TabIndex = 3;
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Items.AddRange(new object[] {
            "İlkbahar Sitesi",
            "Yaz Sitesi",
            "Sonbahar Sitesi",
            "Kış Sitesi"});
            this.comboBoxSite.Location = new System.Drawing.Point(176, 106);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSite.TabIndex = 4;
            this.comboBoxSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
            // 
            // comboBoxSatilikKiralik
            // 
            this.comboBoxSatilikKiralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSatilikKiralik.FormattingEnabled = true;
            this.comboBoxSatilikKiralik.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.comboBoxSatilikKiralik.Location = new System.Drawing.Point(176, 248);
            this.comboBoxSatilikKiralik.Name = "comboBoxSatilikKiralik";
            this.comboBoxSatilikKiralik.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSatilikKiralik.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Satılık/Kiralık:";
            // 
            // comboBoxOdaSayisi
            // 
            this.comboBoxOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOdaSayisi.FormattingEnabled = true;
            this.comboBoxOdaSayisi.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1"});
            this.comboBoxOdaSayisi.Location = new System.Drawing.Point(176, 306);
            this.comboBoxOdaSayisi.Name = "comboBoxOdaSayisi";
            this.comboBoxOdaSayisi.Size = new System.Drawing.Size(145, 21);
            this.comboBoxOdaSayisi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oda Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Metrekare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fiyat:";
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFiyat.Location = new System.Drawing.Point(176, 415);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(145, 20);
            this.textBoxFiyat.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(445, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Notlar:";
            // 
            // textBoxNotlar
            // 
            this.textBoxNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNotlar.Location = new System.Drawing.Point(608, 186);
            this.textBoxNotlar.Multiline = true;
            this.textBoxNotlar.Name = "textBoxNotlar";
            this.textBoxNotlar.Size = new System.Drawing.Size(145, 81);
            this.textBoxNotlar.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(445, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(445, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ad Soyad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(508, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "İletişim Bilgileri";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad.Location = new System.Drawing.Point(608, 77);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(145, 20);
            this.textBoxAdSoyad.TabIndex = 24;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTelefon.Location = new System.Drawing.Point(608, 128);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(145, 20);
            this.textBoxTelefon.TabIndex = 25;
            // 
            // comboBoxBlok
            // 
            this.comboBoxBlok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBlok.FormattingEnabled = true;
            this.comboBoxBlok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxBlok.Location = new System.Drawing.Point(176, 153);
            this.comboBoxBlok.Name = "comboBoxBlok";
            this.comboBoxBlok.Size = new System.Drawing.Size(145, 21);
            this.comboBoxBlok.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(13, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Blok:";
            // 
            // comboBoxDaireNo
            // 
            this.comboBoxDaireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDaireNo.FormattingEnabled = true;
            this.comboBoxDaireNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxDaireNo.Location = new System.Drawing.Point(176, 201);
            this.comboBoxDaireNo.Name = "comboBoxDaireNo";
            this.comboBoxDaireNo.Size = new System.Drawing.Size(145, 21);
            this.comboBoxDaireNo.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Daire No:";
            // 
            // buttonilkbahar
            // 
            this.buttonilkbahar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonilkbahar.Location = new System.Drawing.Point(800, 128);
            this.buttonilkbahar.Name = "buttonilkbahar";
            this.buttonilkbahar.Size = new System.Drawing.Size(138, 89);
            this.buttonilkbahar.TabIndex = 30;
            this.buttonilkbahar.Text = "İLKBAHAR";
            this.buttonilkbahar.UseVisualStyleBackColor = true;
            // 
            // buttonYaz
            // 
            this.buttonYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonYaz.Location = new System.Drawing.Point(941, 39);
            this.buttonYaz.Name = "buttonYaz";
            this.buttonYaz.Size = new System.Drawing.Size(138, 88);
            this.buttonYaz.TabIndex = 31;
            this.buttonYaz.Text = "YAZ";
            this.buttonYaz.UseVisualStyleBackColor = true;
            // 
            // buttonSonbahar
            // 
            this.buttonSonbahar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSonbahar.Location = new System.Drawing.Point(1083, 128);
            this.buttonSonbahar.Name = "buttonSonbahar";
            this.buttonSonbahar.Size = new System.Drawing.Size(138, 88);
            this.buttonSonbahar.TabIndex = 32;
            this.buttonSonbahar.Text = "SONBAHAR";
            this.buttonSonbahar.UseVisualStyleBackColor = true;
            // 
            // buttonKis
            // 
            this.buttonKis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonKis.Location = new System.Drawing.Point(941, 222);
            this.buttonKis.Name = "buttonKis";
            this.buttonKis.Size = new System.Drawing.Size(138, 88);
            this.buttonKis.TabIndex = 33;
            this.buttonKis.Text = "KIŞ";
            this.buttonKis.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(978, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "Site";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 446);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1189, 349);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Site";
            this.columnHeader10.Width = 82;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Blok";
            this.columnHeader11.Width = 43;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Daire No";
            this.columnHeader12.Width = 59;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Satılık/Kiralık";
            this.columnHeader13.Width = 74;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Oda Sayısı";
            this.columnHeader14.Width = 81;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Metrekare";
            this.columnHeader15.Width = 67;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Fiyat";
            this.columnHeader16.Width = 76;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ad Soyad";
            this.columnHeader17.Width = 115;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Telefon";
            this.columnHeader18.Width = 110;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Notlar";
            this.columnHeader19.Width = 101;
            // 
            // buttonGoruntule
            // 
            this.buttonGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonGoruntule.Location = new System.Drawing.Point(389, 332);
            this.buttonGoruntule.Name = "buttonGoruntule";
            this.buttonGoruntule.Size = new System.Drawing.Size(154, 89);
            this.buttonGoruntule.TabIndex = 36;
            this.buttonGoruntule.Text = "GÖRÜNTÜLE";
            this.buttonGoruntule.UseVisualStyleBackColor = true;
            this.buttonGoruntule.Click += new System.EventHandler(this.buttonGoruntule_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonKaydet.Location = new System.Drawing.Point(561, 332);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(154, 89);
            this.buttonKaydet.TabIndex = 37;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSil.Location = new System.Drawing.Point(731, 332);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(154, 89);
            this.buttonSil.TabIndex = 38;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDuzelt
            // 
            this.buttonDuzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonDuzelt.Location = new System.Drawing.Point(901, 332);
            this.buttonDuzelt.Name = "buttonDuzelt";
            this.buttonDuzelt.Size = new System.Drawing.Size(154, 89);
            this.buttonDuzelt.TabIndex = 39;
            this.buttonDuzelt.Text = "DÜZELT";
            this.buttonDuzelt.UseVisualStyleBackColor = true;
            this.buttonDuzelt.Click += new System.EventHandler(this.buttonDuzelt_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(13, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 25);
            this.label14.TabIndex = 41;
            this.label14.Text = "id:";
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxid.Location = new System.Drawing.Point(176, 62);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(145, 20);
            this.textBoxid.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1251, 807);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.buttonDuzelt);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonGoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonKis);
            this.Controls.Add(this.buttonSonbahar);
            this.Controls.Add(this.buttonYaz);
            this.Controls.Add(this.buttonilkbahar);
            this.Controls.Add(this.comboBoxDaireNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxBlok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNotlar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOdaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSatilikKiralik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSite);
            this.Controls.Add(this.textBoxMetrekare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Bilgi Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMetrekare;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.ComboBox comboBoxSatilikKiralik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOdaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNotlar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.ComboBox comboBoxBlok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDaireNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonilkbahar;
        private System.Windows.Forms.Button buttonYaz;
        private System.Windows.Forms.Button buttonSonbahar;
        private System.Windows.Forms.Button buttonKis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Button buttonGoruntule;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonDuzelt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxid;
    }
}