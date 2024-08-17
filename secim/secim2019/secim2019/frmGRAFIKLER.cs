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

namespace secim2019
{
    public partial class frmGRAFIKLER : Form
    {
        public frmGRAFIKLER()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T11FMIO;Initial Catalog=secim2019udemy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void frmGRAFIKLER_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select ilcead from tblilce",baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select SUM(hiper),SUM(süper),SUM(ultrasüper),SUM(extraparti),SUM(exstrasuper) from tblilce",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["partiler"].Points.AddXY("hiper parti",dr2[0]);
                chart1.Series["partiler"].Points.AddXY("süper parti", dr2[1]);
                chart1.Series["partiler"].Points.AddXY("ultrasüper parti", dr2[2]);
                chart1.Series["partiler"].Points.AddXY("exstra parti", dr2[3]);
                chart1.Series["partiler"].Points.AddXY("exstrasüper parti", dr2[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cm = new SqlCommand("select * from tblilce where ilcead=@P1",baglanti);
            cm.Parameters.AddWithValue("@P1",comboBox1.Text);
            SqlDataReader r = cm.ExecuteReader();   
            while (r.Read())
            {
                pb1.Value = int.Parse(r[2].ToString());
                pb2.Value = int.Parse(r[3].ToString());
                pb3.Value = int.Parse(r[4].ToString());
                pb4.Value = int.Parse(r[5].ToString());
                pb5.Value = int.Parse(r[6].ToString());

                lblhiper.Text = r[2].ToString();
                lblsuper.Text = r[3].ToString();
                lblultrasuper.Text = r[4].ToString();
                lblekstra.Text = r[5].ToString();
                lblextrasuper.Text = r[6].ToString();
            }
            baglanti.Close();
        }
    }
}
