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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        SqlMyConnection connection = new SqlMyConnection();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("SELECT Doktorid as 'Id',DoktorAd as 'Ad',DoktorSoyad as 'Soyad',DoktorBrans as 'Branş', DoktorTC as 'TC No', DoktorSifre as 'Şifre' FROM TBLDOKTORLAR", connection.sqlConnection());
            sqlDataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;

            //Comboboxa branş ekleme
            SqlCommand command = new SqlCommand("SELECT BransAd FROM TBLBRANS", connection.sqlConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CmbPoliclinic.Items.Add(reader[0]);
            }
            connection.sqlConnection().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBLDOKTORLAR (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) VALUES (@p1,@p2,@p3,@p4,@p5)", connection.sqlConnection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtLastName.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CmbPoliclinic.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MskNationalId.Text);
            sqlCommand.Parameters.AddWithValue("@p5", TxtPassword.Text);
            sqlCommand.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Doktor eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        //Datagridviewda seçilen hücreleri ilgili kutucuklara aktarma
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtLastName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbPoliclinic.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskNationalId.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TBLDOKTORLAR WHERE DoktorTC=@p1", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1",MskNationalId.Text);
            command.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Kayıt silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE TBLDOKTORLAR SET DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtLastName.Text);
            command.Parameters.AddWithValue("@p3", CmbPoliclinic.Text);
            command.Parameters.AddWithValue("@p4", MskNationalId.Text);
            command.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Doktor güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dataTable1 = new DataTable();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("SELECT Doktorid as 'Id',DoktorAd as 'Ad',DoktorSoyad as 'Soyad',DoktorBrans as 'Branş', DoktorTC as 'TC No', DoktorSifre as 'Şifre' FROM TBLDOKTORLAR", connection.sqlConnection());
            sqlDataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
        }
    }
}
