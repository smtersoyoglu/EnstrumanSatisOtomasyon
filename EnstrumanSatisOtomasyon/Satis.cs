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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96JC8IR;Initial Catalog=EnstrumanShpDb;Integrated Security=True");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select EnsAd, EnsUcret from EnstrümanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BilgiDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void MarkaFilter()
        {   // markaları filtrelemek için parametre yazdım.
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96JC8IR;Initial Catalog=EnstrumanShpDb;Integrated Security=True"))
            {
                baglanti.Open();
                string query = "select EnsAd, EnsUcret from EnstrümanTbl where EnsMarka = @Marka";
                SqlCommand command = new SqlCommand(query, baglanti);
                command.Parameters.AddWithValue("@Marka", MarkaFilterCb.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(command);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BilgiDGV.DataSource = ds.Tables[0];
            }
        }


        private void Satis_Load(object sender, EventArgs e)
        {

            BilgiDGV.EnableHeadersVisualStyles = false;
            BilgiDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            BilgiDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumOrchid;
            BilgiDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);


            SatisFaturaDGV.EnableHeadersVisualStyles = false;
            SatisFaturaDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            SatisFaturaDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumOrchid;
            SatisFaturaDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            BilgiDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            BilgiDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uyeler();

        }


        private void BilgiDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BilgiDGV.Rows[e.RowIndex].Selected = true;

                // Seçilen satırdaki verileri TextBox'lara aktar
                EnsAdTb.Text = BilgiDGV.SelectedRows[0].Cells["EnsAd"].Value.ToString();
                EnsUcretTb.Text = BilgiDGV.SelectedRows[0].Cells["EnsUcret"].Value.ToString();
                // Diğer verileri de TextBox'lara aktarabilirsiniz
            }
        }

        private void MarkaFilterCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MarkaFilter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Geri Butonu
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnsAdTb.Text = "";
            EnsMiktarTb.Text = "";
            EnsUcretTb.Text = "";
        }
        private void insertFatura()
        {
            string Bugun;
            Bugun = DateTime.Today.Date.ToString();
            try
            {
                baglanti.Open();
                string query = "insert into FaturaTbl values("+TutarToplam+",'"+Bugun+"')";

                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Fatura Başarıyla Eklendi");
                baglanti.Close();
                uyeler();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }



        int n = 0;
        int TutarToplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(EnsAdTb.Text == "" || EnsMiktarTb.Text == "" || EnsUcretTb.Text == "")
            {
                MessageBox.Show("Enstrüman seçiniz ve miktarını giriniz");

            }else
            {
                int toplam = Convert.ToInt32(EnsMiktarTb.Text)* Convert.ToInt32(EnsUcretTb.Text);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(SatisFaturaDGV);
                row.Cells[0].Value = n + 1;
                row.Cells[1].Value = EnsAdTb.Text;
                row.Cells[2].Value = EnsUcretTb.Text;
                row.Cells[3].Value = EnsMiktarTb.Text;
                row.Cells[4].Value = toplam;

                SatisFaturaDGV.Rows.Add(row);
                n++;

                TutarToplam = TutarToplam + toplam;
                UcretLbl.Text = "" + TutarToplam;
            }
        }


        int ensid, ensmiktar, ensucret, toplam, pos = 60;

        private void SatisCikisLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string ensad;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Samet Müzik Mağazası" , new Font("Times New Roman",12,FontStyle.Bold),Brushes.DarkBlue, new Point(50));
            e.Graphics.DrawString("ID ENSTRÜMAN ÜCRET MİKTAR TOPLAM", new Font("Times New Roman", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(5, 20));

            foreach(DataGridViewRow row in SatisFaturaDGV.Rows)
            {
                ensid = Convert.ToInt32(row.Cells["Column1"].Value);
                ensad = "" + row.Cells["Column2"].Value;
                ensucret = Convert.ToInt32(row.Cells["Column3"].Value);
                ensmiktar = Convert.ToInt32(row.Cells["Column4"].Value);
                toplam = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString(""+ensid, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.DarkOrange, new Point(8, pos));

                e.Graphics.DrawString(""+ensad, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.DarkOrange, new Point(25, pos));

                e.Graphics.DrawString("" + ensucret, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.DarkOrange, new Point(135, pos));

                e.Graphics.DrawString("" + ensmiktar, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.DarkOrange, new Point(190, pos));

                e.Graphics.DrawString("" + toplam, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.DarkOrange, new Point(250, pos));

                pos = pos + 20;

            }
            e.Graphics.DrawString("Toplam Tutar :" +TutarToplam, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(60, 200));

            e.Graphics.DrawString("***Müzik Enstrümanı Satış Mağazası Fatura***", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkBlue, new Point(20,230));

        }

        private void YazdırBtn_Click(object sender, EventArgs e)
        {

            // fatura boyutlandırması
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 300, 500);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            insertFatura();
        }
    }
}
