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
    public partial class FrmPatientDetails : Form
    {
        public FrmPatientDetails()
        {
            InitializeComponent();
        }
        //Diğer formların erişebileceği kimlik bilgisi değişkeni
        public string nationalId;

        SqlMyConnection connection = new SqlMyConnection();

        private void FrmPatientDetails_Load(object sender, EventArgs e)
        {
            LblNationalId.Text = nationalId; //Hasta girişten gelen kimlik bilgisini bu formda yazdırma

            //Veri tabanından forma ad, soyad çekme ve yazdırma işlemi
            SqlCommand command = new SqlCommand("SELECT HastaAd, HastaSoyad FROM TBLHASTALAR WHERE HastaTC=@p1", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1",LblNationalId.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read()) //Veri tabanında olan bilgileri oku
            {
                LblNames.Text = sqlDataReader[0] + " " + sqlDataReader[1]; //gelen bilgiyi yazdır
            }
            connection.sqlConnection().Close();

            //Randevu geçmişi listeleme
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor, RandevuDurum, HastaTC FROM TBLRANDEVULAR WHERE HastaTC="+nationalId,connection.sqlConnection()); //DataAdapter datagrid'e veri yazdırmak için
            sqlDataAdapter.Fill(dataTable); //bellekte tablo oluşturma
            dataGridView1.DataSource = dataTable;

            //Poliklinikleri ekleme
            SqlCommand command1 = new SqlCommand("SELECT BransAd FROM TBLBRANS", connection.sqlConnection());
            SqlDataReader sqlDataReader1 = command1.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                CmbPoliclinic.Items.Add(sqlDataReader1[0]);
            }
            connection.sqlConnection().Close();

            dataGridView1.Columns["RandevuTarih"].HeaderText = "Tarih";
            dataGridView1.Columns["RandevuSaat"].HeaderText = "Saat";
            dataGridView1.Columns["RandevuBrans"].HeaderText = "Poliklinik";
            dataGridView1.Columns["RandevuDoktor"].HeaderText = "Doktor";
            dataGridView1.Columns["RandevuDurum"].HeaderText = "Durum";
            dataGridView1.Columns["HastaTC"].HeaderText = "Kimlik No.";
            dataGridView1.AutoResizeColumns();

            

        }
        //Seçilen polikliniğe göre doktor bilgisi görüntüleme
        private void CmbPoliclinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();//Poliklinik seçildiği anda combobox içeriğini temizleme, yapılmazsa; her polik. seçildiğinde polik. doktoru eklenmiş olarak kalır.

            SqlCommand command = new SqlCommand("SELECT DoktorAd, DoktorSoyad FROM TBLDOKTORLAR WHERE DoktorBrans=@p1", connection.sqlConnection());
            command.Parameters.AddWithValue("@p1", CmbPoliclinic.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbDoctor.Items.Add(sqlDataReader[0] + " " + sqlDataReader[1]);
            }
            connection.sqlConnection().Close();
        }

        //Seçilen doktora göre randevu ekleme
        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Randevuid, RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor, RandevuDurum, HastaTC FROM TBLRANDEVULAR WHERE RandevuBrans='" + CmbPoliclinic.Text+"'" + " AND RandevuDoktor='" + CmbDoctor.Text + "'" + " AND RandevuDurum=0 ",connection.sqlConnection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

            dataGridView2.Columns["Randevuid"].HeaderText = "Randevu No.";
            dataGridView2.Columns["RandevuTarih"].HeaderText = "Tarih";
            dataGridView2.Columns["RandevuSaat"].HeaderText = "Saat";
            dataGridView2.Columns["RandevuBrans"].HeaderText = "Poliklinik";
            dataGridView2.Columns["RandevuDoktor"].HeaderText = "Doktor";
            dataGridView2.Columns["RandevuDurum"].HeaderText = "Durum";
            dataGridView2.Columns["HastaTC"].HeaderText = "Kimlik No.";
            dataGridView2.AutoResizeColumns();
        }

        private void LnkEditDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientEditDetails frmPatientEditDetails = new FrmPatientEditDetails();
            frmPatientEditDetails.nationalId = LblNationalId.Text;
            frmPatientEditDetails.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnGetAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE TBLRANDEVULAR SET RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 WHERE Randevuid=@p3", connection.sqlConnection());
            sqlCommand.Parameters.AddWithValue("@p1", LblNationalId.Text);
            sqlCommand.Parameters.AddWithValue("@p2", RchComplaint.Text);
            sqlCommand.Parameters.AddWithValue("@p3", textBox1.Text);
            sqlCommand.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Randevunuz alındı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
