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
    public partial class FrmAppoinmentList : Form
    {
        public FrmAppoinmentList()
        {
            InitializeComponent();
        }

        SqlMyConnection connection = new SqlMyConnection();

        private void FrmAppoinmentList_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TBLRANDEVULAR", connection.sqlConnection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

    }
}
