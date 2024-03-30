namespace HastaneYonetim
{
    partial class FrmPatientEditDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientEditDetails));
            this.MskPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.BtnEditDetails = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskNationalId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MskPhoneNum
            // 
            this.MskPhoneNum.Location = new System.Drawing.Point(172, 148);
            this.MskPhoneNum.Mask = "(999) 000-0000";
            this.MskPhoneNum.Name = "MskPhoneNum";
            this.MskPhoneNum.Size = new System.Drawing.Size(132, 29);
            this.MskPhoneNum.TabIndex = 4;
            // 
            // BtnEditDetails
            // 
            this.BtnEditDetails.BackColor = System.Drawing.Color.Beige;
            this.BtnEditDetails.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnEditDetails.Location = new System.Drawing.Point(172, 283);
            this.BtnEditDetails.Name = "BtnEditDetails";
            this.BtnEditDetails.Size = new System.Drawing.Size(132, 40);
            this.BtnEditDetails.TabIndex = 30;
            this.BtnEditDetails.Text = "GÜNCELLE";
            this.BtnEditDetails.UseVisualStyleBackColor = false;
            this.BtnEditDetails.Click += new System.EventHandler(this.BtnEditDetails_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(67, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "CİNSİYET:";
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbGender.Location = new System.Drawing.Point(172, 235);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(132, 32);
            this.CmbGender.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "TELEFON:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(172, 64);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(132, 29);
            this.TxtLastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "SOYAD:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(172, 22);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(132, 29);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "AD:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(172, 190);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(132, 29);
            this.TxtPassword.TabIndex = 5;
            // 
            // MskNationalId
            // 
            this.MskNationalId.Location = new System.Drawing.Point(172, 106);
            this.MskNationalId.Mask = "00000000000";
            this.MskNationalId.Name = "MskNationalId";
            this.MskNationalId.Size = new System.Drawing.Size(132, 29);
            this.MskNationalId.TabIndex = 3;
            this.MskNationalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MskNationalId.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "T.C. KİMLİK NO:";
            // 
            // FrmPatientEditDetails
            // 
            this.AcceptButton = this.BtnEditDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(370, 347);
            this.Controls.Add(this.MskPhoneNum);
            this.Controls.Add(this.BtnEditDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskNationalId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Beige;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmPatientEditDetails";
            this.Text = "Bilgi Güncelleme ";
            this.Load += new System.EventHandler(this.FrmPatientEditDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskPhoneNum;
        private System.Windows.Forms.Button BtnEditDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskNationalId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}