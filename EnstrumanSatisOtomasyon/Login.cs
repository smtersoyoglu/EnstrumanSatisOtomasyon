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

namespace EnstrumanSatisOtomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96JC8IR;Initial Catalog=EnstrumanShpDb;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {
            KullanıcıTb.Text = "kullanici_adi";
            SifreTb.Text = "sifre";

            KullanıcıTb.Enabled = false;
            SifreTb.Enabled = false;
        }

        /*
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            KullanıcıTb.Text = "";
            SifreTb.Text = "";
        }
        */

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AdminTbl where AdminAdSoyad='"+KullanıcıTb.Text+"' and AdminSifre='"+SifreTb.Text+"'", baglanti );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Bilgi bil = new Bilgi();
                bil.Show();
                this.Hide();
                baglanti.Close();

            }else
            {
                MessageBox.Show("Hatalı Kullanıcı yada Şifre");

            }
            baglanti.Close();

        }


        private void btnSatısSayfaGit_Click(object sender, EventArgs e)
        {
            Satis sat = new Satis();
            sat.Show();
            this.Hide();
        }
    }
}
