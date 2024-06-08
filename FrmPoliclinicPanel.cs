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
    public partial class FrmPoliclinicPanel : Form
    {
        public FrmPoliclinicPanel()
        {
            InitializeComponent();
        }

        SqlMyConnection connection = new SqlMyConnection();

        private void FrmPoliclinicPanel_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBLBRANS", connection.sqlConnection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBLBRANS (BransAd) VALUES (@p1)", connection.sqlConnection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtPoliclinicName.Text);
            sqlCommand.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Bölüm eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenHucre = dataGridView1.SelectedCells[0].RowIndex;
            TxtPoliclinicId.Text = dataGridView1.Rows[secilenHucre].Cells[0].Value.ToString();
            TxtPoliclinicName.Text = dataGridView1.Rows[secilenHucre].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM TBLBRANS WHERE Bransid=@p1", connection.sqlConnection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtPoliclinicId.Text);
            sqlCommand.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Bölüm silindi!");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE TBLBRANS SET BransAd=@p1 WHERE Bransid=@p2", connection.sqlConnection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtPoliclinicName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtPoliclinicId.Text);
            sqlCommand.ExecuteNonQuery();
            connection.sqlConnection().Close();
            MessageBox.Show("Bölüm güncellendi.");


        }
    }
}
