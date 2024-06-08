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
    public partial class FrmNotices : Form
    {
        public FrmNotices()
        {
            InitializeComponent();
        }

        SqlMyConnection SqlMyConnection = new SqlMyConnection();

        private void FrmNotices_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TBLDUYURULAR", SqlMyConnection.sqlConnection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            

        }
    }
}
