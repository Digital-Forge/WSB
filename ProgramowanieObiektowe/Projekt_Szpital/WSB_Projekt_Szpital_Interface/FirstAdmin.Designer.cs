
namespace WSB_Projekt_Szpital_Interface
{
    partial class FirstAdmin
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
            this.VerifyBT = new System.Windows.Forms.Button();
            this.LoginLB = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.DoublePasswordLB = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.SurnameLB = new System.Windows.Forms.Label();
            this.PeselLB = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.DoublePasswordTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.PeselTB = new System.Windows.Forms.TextBox();
            this.ConfirmBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerifyBT
            // 
            this.VerifyBT.Location = new System.Drawing.Point(93, 215);
            this.VerifyBT.Name = "VerifyBT";
            this.VerifyBT.Size = new System.Drawing.Size(75, 23);
            this.VerifyBT.TabIndex = 0;
            this.VerifyBT.Text = "Weryfikuj";
            this.VerifyBT.UseVisualStyleBackColor = true;
            this.VerifyBT.Click += new System.EventHandler(this.VerifyBT_Click);
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Location = new System.Drawing.Point(54, 62);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(33, 13);
            this.LoginLB.TabIndex = 1;
            this.LoginLB.Text = "Login";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(93, 59);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(205, 20);
            this.UsernameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(72, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pierwszy Admin";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Location = new System.Drawing.Point(51, 88);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(36, 13);
            this.PasswordLB.TabIndex = 4;
            this.PasswordLB.Text = "Hasło";
            // 
            // DoublePasswordLB
            // 
            this.DoublePasswordLB.AutoSize = true;
            this.DoublePasswordLB.Location = new System.Drawing.Point(12, 114);
            this.DoublePasswordLB.Name = "DoublePasswordLB";
            this.DoublePasswordLB.Size = new System.Drawing.Size(75, 13);
            this.DoublePasswordLB.TabIndex = 5;
            this.DoublePasswordLB.Text = "Powtórz hasło";
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(61, 140);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(26, 13);
            this.NameLB.TabIndex = 6;
            this.NameLB.Text = "Imie";
            // 
            // SurnameLB
            // 
            this.SurnameLB.AutoSize = true;
            this.SurnameLB.Location = new System.Drawing.Point(34, 166);
            this.SurnameLB.Name = "SurnameLB";
            this.SurnameLB.Size = new System.Drawing.Size(53, 13);
            this.SurnameLB.TabIndex = 7;
            this.SurnameLB.Text = "Nazwisko";
            // 
            // PeselLB
            // 
            this.PeselLB.AutoSize = true;
            this.PeselLB.Location = new System.Drawing.Point(46, 192);
            this.PeselLB.Name = "PeselLB";
            this.PeselLB.Size = new System.Drawing.Size(41, 13);
            this.PeselLB.TabIndex = 8;
            this.PeselLB.Text = "PESEL";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(93, 85);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(205, 20);
            this.PasswordTB.TabIndex = 9;
            // 
            // DoublePasswordTB
            // 
            this.DoublePasswordTB.Location = new System.Drawing.Point(93, 111);
            this.DoublePasswordTB.Name = "DoublePasswordTB";
            this.DoublePasswordTB.PasswordChar = '*';
            this.DoublePasswordTB.Size = new System.Drawing.Size(205, 20);
            this.DoublePasswordTB.TabIndex = 10;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(93, 137);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(205, 20);
            this.NameTB.TabIndex = 11;
            this.NameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_press_fromLetter);
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(93, 163);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(205, 20);
            this.SurnameTB.TabIndex = 12;
            this.SurnameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_press_fromLetter);
            // 
            // PeselTB
            // 
            this.PeselTB.Location = new System.Drawing.Point(93, 189);
            this.PeselTB.MaxLength = 11;
            this.PeselTB.Name = "PeselTB";
            this.PeselTB.Size = new System.Drawing.Size(205, 20);
            this.PeselTB.TabIndex = 13;
            this.PeselTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeselTB_KeyPress);
            // 
            // ConfirmBT
            // 
            this.ConfirmBT.Enabled = false;
            this.ConfirmBT.Location = new System.Drawing.Point(223, 215);
            this.ConfirmBT.Name = "ConfirmBT";
            this.ConfirmBT.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBT.TabIndex = 14;
            this.ConfirmBT.Text = "Zatwierdź";
            this.ConfirmBT.UseVisualStyleBackColor = true;
            this.ConfirmBT.Click += new System.EventHandler(this.ConfirmBT_Click);
            // 
            // FirstAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 248);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.LoginLB);
            this.Controls.Add(this.VerifyBT);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 287);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(326, 287);
            this.Name = "FirstAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerifyBT;
        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Label DoublePasswordLB;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label SurnameLB;
        private System.Windows.Forms.Label PeselLB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox DoublePasswordTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox PeselTB;
        private System.Windows.Forms.Button ConfirmBT;
    }
}