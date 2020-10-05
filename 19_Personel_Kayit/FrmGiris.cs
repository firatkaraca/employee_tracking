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

namespace _19_Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8NNOKBJ\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici Where KullaniciAd=@p1 and Sifre=@p2 and Yetki=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p3", checkBox2.Checked);
            
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (checkBox2.Checked == true)
                { 
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                    this.Hide();
                }
                if (checkBox2.Checked == false)
                {
                    FrmNormalKullanici frn = new FrmNormalKullanici();
                    frn.Show();
                    this.Hide();
                }
            }
            else
            {

                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }
            baglanti.Close();
        }

        private void BtnKaydol_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komutkaydol = new SqlCommand("Insert into Tbl_Yonetici (KullaniciAd,Sifre,isim,soyisim,yetki) values (@k1,@k2,@k3,@k4,@k5)", baglanti);
            komutkaydol.Parameters.AddWithValue("@k1", txtkadi.Text);
            komutkaydol.Parameters.AddWithValue("@k2", txtsfr.Text);
            komutkaydol.Parameters.AddWithValue("@k3", txtisim.Text);
            komutkaydol.Parameters.AddWithValue("@k4", txtsoyisim.Text);
            komutkaydol.Parameters.AddWithValue("@k5", label8.Text);
            komutkaydol.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt eklendi");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                label8.Text = "True";
            }
            else
            {
                label8.Text = "False";
            }
        }
    }
}
