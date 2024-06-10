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

namespace HastaneYonetim
{
    public partial class FrmDoctorEditDetails : Form
    {
        public FrmDoctorEditDetails()
        {
            InitializeComponent();
        }

        SqlMyConnection conn = new SqlMyConnection();

        public string nationalId;

        private void FrmDoctorEditDetails_Load(object sender, EventArgs e)
        {
            MskNationalId.Text = nationalId;

            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDOKTORLAR WHERE DoktorTC=@p1", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1", MskNationalId.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                TxtName.Text = sqlDataReader[1].ToString();
                TxtLastName.Text = sqlDataReader[2].ToString();
                CmbBranch.Text = sqlDataReader[3].ToString();
                TxtPassword.Text = sqlDataReader[5].ToString();
            }
            conn.sqlConnection().Close();
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBLDOKTORLAR SET DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 WHERE DoktorTC=@p5", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtLastName.Text);
            cmd.Parameters.AddWithValue("@p3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p5", MskNationalId.Text);
            cmd.ExecuteNonQuery();
            conn.sqlConnection().Close();
            MessageBox.Show("Bilgiler güncellendi!");

        }
    }
}
