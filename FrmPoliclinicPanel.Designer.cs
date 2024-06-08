namespace HastaneYonetim
{
    partial class FrmPoliclinicPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPoliclinicPanel));
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtPoliclinicName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPoliclinicId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Beige;
            this.BtnUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdate.Location = new System.Drawing.Point(183, 180);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(149, 34);
            this.BtnUpdate.TabIndex = 36;
            this.BtnUpdate.Text = "GÜNCELLE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Beige;
            this.groupBox1.Location = new System.Drawing.Point(352, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 205);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POLİKLİNİK LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Beige;
            this.BtnDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDelete.Location = new System.Drawing.Point(268, 141);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(64, 34);
            this.BtnDelete.TabIndex = 34;
            this.BtnDelete.Text = "SİL";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Beige;
            this.BtnAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnAdd.Location = new System.Drawing.Point(183, 141);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(79, 34);
            this.BtnAdd.TabIndex = 33;
            this.BtnAdd.Text = "EKLE";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtPoliclinicName
            // 
            this.TxtPoliclinicName.Location = new System.Drawing.Point(183, 83);
            this.TxtPoliclinicName.Name = "TxtPoliclinicName";
            this.TxtPoliclinicName.Size = new System.Drawing.Size(149, 29);
            this.TxtPoliclinicName.TabIndex = 31;
            this.TxtPoliclinicName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "POLİK. AD:";
            // 
            // TxtPoliclinicId
            // 
            this.TxtPoliclinicId.Location = new System.Drawing.Point(183, 37);
            this.TxtPoliclinicId.Name = "TxtPoliclinicId";
            this.TxtPoliclinicId.Size = new System.Drawing.Size(149, 29);
            this.TxtPoliclinicId.TabIndex = 24;
            this.TxtPoliclinicId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "POLİK. ID:";
            // 
            // FrmPoliclinicPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(901, 243);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtPoliclinicName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPoliclinicId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Beige;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmPoliclinicPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POLİKLİNİK PANELİ ";
            this.Load += new System.EventHandler(this.FrmPoliclinicPanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtPoliclinicName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPoliclinicId;
        private System.Windows.Forms.Label label1;
    }
}