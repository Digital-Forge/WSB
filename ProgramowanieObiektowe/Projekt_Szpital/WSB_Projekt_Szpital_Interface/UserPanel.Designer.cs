
namespace WSB_Projekt_Szpital_Interface
{
    partial class UserPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UserInfoBT = new System.Windows.Forms.Button();
            this.RoleListCB = new System.Windows.Forms.ComboBox();
            this.refreshBT = new System.Windows.Forms.Button();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.DateUserGRIDm1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DateUserGRIDm2 = new System.Windows.Forms.DataGridView();
            this.RoleLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.SurnameLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangePasswordBT = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateUserGRIDm1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateUserGRIDm2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.SurnameLB);
            this.tabPage1.Controls.Add(this.NameLB);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.RoleLB);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChangePasswordBT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ustawienia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UsersGrid);
            this.tabPage3.Controls.Add(this.UserInfoBT);
            this.tabPage3.Controls.Add(this.RoleListCB);
            this.tabPage3.Controls.Add(this.refreshBT);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Użytkownicy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserInfoBT
            // 
            this.UserInfoBT.Location = new System.Drawing.Point(8, 6);
            this.UserInfoBT.Name = "UserInfoBT";
            this.UserInfoBT.Size = new System.Drawing.Size(75, 23);
            this.UserInfoBT.TabIndex = 9;
            this.UserInfoBT.Text = "Info";
            this.UserInfoBT.UseVisualStyleBackColor = true;
            this.UserInfoBT.Click += new System.EventHandler(this.UserInfoBT_Click);
            // 
            // RoleListCB
            // 
            this.RoleListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleListCB.FormattingEnabled = true;
            this.RoleListCB.Items.AddRange(new object[] {
            "Wszyscy",
            "Administratorzy",
            "Lekarze",
            "Pielęgniarki"});
            this.RoleListCB.Location = new System.Drawing.Point(89, 8);
            this.RoleListCB.Name = "RoleListCB";
            this.RoleListCB.Size = new System.Drawing.Size(174, 21);
            this.RoleListCB.TabIndex = 8;
            this.RoleListCB.SelectedIndexChanged += new System.EventHandler(this.RoleListCB_SelectedIndexChanged);
            // 
            // refreshBT
            // 
            this.refreshBT.Location = new System.Drawing.Point(269, 6);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(75, 23);
            this.refreshBT.TabIndex = 7;
            this.refreshBT.Text = "Odśwież";
            this.refreshBT.UseVisualStyleBackColor = true;
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // UsersGrid
            // 
            this.UsersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(8, 35);
            this.UsersGrid.MultiSelect = false;
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.ReadOnly = true;
            this.UsersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGrid.Size = new System.Drawing.Size(776, 386);
            this.UsersGrid.TabIndex = 10;
            this.UsersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGrid_CellContentClick);
            // 
            // DateUserGRIDm1
            // 
            this.DateUserGRIDm1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DateUserGRIDm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateUserGRIDm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateUserGRIDm1.Location = new System.Drawing.Point(3, 3);
            this.DateUserGRIDm1.Name = "DateUserGRIDm1";
            this.DateUserGRIDm1.ReadOnly = true;
            this.DateUserGRIDm1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateUserGRIDm1.Size = new System.Drawing.Size(276, 370);
            this.DateUserGRIDm1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(584, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(495, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dyżury";
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(475, 32);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(309, 384);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DateUserGRIDm1);
            this.tabPage4.Location = new System.Drawing.Point(23, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(282, 376);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Ten miesiąc";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DateUserGRIDm2);
            this.tabPage5.Location = new System.Drawing.Point(23, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(282, 376);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Następny miesiąć";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DateUserGRIDm2
            // 
            this.DateUserGRIDm2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DateUserGRIDm2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateUserGRIDm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateUserGRIDm2.Location = new System.Drawing.Point(3, 3);
            this.DateUserGRIDm2.Name = "DateUserGRIDm2";
            this.DateUserGRIDm2.ReadOnly = true;
            this.DateUserGRIDm2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateUserGRIDm2.Size = new System.Drawing.Size(276, 370);
            this.DateUserGRIDm2.TabIndex = 1;
            // 
            // RoleLB
            // 
            this.RoleLB.AutoSize = true;
            this.RoleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoleLB.Location = new System.Drawing.Point(151, 24);
            this.RoleLB.Name = "RoleLB";
            this.RoleLB.Size = new System.Drawing.Size(132, 46);
            this.RoleLB.TabIndex = 4;
            this.RoleLB.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(104, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(56, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwisko";
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLB.Location = new System.Drawing.Point(248, 92);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(64, 25);
            this.NameLB.TabIndex = 7;
            this.NameLB.Text = "label5";
            // 
            // SurnameLB
            // 
            this.SurnameLB.AutoSize = true;
            this.SurnameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameLB.Location = new System.Drawing.Point(248, 120);
            this.SurnameLB.Name = "SurnameLB";
            this.SurnameLB.Size = new System.Drawing.Size(64, 25);
            this.SurnameLB.TabIndex = 8;
            this.SurnameLB.Text = "label6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(449, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Więcej danych";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePasswordBT
            // 
            this.ChangePasswordBT.Location = new System.Drawing.Point(8, 6);
            this.ChangePasswordBT.Name = "ChangePasswordBT";
            this.ChangePasswordBT.Size = new System.Drawing.Size(151, 23);
            this.ChangePasswordBT.TabIndex = 0;
            this.ChangePasswordBT.Text = "Zmień hasło";
            this.ChangePasswordBT.UseVisualStyleBackColor = true;
            this.ChangePasswordBT.Click += new System.EventHandler(this.ChangePasswordBT_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "UserPanel";
            this.Text = "HospitalSystem : UserPanel";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateUserGRIDm1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateUserGRIDm2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button UserInfoBT;
        private System.Windows.Forms.ComboBox RoleListCB;
        private System.Windows.Forms.Button refreshBT;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DateUserGRIDm1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView DateUserGRIDm2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SurnameLB;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RoleLB;
        private System.Windows.Forms.Button ChangePasswordBT;
    }
}