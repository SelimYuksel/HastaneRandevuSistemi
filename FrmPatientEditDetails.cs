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
    public partial class FrmPatientEditDetails : Form
    {
        public FrmPatientEditDetails()
        {
            InitializeComponent();
        }

        public string nationalId; //Hasta Detaydan gelen kimlik bilgisini detay düzenleme formunda kullanmak için değişken

        SqlMyConnection connection = new SqlMyConnection();

        //Kimlik numarasına göre veri tabanından hasta bilgisi getirme ve yazdırma
        private void FrmPatientEditDetails_Load(object sender, EventArgs e)
        {
            MskNationalId.Text = nationalId;
            SqlCommand command = new SqlCommand("SELECT HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet FROM TBLHASTALAR WHERE HastaTC=@p1", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", MskNationalId.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                TxtName.Text = sqlDataReader[0].ToString();
                TxtLastName.Text = sqlDataReader[1].ToString();
                MskPhoneNum.Text = sqlDataReader[3].ToString();
                TxtPassword.Text = sqlDataReader[4].ToString();
                CmbGender.Text = sqlDataReader[5].ToString();
            }
            connection.sqlConnection().Close();

        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE TBLHASTALAR SET HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 WHERE HastaTC=@p6", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtLastName.Text);
            command.Parameters.AddWithValue("@p3", MskPhoneNum.Text);
            command.Parameters.AddWithValue("@p4", TxtPassword.Text);
            command.Parameters.AddWithValue("@p5", CmbGender.Text);
            command.Parameters.AddWithValue("@p6", MskNationalId.Text);
            command.ExecuteNonQuery(); //INSERT, UPDATE, DELETE
            connection.sqlConnection().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
