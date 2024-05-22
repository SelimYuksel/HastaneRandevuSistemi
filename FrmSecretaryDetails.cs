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
    public partial class FrmSecretaryDetails : Form
    {
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }
        public string nationalId;

        SqlMyConnection connection = new SqlMyConnection();

        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            LblNationalId.Text = nationalId; //Sekreter giriş sayfasından TC no getirme

            SqlCommand command1 = new SqlCommand("SELECT SekreterAdSoyad FROM TBLSEKRETER WHERE SekreterTC=@p1", connection.sqlConnection());
            command1.Parameters.AddWithValue("@p1", LblNationalId.Text);
            SqlDataReader reader1 = command1.ExecuteReader(); //VTdan tc noya göre adsoyad çekme
            while (reader1.Read())
            {
                LblName.Text = reader1[0].ToString(); //Tek sütun gelir
            }
            connection.sqlConnection().Close();

            //Poliklinik listesi getirme
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM TBLBRANS",connection.sqlConnection());
            sqlDataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;

            //Doktorlar listesi getirme
            DataTable dataTable2 = new DataTable();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans FROM TBLDOKTORLAR",connection.sqlConnection());
            sqlDataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;

            //Cmbboxa polik getirme
            SqlCommand command2 = new SqlCommand("SELECT BransAd FROM TBLBRANS", connection.sqlConnection());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                CmbPoliclinic.Items.Add(reader2[0]);
            }
            connection.sqlConnection().Close();

        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)  //Randevu ekleme
        {
            SqlCommand command = new SqlCommand("INSERT INTO TBLRANDEVULAR (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@p1,@p2,@p3,@p4)", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", MskDate.Text);
            command.Parameters.AddWithValue("@p2", MskTime.Text);
            command.Parameters.AddWithValue("@p3", CmbPoliclinic.Text);
            command.Parameters.AddWithValue("@p4", CmbDoctor.Text);
            command.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Randevu oluşturuldu");
        }

        private void CmbPoliclinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand command = new SqlCommand("SELECT DoktorAd, DoktorSoyad FROM TBLDOKTORLAR WHERE DoktorBrans=@p1", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", CmbPoliclinic.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbDoctor.Items.Add(sqlDataReader[0] + " " + sqlDataReader[1]);
            }
            connection.sqlConnection().Close();
        }

        private void BtnCreateNotice_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBLDUYURULAR (Duyuru) VALUES (@p1)", connection.sqlConnection());
            sqlCommand.Parameters.AddWithValue("@p1", RchNotice.Text);
            sqlCommand.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void BtnDocPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frmDoctorPanel = new FrmDoctorPanel();
            frmDoctorPanel.Show();
        }
    }
}
