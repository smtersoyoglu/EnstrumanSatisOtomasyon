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


namespace EnstrumanSatisOtomasyon
{
    public partial class Bilgi : Form
    {
        public Bilgi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96JC8IR;Initial Catalog=EnstrumanShpDb;Integrated Security=True");
        private void Bilgi_Load(object sender, EventArgs e)
        {
           
            BilgiDGV.EnableHeadersVisualStyles = false;
            BilgiDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            BilgiDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumOrchid;
            BilgiDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            uyeler();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "" || EnsUcretTb.Text == "" || EnsMiktarTb.Text == "") 
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query= "insert into EnstrümanTbl values ('"+EnsAdTb.Text+"','"+EnsMarkaCb.SelectedItem.ToString()+"',"+EnsMiktarTb.Text+","+EnsUcretTb.Text+",'"+EnsKateCb.SelectedItem.ToString()+"')";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Enstrüman Başarıyla Eklendi");
                    baglanti.Close();
                    uyeler();

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from EnstrümanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BilgiDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        /*
        private void MarkaFilter()
        {
            baglanti.Open();
            string query = "select * from EnstrümanTbl where EnsMarka= '"+MarkaFilterCb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BilgiDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        */
        private void MarkaFilter()
        {   // markaları filtrelemek için parametre yazdım.
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96JC8IR;Initial Catalog=EnstrumanShpDb;Integrated Security=True"))
            {
                baglanti.Open();
                string query = "select * from EnstrümanTbl where EnsMarka = @Marka";
                SqlCommand command = new SqlCommand(query, baglanti);
                command.Parameters.AddWithValue("@Marka", MarkaFilterCb.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(command);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BilgiDGV.DataSource = ds.Tables[0];
            }
        }

        private void BilgiCikisLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int EnsKey;
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "")
            {
                MessageBox.Show("Silinecek Enstrümanı Seçiniz");

            }
            else
            {
                EnsKey = Convert.ToInt32(BilgiDGV.SelectedRows[0].Cells[0].Value.ToString());
                try
                {
                    baglanti.Open();
                    string query = " delete from EnstrümanTbl where EnsId="+EnsKey+"";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Enstrüman Başarıyla Silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        /*
        private void BilgiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnsKey = Convert.ToInt32(BilgiDGV.SelectedRows[0].Cells[0].Value.ToString());
            EnsAdTb.Text = BilgiDGV.SelectedRows[0].Cells[1].Value.ToString();
            EnsMarkaCb.Text = BilgiDGV.SelectedRows[0].Cells[2].Value.ToString();
            EnsMiktarTb.Text = BilgiDGV.SelectedRows[0].Cells[3].Value.ToString();
            EnsUcretTb.Text = BilgiDGV.SelectedRows[0].Cells[4].Value.ToString();
            EnsKateCb.Text = BilgiDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
        */

        private void BilgiDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            EnsKey = Convert.ToInt32(BilgiDGV.SelectedRows[0].Cells[0].Value.ToString());
            EnsAdTb.Text = BilgiDGV.SelectedRows[0].Cells[1].Value.ToString();
            EnsMarkaCb.Text = BilgiDGV.SelectedRows[0].Cells[2].Value.ToString();
            EnsMiktarTb.Text = BilgiDGV.SelectedRows[0].Cells[3].Value.ToString();
            EnsUcretTb.Text = BilgiDGV.SelectedRows[0].Cells[4].Value.ToString();
            EnsKateCb.Text = BilgiDGV.SelectedRows[0].Cells[5].Value.ToString();
            */
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BilgiDGV.Rows[e.RowIndex];

                EnsKey = Convert.ToInt32(row.Cells[0].Value.ToString());
                EnsAdTb.Text = row.Cells[1].Value.ToString();
                EnsMarkaCb.Text = row.Cells[2].Value.ToString();
                EnsMiktarTb.Text = row.Cells[3].Value.ToString();
                EnsUcretTb.Text = row.Cells[4].Value.ToString();
                EnsKateCb.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "" || EnsUcretTb.Text == "" || EnsMiktarTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update EnstrümanTbl set EnsAd='" + EnsAdTb.Text + "',EnsMarka='" + EnsMarkaCb.SelectedItem.ToString() + "',EnsMiktar=" + EnsMiktarTb.Text + ",EnsUcret=" + EnsUcretTb.Text + ",EnsKategori='" + EnsKateCb.SelectedItem.ToString() + "' where  EnsId=" + EnsKey + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Enstrüman Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();




                }catch(Exception Ex)
                {
                    MessageBox.Show("Ex.message");
                }
            }


        }

        private void MarkaFilterCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MarkaFilter();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
