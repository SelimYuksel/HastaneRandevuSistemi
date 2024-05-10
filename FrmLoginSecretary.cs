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
    public partial class FrmLoginSecretary : Form
    {
        public FrmLoginSecretary()
        {
            InitializeComponent();
        }

        SqlMyConnection connection = new SqlMyConnection();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TBLSEKRETER WHERE SekreterTC=@p1 and SekreterSifre=@p2", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", MskNationalId.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                FrmSecretaryDetails frm = new FrmSecretaryDetails();
                frm.nationalId = MskNationalId.Text; //Sekreter detay sayfasına TC no gönderme
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre");
            }
            connection.sqlConnection().Close();
        }
    }
}
