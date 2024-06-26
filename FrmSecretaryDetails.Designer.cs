﻿namespace HastaneYonetim
{
    partial class FrmSecretaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNationalId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCreateNotice = new System.Windows.Forms.Button();
            this.RchNotice = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.ChkAvailable = new System.Windows.Forms.CheckBox();
            this.MskPatientNationalId = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.CmbPoliclinic = new System.Windows.Forms.ComboBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnGetAppoList = new System.Windows.Forms.Button();
            this.BtnPoliclinicPanel = new System.Windows.Forms.Button();
            this.BtnDocPanel = new System.Windows.Forms.Button();
            this.BtnNotices = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.LblNationalId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Beige;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEKRETER BİLGİSİ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(169, 73);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(109, 24);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "NULL NULL";
            // 
            // LblNationalId
            // 
            this.LblNationalId.AutoSize = true;
            this.LblNationalId.Location = new System.Drawing.Point(169, 37);
            this.LblNationalId.Name = "LblNationalId";
            this.LblNationalId.Size = new System.Drawing.Size(120, 24);
            this.LblNationalId.TabIndex = 3;
            this.LblNationalId.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C KİMLİK NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCreateNotice);
            this.groupBox2.Controls.Add(this.RchNotice);
            this.groupBox2.ForeColor = System.Drawing.Color.Beige;
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DUYURULAR";
            // 
            // BtnCreateNotice
            // 
            this.BtnCreateNotice.BackColor = System.Drawing.Color.Beige;
            this.BtnCreateNotice.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnCreateNotice.Location = new System.Drawing.Point(118, 246);
            this.BtnCreateNotice.Name = "BtnCreateNotice";
            this.BtnCreateNotice.Size = new System.Drawing.Size(132, 40);
            this.BtnCreateNotice.TabIndex = 1;
            this.BtnCreateNotice.Text = "OLUŞTUR";
            this.BtnCreateNotice.UseVisualStyleBackColor = false;
            this.BtnCreateNotice.Click += new System.EventHandler(this.BtnCreateNotice_Click);
            // 
            // RchNotice
            // 
            this.RchNotice.BackColor = System.Drawing.Color.Beige;
            this.RchNotice.Location = new System.Drawing.Point(6, 28);
            this.RchNotice.Name = "RchNotice";
            this.RchNotice.Size = new System.Drawing.Size(345, 200);
            this.RchNotice.TabIndex = 0;
            this.RchNotice.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddAppointment);
            this.groupBox3.Controls.Add(this.ChkAvailable);
            this.groupBox3.Controls.Add(this.MskPatientNationalId);
            this.groupBox3.Controls.Add(this.CmbDoctor);
            this.groupBox3.Controls.Add(this.CmbPoliclinic);
            this.groupBox3.Controls.Add(this.MskTime);
            this.groupBox3.Controls.Add(this.MskDate);
            this.groupBox3.Controls.Add(this.TxtId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Beige;
            this.groupBox3.Location = new System.Drawing.Point(375, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 442);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU PANELİ";
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.BackColor = System.Drawing.Color.Beige;
            this.BtnAddAppointment.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnAddAppointment.Location = new System.Drawing.Point(143, 377);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(149, 40);
            this.BtnAddAppointment.TabIndex = 14;
            this.BtnAddAppointment.Text = "KAYDET";
            this.BtnAddAppointment.UseVisualStyleBackColor = false;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // ChkAvailable
            // 
            this.ChkAvailable.AutoSize = true;
            this.ChkAvailable.Location = new System.Drawing.Point(143, 309);
            this.ChkAvailable.Name = "ChkAvailable";
            this.ChkAvailable.Size = new System.Drawing.Size(97, 28);
            this.ChkAvailable.TabIndex = 13;
            this.ChkAvailable.Text = "DURUM";
            this.ChkAvailable.UseVisualStyleBackColor = true;
            // 
            // MskPatientNationalId
            // 
            this.MskPatientNationalId.Location = new System.Drawing.Point(143, 265);
            this.MskPatientNationalId.Mask = "00000000000";
            this.MskPatientNationalId.Name = "MskPatientNationalId";
            this.MskPatientNationalId.Size = new System.Drawing.Size(149, 29);
            this.MskPatientNationalId.TabIndex = 12;
            this.MskPatientNationalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MskPatientNationalId.ValidatingType = typeof(int);
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(143, 223);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(149, 32);
            this.CmbDoctor.TabIndex = 11;
            // 
            // CmbPoliclinic
            // 
            this.CmbPoliclinic.FormattingEnabled = true;
            this.CmbPoliclinic.Location = new System.Drawing.Point(143, 179);
            this.CmbPoliclinic.Name = "CmbPoliclinic";
            this.CmbPoliclinic.Size = new System.Drawing.Size(149, 32);
            this.CmbPoliclinic.TabIndex = 10;
            this.CmbPoliclinic.SelectedIndexChanged += new System.EventHandler(this.CmbPoliclinic_SelectedIndexChanged);
            // 
            // MskTime
            // 
            this.MskTime.Location = new System.Drawing.Point(143, 138);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(149, 29);
            this.MskTime.TabIndex = 9;
            this.MskTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Location = new System.Drawing.Point(143, 97);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(149, 29);
            this.MskDate.TabIndex = 8;
            this.MskDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(143, 56);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(149, 29);
            this.TxtId.TabIndex = 7;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "HASTA T.C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(42, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "DOKTOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "POLİKLİNİK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "SAAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "TARİH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(695, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 221);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "POLİKLİNİKLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(696, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 333);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DOKTORLAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(414, 305);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnNotices);
            this.groupBox6.Controls.Add(this.BtnGetAppoList);
            this.groupBox6.Controls.Add(this.BtnPoliclinicPanel);
            this.groupBox6.Controls.Add(this.BtnDocPanel);
            this.groupBox6.ForeColor = System.Drawing.Color.Beige;
            this.groupBox6.Location = new System.Drawing.Point(12, 459);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(678, 107);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "HIZLI ERİŞİM";
            // 
            // BtnGetAppoList
            // 
            this.BtnGetAppoList.BackColor = System.Drawing.Color.Beige;
            this.BtnGetAppoList.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnGetAppoList.Location = new System.Drawing.Point(126, 15);
            this.BtnGetAppoList.Name = "BtnGetAppoList";
            this.BtnGetAppoList.Size = new System.Drawing.Size(185, 40);
            this.BtnGetAppoList.TabIndex = 17;
            this.BtnGetAppoList.Text = "RANDEVU LİSTESİ";
            this.BtnGetAppoList.UseVisualStyleBackColor = false;
            this.BtnGetAppoList.Click += new System.EventHandler(this.BtnGetAppoList_Click);
            // 
            // BtnPoliclinicPanel
            // 
            this.BtnPoliclinicPanel.BackColor = System.Drawing.Color.Beige;
            this.BtnPoliclinicPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnPoliclinicPanel.Location = new System.Drawing.Point(388, 15);
            this.BtnPoliclinicPanel.Name = "BtnPoliclinicPanel";
            this.BtnPoliclinicPanel.Size = new System.Drawing.Size(194, 40);
            this.BtnPoliclinicPanel.TabIndex = 16;
            this.BtnPoliclinicPanel.Text = "POLİKLİNİK PANELİ";
            this.BtnPoliclinicPanel.UseVisualStyleBackColor = false;
            this.BtnPoliclinicPanel.Click += new System.EventHandler(this.BtnPoliclinicPanel_Click);
            // 
            // BtnDocPanel
            // 
            this.BtnDocPanel.BackColor = System.Drawing.Color.Beige;
            this.BtnDocPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDocPanel.Location = new System.Drawing.Point(126, 61);
            this.BtnDocPanel.Name = "BtnDocPanel";
            this.BtnDocPanel.Size = new System.Drawing.Size(185, 40);
            this.BtnDocPanel.TabIndex = 15;
            this.BtnDocPanel.Text = "DOKTOR PANELİ";
            this.BtnDocPanel.UseVisualStyleBackColor = false;
            this.BtnDocPanel.Click += new System.EventHandler(this.BtnDocPanel_Click);
            // 
            // BtnNotices
            // 
            this.BtnNotices.BackColor = System.Drawing.Color.Beige;
            this.BtnNotices.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnNotices.Location = new System.Drawing.Point(388, 61);
            this.BtnNotices.Name = "BtnNotices";
            this.BtnNotices.Size = new System.Drawing.Size(194, 40);
            this.BtnNotices.TabIndex = 18;
            this.BtnNotices.Text = "DUYURULAR";
            this.BtnNotices.UseVisualStyleBackColor = false;
            this.BtnNotices.Click += new System.EventHandler(this.BtnNotices_Click);
            // 
            // FrmSecretaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1127, 577);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSecretaryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEKRETER DETAY";
            this.Load += new System.EventHandler(this.FrmSecretaryDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNationalId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCreateNotice;
        private System.Windows.Forms.RichTextBox RchNotice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ChkAvailable;
        private System.Windows.Forms.MaskedTextBox MskPatientNationalId;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.ComboBox CmbPoliclinic;
        private System.Windows.Forms.MaskedTextBox MskTime;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.Button BtnAddAppointment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnGetAppoList;
        private System.Windows.Forms.Button BtnPoliclinicPanel;
        private System.Windows.Forms.Button BtnDocPanel;
        private System.Windows.Forms.Button BtnNotices;
    }
}