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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }

        SqlMyConnection conn = new SqlMyConnection();

        public string nationalId;

        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            LblNationalId.Text = nationalId;

            SqlCommand cmd = new SqlCommand("SELECT DoktorAd, DoktorSoyad FROM TBLDOKTORLAR WHERE DoktorTC=@p1", conn.sqlConnection());
            cmd.Parameters.AddWithValue("@p1", LblNationalId.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblName.Text = sqlDataReader[0] + " " + sqlDataReader[1];
            }
            conn.sqlConnection().Close();

            //Randevu Listesi
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TBLRANDEVULAR WHERE RandevuDoktor='" + LblName.Text + "'", conn.sqlConnection());
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns["RandevuTarih"].HeaderText = "Tarih";
            dataGridView1.Columns["RandevuSaat"].HeaderText = "Saat";
            dataGridView1.Columns["RandevuBrans"].HeaderText = "Poliklinik";
            dataGridView1.Columns["RandevuDoktor"].HeaderText = "Doktor";
            dataGridView1.Columns["RandevuDurum"].HeaderText = "Durum";
            dataGridView1.Columns["HastaTC"].HeaderText = "Kimlik No.";
            dataGridView1.Columns["HastaSikayet"].HeaderText = "Şikayet";
            dataGridView1.Columns["Randevuid"].HeaderText = "Randevu No.";
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            FrmDoctorEditDetails frm = new FrmDoctorEditDetails();
            frm.nationalId = LblNationalId.Text;
            frm.Show();
        }

        private void BtnNotice_Click(object sender, EventArgs e)
        {
            FrmNotices frmNotices = new FrmNotices();
            frmNotices.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchComplaint.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
