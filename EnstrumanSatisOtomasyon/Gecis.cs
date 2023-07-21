using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnstrumanSatisOtomasyon
{
    public partial class Gecis : Form
    {
        public Gecis()
        {
            InitializeComponent();
        }

        int baslangic = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            baslangic += 10;
            LoadingPB.Value = baslangic;
            YuzdeLbl.Text = baslangic + "%";
            if(LoadingPB.Value ==100)
            {
                LoadingPB.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
                log.Show();
            }

        }

 
        private void Gecis_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
