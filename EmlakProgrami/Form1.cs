using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciAdi.Text == "admin" || textBoxKullaniciAdi.Text == "sefa") 
            {
                if (textBoxSifre.Text=="1905")
                {
                    MessageBox.Show("Sisteme giriş başarılı!","HOŞGELDİNİZ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Form2 emlakKayit = new Form2();
                    this.Hide();
                    emlakKayit.Show();

                }
                else
                {
                    MessageBox.Show("Şifre yanlış. Tekrar deneyiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı sistemde bulunmuyor. Tekrar deneyiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
