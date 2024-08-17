using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace secim2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T11FMIO;Initial Catalog=secim2019udemy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void btnoygiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tblilce(ilcead,hiper,süper,ultrasüper,extraparti,exstrasuper) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            cmd.Parameters.AddWithValue("@P1", txtilcead.Text);
            cmd.Parameters.AddWithValue("@P2", txthiper.Text);
            cmd.Parameters.AddWithValue("@P3", txtsuper.Text);
            cmd.Parameters.AddWithValue("@P4", txtultrasuper.Text);
            cmd.Parameters.AddWithValue("@P5", txtextra.Text);
            cmd.Parameters.AddWithValue("@P6", txtekstrasuper.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("islem basarılı");
            baglanti.Close();
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            frmGRAFIKLER frmGRAFIKLER = new frmGRAFIKLER();
            frmGRAFIKLER.Show();
        }
    }
}
