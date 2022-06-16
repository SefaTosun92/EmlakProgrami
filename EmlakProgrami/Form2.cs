using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmlakProgrami
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6BEODCN;Initial Catalog=Siteler;Integrated Security=True");

        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSite.Text =="Yaz Sitesi")
            {
                buttonYaz.BackColor = Color.Blue;
                buttonKis.BackColor = Color.Gray;
                buttonSonbahar.BackColor = Color.Gray;
                buttonilkbahar.BackColor = Color.Gray;
            }
            else if (comboBoxSite.Text == "Kış Sitesi")
            {
                buttonYaz.BackColor = Color.Gray;
                buttonKis.BackColor = Color.Blue;
                buttonSonbahar.BackColor = Color.Gray;
                buttonilkbahar.BackColor = Color.Gray;
            }
            else if (comboBoxSite.Text == "Sonbahar Sitesi")
            {
                buttonYaz.BackColor = Color.Gray;
                buttonKis.BackColor = Color.Gray;
                buttonSonbahar.BackColor = Color.Blue;
                buttonilkbahar.BackColor = Color.Gray;
            }
            else if (comboBoxSite.Text == "İlkbahar Sitesi")
            {
                buttonYaz.BackColor = Color.Gray;
                buttonKis.BackColor = Color.Gray;
                buttonSonbahar.BackColor = Color.Gray;
                buttonilkbahar.BackColor = Color.Blue;
            }

        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            VerileriGoruntule();
        }


        public void Temizle()
        {
            textBoxid.Clear();
            comboBoxSite.ResetText();
            comboBoxBlok.ResetText();
            comboBoxDaireNo.ResetText();
            comboBoxSatilikKiralik.ResetText();
            comboBoxOdaSayisi.ResetText();
            textBoxMetrekare.Clear();
            textBoxFiyat.Clear();
            textBoxAdSoyad.Clear();
            textBoxTelefon.Clear();
            textBoxNotlar.Clear();

        }




        public void VerileriGoruntule()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sitebilgi",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["daireno"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                ekle.SubItems.Add(oku["odasayisi"].ToString());
                ekle.SubItems.Add(oku["metrekare"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());

                listView1.Items.Add(ekle);
                
            }

            baglanti.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            VeriyiKaydet();
            Temizle();
            VerileriGoruntule();
        }

        public void VeriyiKaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sitebilgi (id,site,blok,daireno,satkira,odasayisi,metrekare,fiyat,adsoyad,telefon,notlar) Values ('"+textBoxid.Text.ToString()+"','"+comboBoxSite.Text.ToString()+"','"+comboBoxBlok.Text.ToString()+"','"+comboBoxDaireNo.Text.ToString()+"','"+comboBoxSatilikKiralik.Text.ToString()+"','"+comboBoxOdaSayisi.Text.ToString()+"','"+textBoxMetrekare.Text.ToString()+"','"+textBoxFiyat.Text.ToString()+"','"+textBoxAdSoyad.Text.ToString()+"','"+textBoxTelefon.Text.ToString()+"','"+textBoxNotlar.Text.ToString()+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            VeriyiSil();
            Temizle();
            VerileriGoruntule();
        }

        int id;
        public void VeriyiSil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sitebilgi where id=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            textBoxid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBoxSite.Text= listView1.SelectedItems[0].SubItems[1].Text;
            comboBoxBlok.Text= listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxDaireNo.Text= listView1.SelectedItems[0].SubItems[3].Text;
            comboBoxSatilikKiralik.Text= listView1.SelectedItems[0].SubItems[4].Text;
            comboBoxOdaSayisi.Text= listView1.SelectedItems[0].SubItems[5].Text;
            textBoxMetrekare.Text= listView1.SelectedItems[0].SubItems[6].Text;
            textBoxFiyat.Text= listView1.SelectedItems[0].SubItems[7].Text;
            textBoxAdSoyad.Text= listView1.SelectedItems[0].SubItems[8].Text;
            textBoxTelefon.Text= listView1.SelectedItems[0].SubItems[9].Text;
            textBoxNotlar.Text= listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void buttonDuzelt_Click(object sender, EventArgs e)
        {
            VeriyiDuzelt();
            Temizle();
            VerileriGoruntule();
        }

        public void VeriyiDuzelt()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update sitebilgi set id='"+textBoxid.Text.ToString()+ "',site='" + comboBoxSite.Text.ToString() + "',blok='" + comboBoxBlok.Text.ToString() + "',daireno='" + comboBoxDaireNo.Text.ToString() + "',satkira='" + comboBoxSatilikKiralik.Text.ToString() + "',odasayisi='" + comboBoxOdaSayisi.Text.ToString() + "',metrekare='" + textBoxMetrekare.Text.ToString() + "',fiyat='" + textBoxFiyat.Text.ToString() + "',adsoyad='" + textBoxAdSoyad.Text.ToString() + "',telefon='" + textBoxTelefon.Text.ToString() + "',notlar='" + textBoxNotlar.Text.ToString() + "' where id=" + id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
