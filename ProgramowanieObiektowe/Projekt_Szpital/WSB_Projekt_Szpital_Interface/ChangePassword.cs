using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSB_Projekt_Szpital_Logic;

namespace WSB_Projekt_Szpital_Interface
{
    public partial class ChangePassword : Form
    {
        User user;
        public ChangePassword(User user)
        {
            this.user = user;
            InitializeComponent();

            NewPasswordTB.Text = "";
            DoubleNewPasswordTB.Text = "";
        }

        private void PasswordCHB_CheckedChanged(object sender, EventArgs e)
        {
            NewPasswordTB.PasswordChar = PasswordCHB.Checked ? '\0' : '*';
            DoubleNewPasswordTB.PasswordChar = PasswordCHB.Checked ? '\0' : '*';
        }

        private void AcceptPasswordBT_Click(object sender, EventArgs e)
        {
            bool exit = false;
            if (NewPasswordTB.Text != DoubleNewPasswordTB.Text)
            {
                MessageBox.Show("Hasła są różne", "Złe hasło", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exit = true;
            }

            if (NewPasswordTB.Text.Length < LogicCore.Hook.MinLenghtPassword)
            {
                MessageBox.Show($"Hasło nie spełnia minimalnej długości ({LogicCore.Hook.MinLenghtPassword})", "Za któtkie hasło", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                exit = true;
            }

            if (exit) return;

            user.Password = NewPasswordTB.Text;
            this.Close();
        }
    }
}
