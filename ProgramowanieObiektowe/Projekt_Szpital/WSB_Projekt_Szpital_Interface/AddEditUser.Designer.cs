
namespace WSB_Projekt_Szpital_Interface
{
    partial class AddEditUser
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
            this.ConfirmBT = new System.Windows.Forms.Button();
            this.PeselTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.DoublePasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PeselLB = new System.Windows.Forms.Label();
            this.SurnameLB = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.DoublePasswordLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.LoginLB = new System.Windows.Forms.Label();
            this.VerifyBT = new System.Windows.Forms.Button();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.NurseSkillDGV = new System.Windows.Forms.DataGridView();
            this.NurseKursLB = new System.Windows.Forms.Label();
            this.NurseSkillAddBT = new System.Windows.Forms.Button();
            this.NurseSkillRemoveBT = new System.Windows.Forms.Button();
            this.NrPWZTB = new System.Windows.Forms.TextBox();
            this.NrPWZLB = new System.Windows.Forms.Label();
            this.SpecCB = new System.Windows.Forms.ComboBox();
            this.SpecLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NurseSkillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmBT
            // 
            this.ConfirmBT.Enabled = false;
            this.ConfirmBT.Location = new System.Drawing.Point(226, 387);
            this.ConfirmBT.Name = "ConfirmBT";
            this.ConfirmBT.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBT.TabIndex = 28;
            this.ConfirmBT.Text = "Zatwierdź";
            this.ConfirmBT.UseVisualStyleBackColor = true;
            this.ConfirmBT.Click += new System.EventHandler(this.ConfirmBT_Click);
            // 
            // PeselTB
            // 
            this.PeselTB.Location = new System.Drawing.Point(96, 142);
            this.PeselTB.MaxLength = 11;
            this.PeselTB.Name = "PeselTB";
            this.PeselTB.Size = new System.Drawing.Size(205, 20);
            this.PeselTB.TabIndex = 27;
            this.PeselTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeselTB_KeyPress);
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(96, 116);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(205, 20);
            this.SurnameTB.TabIndex = 26;
            this.SurnameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_press_fromLetter);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(96, 90);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(205, 20);
            this.NameTB.TabIndex = 25;
            this.NameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_press_fromLetter);
            // 
            // DoublePasswordTB
            // 
            this.DoublePasswordTB.Location = new System.Drawing.Point(96, 64);
            this.DoublePasswordTB.Name = "DoublePasswordTB";
            this.DoublePasswordTB.PasswordChar = '*';
            this.DoublePasswordTB.Size = new System.Drawing.Size(205, 20);
            this.DoublePasswordTB.TabIndex = 24;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(96, 38);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(205, 20);
            this.PasswordTB.TabIndex = 23;
            // 
            // PeselLB
            // 
            this.PeselLB.AutoSize = true;
            this.PeselLB.Location = new System.Drawing.Point(49, 145);
            this.PeselLB.Name = "PeselLB";
            this.PeselLB.Size = new System.Drawing.Size(41, 13);
            this.PeselLB.TabIndex = 22;
            this.PeselLB.Text = "PESEL";
            // 
            // SurnameLB
            // 
            this.SurnameLB.AutoSize = true;
            this.SurnameLB.Location = new System.Drawing.Point(37, 119);
            this.SurnameLB.Name = "SurnameLB";
            this.SurnameLB.Size = new System.Drawing.Size(53, 13);
            this.SurnameLB.TabIndex = 21;
            this.SurnameLB.Text = "Nazwisko";
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(64, 93);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(26, 13);
            this.NameLB.TabIndex = 20;
            this.NameLB.Text = "Imie";
            // 
            // DoublePasswordLB
            // 
            this.DoublePasswordLB.AutoSize = true;
            this.DoublePasswordLB.Location = new System.Drawing.Point(15, 67);
            this.DoublePasswordLB.Name = "DoublePasswordLB";
            this.DoublePasswordLB.Size = new System.Drawing.Size(75, 13);
            this.DoublePasswordLB.TabIndex = 19;
            this.DoublePasswordLB.Text = "Powtórz hasło";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Location = new System.Drawing.Point(54, 41);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(36, 13);
            this.PasswordLB.TabIndex = 18;
            this.PasswordLB.Text = "Hasło";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(96, 12);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(205, 20);
            this.loginTB.TabIndex = 17;
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Location = new System.Drawing.Point(57, 15);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(33, 13);
            this.LoginLB.TabIndex = 16;
            this.LoginLB.Text = "Login";
            // 
            // VerifyBT
            // 
            this.VerifyBT.Location = new System.Drawing.Point(96, 387);
            this.VerifyBT.Name = "VerifyBT";
            this.VerifyBT.Size = new System.Drawing.Size(75, 23);
            this.VerifyBT.TabIndex = 15;
            this.VerifyBT.Text = "Weryfikuj";
            this.VerifyBT.UseVisualStyleBackColor = true;
            this.VerifyBT.Click += new System.EventHandler(this.VerifyBT_Click);
            // 
            // RoleCB
            // 
            this.RoleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Items.AddRange(new object[] {
            "Admin",
            "Lekarz",
            "Pielęgniarka"});
            this.RoleCB.Location = new System.Drawing.Point(96, 168);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(205, 21);
            this.RoleCB.TabIndex = 29;
            this.RoleCB.SelectedIndexChanged += new System.EventHandler(this.RoleCB_SelectedIndexChanged);
            // 
            // NurseSkillDGV
            // 
            this.NurseSkillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NurseSkillDGV.Location = new System.Drawing.Point(96, 195);
            this.NurseSkillDGV.Name = "NurseSkillDGV";
            this.NurseSkillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NurseSkillDGV.Size = new System.Drawing.Size(205, 186);
            this.NurseSkillDGV.TabIndex = 30;
            // 
            // NurseKursLB
            // 
            this.NurseKursLB.AutoSize = true;
            this.NurseKursLB.Location = new System.Drawing.Point(26, 250);
            this.NurseKursLB.Name = "NurseKursLB";
            this.NurseKursLB.Size = new System.Drawing.Size(53, 13);
            this.NurseKursLB.TabIndex = 31;
            this.NurseKursLB.Text = "Szkolenia";
            // 
            // NurseSkillAddBT
            // 
            this.NurseSkillAddBT.Location = new System.Drawing.Point(12, 266);
            this.NurseSkillAddBT.Name = "NurseSkillAddBT";
            this.NurseSkillAddBT.Size = new System.Drawing.Size(78, 23);
            this.NurseSkillAddBT.TabIndex = 32;
            this.NurseSkillAddBT.Text = "Dodaj";
            this.NurseSkillAddBT.UseVisualStyleBackColor = true;
            this.NurseSkillAddBT.Click += new System.EventHandler(this.NurseSkillAddBT_Click);
            // 
            // NurseSkillRemoveBT
            // 
            this.NurseSkillRemoveBT.Location = new System.Drawing.Point(12, 295);
            this.NurseSkillRemoveBT.Name = "NurseSkillRemoveBT";
            this.NurseSkillRemoveBT.Size = new System.Drawing.Size(78, 23);
            this.NurseSkillRemoveBT.TabIndex = 33;
            this.NurseSkillRemoveBT.Text = "Usuń";
            this.NurseSkillRemoveBT.UseVisualStyleBackColor = true;
            this.NurseSkillRemoveBT.Click += new System.EventHandler(this.NurseSkillRemoveBT_Click);
            // 
            // NrPWZTB
            // 
            this.NrPWZTB.Location = new System.Drawing.Point(96, 195);
            this.NrPWZTB.MaxLength = 7;
            this.NrPWZTB.Name = "NrPWZTB";
            this.NrPWZTB.Size = new System.Drawing.Size(205, 20);
            this.NrPWZTB.TabIndex = 34;
            this.NrPWZTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeselTB_KeyPress);
            // 
            // NrPWZLB
            // 
            this.NrPWZLB.AutoSize = true;
            this.NrPWZLB.Location = new System.Drawing.Point(24, 198);
            this.NrPWZLB.Name = "NrPWZLB";
            this.NrPWZLB.Size = new System.Drawing.Size(66, 13);
            this.NrPWZLB.TabIndex = 35;
            this.NrPWZLB.Text = "Numer PWZ";
            // 
            // SpecCB
            // 
            this.SpecCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecCB.FormattingEnabled = true;
            this.SpecCB.Location = new System.Drawing.Point(96, 221);
            this.SpecCB.Name = "SpecCB";
            this.SpecCB.Size = new System.Drawing.Size(205, 21);
            this.SpecCB.TabIndex = 36;
            // 
            // SpecLB
            // 
            this.SpecLB.AutoSize = true;
            this.SpecLB.Location = new System.Drawing.Point(21, 224);
            this.SpecLB.Name = "SpecLB";
            this.SpecLB.Size = new System.Drawing.Size(69, 13);
            this.SpecLB.TabIndex = 37;
            this.SpecLB.Text = "Specjalizacja";
            // 
            // AddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 420);
            this.Controls.Add(this.VerifyBT);
            this.Controls.Add(this.SpecLB);
            this.Controls.Add(this.SpecCB);
            this.Controls.Add(this.NrPWZLB);
            this.Controls.Add(this.NrPWZTB);
            this.Controls.Add(this.NurseSkillRemoveBT);
            this.Controls.Add(this.NurseSkillAddBT);
            this.Controls.Add(this.NurseKursLB);
            this.Controls.Add(this.NurseSkillDGV);
            this.Controls.Add(this.RoleCB);
            this.Controls.Add(this.ConfirmBT);
            this.Controls.Add(this.PeselTB);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.DoublePasswordTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.PeselLB);
            this.Controls.Add(this.SurnameLB);
            this.Controls.Add(this.NameLB);
            this.Controls.Add(this.DoublePasswordLB);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.LoginLB);
            this.MaximumSize = new System.Drawing.Size(329, 459);
            this.MinimumSize = new System.Drawing.Size(329, 459);
            this.Name = "AddEditUser";
            this.Text = "AddEditUser";
            ((System.ComponentModel.ISupportInitialize)(this.NurseSkillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmBT;
        private System.Windows.Forms.TextBox PeselTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox DoublePasswordTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label PeselLB;
        private System.Windows.Forms.Label SurnameLB;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label DoublePasswordLB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.Button VerifyBT;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.DataGridView NurseSkillDGV;
        private System.Windows.Forms.Label NurseKursLB;
        private System.Windows.Forms.Button NurseSkillAddBT;
        private System.Windows.Forms.Button NurseSkillRemoveBT;
        private System.Windows.Forms.TextBox NrPWZTB;
        private System.Windows.Forms.Label NrPWZLB;
        private System.Windows.Forms.ComboBox SpecCB;
        private System.Windows.Forms.Label SpecLB;
    }
}