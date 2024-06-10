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
    public partial class FrmLoginDoctor : Form
    {
        public FrmLoginDoctor()
        {
            InitializeComponent();
        }

        SqlMyConnection conn = new SqlMyConnection();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TBLDOKTORLAR WHERE DoktorTC=@p1 AND DoktorSifre=@p2", conn.sqlConnection());
            command.Parameters.AddWithValue("@p1", MskNationalId.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                FrmDoctorDetails frm = new FrmDoctorDetails();
                frm.nationalId = MskNationalId.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre girişi");
            }
            conn.sqlConnection().Close();

        }
    }
}
