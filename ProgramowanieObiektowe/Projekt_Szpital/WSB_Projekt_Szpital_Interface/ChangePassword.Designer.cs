
namespace WSB_Projekt_Szpital_Interface
{
    partial class ChangePassword
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
            this.NewPasswordTB = new System.Windows.Forms.TextBox();
            this.textLB1 = new System.Windows.Forms.Label();
            this.textLB2 = new System.Windows.Forms.Label();
            this.DoubleNewPasswordTB = new System.Windows.Forms.TextBox();
            this.AcceptPasswordBT = new System.Windows.Forms.Button();
            this.PasswordCHB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NewPasswordTB
            // 
            this.NewPasswordTB.Location = new System.Drawing.Point(90, 12);
            this.NewPasswordTB.Name = "NewPasswordTB";
            this.NewPasswordTB.PasswordChar = '*';
            this.NewPasswordTB.Size = new System.Drawing.Size(142, 20);
            this.NewPasswordTB.TabIndex = 0;
            // 
            // textLB1
            // 
            this.textLB1.AutoSize = true;
            this.textLB1.Location = new System.Drawing.Point(12, 15);
            this.textLB1.Name = "textLB1";
            this.textLB1.Size = new System.Drawing.Size(65, 13);
            this.textLB1.TabIndex = 1;
            this.textLB1.Text = "Nowe hasło";
            // 
            // textLB2
            // 
            this.textLB2.AutoSize = true;
            this.textLB2.Location = new System.Drawing.Point(12, 41);
            this.textLB2.Name = "textLB2";
            this.textLB2.Size = new System.Drawing.Size(72, 13);
            this.textLB2.TabIndex = 3;
            this.textLB2.Text = "Powtóż hasło";
            // 
            // DoubleNewPasswordTB
            // 
            this.DoubleNewPasswordTB.Location = new System.Drawing.Point(90, 38);
            this.DoubleNewPasswordTB.Name = "DoubleNewPasswordTB";
            this.DoubleNewPasswordTB.PasswordChar = '*';
            this.DoubleNewPasswordTB.Size = new System.Drawing.Size(142, 20);
            this.DoubleNewPasswordTB.TabIndex = 2;
            // 
            // AcceptPasswordBT
            // 
            this.AcceptPasswordBT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptPasswordBT.Location = new System.Drawing.Point(0, 87);
            this.AcceptPasswordBT.Name = "AcceptPasswordBT";
            this.AcceptPasswordBT.Size = new System.Drawing.Size(244, 41);
            this.AcceptPasswordBT.TabIndex = 4;
            this.AcceptPasswordBT.Text = "Zatwierdź";
            this.AcceptPasswordBT.UseVisualStyleBackColor = true;
            this.AcceptPasswordBT.Click += new System.EventHandler(this.AcceptPasswordBT_Click);
            // 
            // PasswordCHB
            // 
            this.PasswordCHB.AutoSize = true;
            this.PasswordCHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordCHB.Location = new System.Drawing.Point(146, 64);
            this.PasswordCHB.Name = "PasswordCHB";
            this.PasswordCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PasswordCHB.Size = new System.Drawing.Size(86, 17);
            this.PasswordCHB.TabIndex = 8;
            this.PasswordCHB.Text = "Pokaż hasło";
            this.PasswordCHB.UseVisualStyleBackColor = true;
            this.PasswordCHB.CheckedChanged += new System.EventHandler(this.PasswordCHB_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 128);
            this.Controls.Add(this.PasswordCHB);
            this.Controls.Add(this.AcceptPasswordBT);
            this.Controls.Add(this.textLB2);
            this.Controls.Add(this.DoubleNewPasswordTB);
            this.Controls.Add(this.textLB1);
            this.Controls.Add(this.NewPasswordTB);
            this.Name = "ChangePassword";
            this.Text = "Zmiana hasła";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPasswordTB;
        private System.Windows.Forms.Label textLB1;
        private System.Windows.Forms.Label textLB2;
        private System.Windows.Forms.TextBox DoubleNewPasswordTB;
        private System.Windows.Forms.Button AcceptPasswordBT;
        private System.Windows.Forms.CheckBox PasswordCHB;
    }
}