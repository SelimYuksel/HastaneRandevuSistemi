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
    public partial class FrmLoginPatient : Form
    {
        public FrmLoginPatient()
        {
            InitializeComponent();
        }

        SqlMyConnection connection = new SqlMyConnection();

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientRegister frmPatientRegister = new FrmPatientRegister();
            frmPatientRegister.Show();//Kayıt linkine basıldığı zaman kayıt ekranı görüntüleme
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TBLHASTALAR WHERE HastaTC=@p1 AND HastaSifre=@p2", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", MskNationalId.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read()) //Eğer kimlik bilgisi ve şifre, veri tabanındaki bilgilerle uyuşuyorsa
            {
                FrmPatientDetails frmPatientDetails = new FrmPatientDetails();
                frmPatientDetails.nationalId = MskNationalId.Text;//Bu formdan gelen kimlik bilgisini hasta detay formuna yazdırma işlemi
                frmPatientDetails.Show();
                this.Hide();
            }
            else //uyuşmuyorsa
            {
                MessageBox.Show("Hatalı TC No ya da şifre");
            }
            connection.sqlConnection().Close();
        }
    }
}
