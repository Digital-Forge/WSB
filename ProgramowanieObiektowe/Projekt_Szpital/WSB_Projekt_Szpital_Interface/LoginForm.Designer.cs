
namespace WSB_Projekt_Szpital_Interface
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ToLoginBTN = new System.Windows.Forms.Button();
            this.LoginLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.LoginErrorLB = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LoginTP = new System.Windows.Forms.TabPage();
            this.PasswordCHB = new System.Windows.Forms.CheckBox();
            this.InfoTP = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.LoginTP.SuspendLayout();
            this.InfoTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginTB.Location = new System.Drawing.Point(5, 30);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(5);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(308, 26);
            this.LoginTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTB.Location = new System.Drawing.Point(5, 86);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(308, 26);
            this.PasswordTB.TabIndex = 1;
            // 
            // ToLoginBTN
            // 
            this.ToLoginBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToLoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToLoginBTN.Location = new System.Drawing.Point(3, 148);
            this.ToLoginBTN.Margin = new System.Windows.Forms.Padding(5);
            this.ToLoginBTN.Name = "ToLoginBTN";
            this.ToLoginBTN.Size = new System.Drawing.Size(317, 51);
            this.ToLoginBTN.TabIndex = 3;
            this.ToLoginBTN.Text = "Zaloguj";
            this.ToLoginBTN.UseVisualStyleBackColor = true;
            this.ToLoginBTN.Click += new System.EventHandler(this.Click_LoginBT);
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLB.Location = new System.Drawing.Point(5, 5);
            this.LoginLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(53, 20);
            this.LoginLB.TabIndex = 4;
            this.LoginLB.Text = "Login";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLB.Location = new System.Drawing.Point(5, 61);
            this.PasswordLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(56, 20);
            this.PasswordLB.TabIndex = 5;
            this.PasswordLB.Text = "Hasło";
            // 
            // LoginErrorLB
            // 
            this.LoginErrorLB.AutoSize = true;
            this.LoginErrorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginErrorLB.ForeColor = System.Drawing.Color.Red;
            this.LoginErrorLB.Location = new System.Drawing.Point(33, 120);
            this.LoginErrorLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LoginErrorLB.Name = "LoginErrorLB";
            this.LoginErrorLB.Size = new System.Drawing.Size(154, 20);
            this.LoginErrorLB.TabIndex = 6;
            this.LoginErrorLB.Text = "Zły login lub hasło";
            this.LoginErrorLB.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.LoginTP);
            this.tabControl.Controls.Add(this.InfoTP);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(331, 235);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 7;
            // 
            // LoginTP
            // 
            this.LoginTP.Controls.Add(this.PasswordCHB);
            this.LoginTP.Controls.Add(this.LoginLB);
            this.LoginTP.Controls.Add(this.LoginErrorLB);
            this.LoginTP.Controls.Add(this.LoginTB);
            this.LoginTP.Controls.Add(this.PasswordLB);
            this.LoginTP.Controls.Add(this.PasswordTB);
            this.LoginTP.Controls.Add(this.ToLoginBTN);
            this.LoginTP.Location = new System.Drawing.Point(4, 4);
            this.LoginTP.Name = "LoginTP";
            this.LoginTP.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTP.Size = new System.Drawing.Size(323, 202);
            this.LoginTP.TabIndex = 0;
            this.LoginTP.Text = "Login";
            this.LoginTP.UseVisualStyleBackColor = true;
            // 
            // PasswordCHB
            // 
            this.PasswordCHB.AutoSize = true;
            this.PasswordCHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordCHB.Location = new System.Drawing.Point(207, 120);
            this.PasswordCHB.Name = "PasswordCHB";
            this.PasswordCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PasswordCHB.Size = new System.Drawing.Size(104, 21);
            this.PasswordCHB.TabIndex = 7;
            this.PasswordCHB.Text = "Pokaż hasło";
            this.PasswordCHB.UseVisualStyleBackColor = true;
            this.PasswordCHB.CheckedChanged += new System.EventHandler(this.PasswordCHB_CheckedChanged);
            // 
            // InfoTP
            // 
            this.InfoTP.Controls.Add(this.richTextBox1);
            this.InfoTP.Location = new System.Drawing.Point(4, 4);
            this.InfoTP.Name = "InfoTP";
            this.InfoTP.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTP.Size = new System.Drawing.Size(323, 202);
            this.InfoTP.TabIndex = 1;
            this.InfoTP.Text = "Info";
            this.InfoTP.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(317, 196);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(331, 235);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 274);
            this.MinimumSize = new System.Drawing.Size(347, 274);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalSystem : Login";
            this.tabControl.ResumeLayout(false);
            this.LoginTP.ResumeLayout(false);
            this.LoginTP.PerformLayout();
            this.InfoTP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button ToLoginBTN;
        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Label LoginErrorLB;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage LoginTP;
        private System.Windows.Forms.TabPage InfoTP;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox PasswordCHB;
    }
}

