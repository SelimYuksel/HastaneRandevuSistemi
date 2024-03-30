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
    public partial class FrmPatientRegister : Form
    {
        public FrmPatientRegister()
        {
            InitializeComponent();
        }

        SqlMyConnection connection = new SqlMyConnection();

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TBLHASTALAR (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtLastName.Text);
            command.Parameters.AddWithValue("@p3", MskNationalId.Text);
            command.Parameters.AddWithValue("@p4", MskPhoneNum.Text);
            command.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command.Parameters.AddWithValue("@p6", CmbGender.Text);
            command.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Kaydınız Tamamlandı Şifreniz: " + TxtPassword.Text,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
