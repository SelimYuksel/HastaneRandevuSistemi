using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetim
{
    public partial class FrmLoginMain : Form
    {
        public FrmLoginMain()
        {
            InitializeComponent();
        }

        private void BtnLoginPatient_Click(object sender, EventArgs e)
        {
            FrmLoginPatient frmLoginPatient = new FrmLoginPatient();
            frmLoginPatient.Show();
            this.Hide();
        }

        private void BtnLoginDoctor_Click(object sender, EventArgs e)
        {
            FrmLoginDoctor frmLoginDoctor = new FrmLoginDoctor();
            frmLoginDoctor.Show();
            this.Hide();
        }

        private void BtnLoginSecretary_Click(object sender, EventArgs e)
        {
            FrmLoginSecretary frmLoginSecretary = new FrmLoginSecretary();
            frmLoginSecretary.Show();
            this.Hide();
        }
    }
}
