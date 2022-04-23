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
    public partial class FirstAdmin : Form
    {
        private bool blockBoxs = false;

        public FirstAdmin()
        {
            InitializeComponent();
        }

        private void VerifyBT_Click(object sender, EventArgs e)
        {
            if (blockBoxs)
            {
                UsernameTB.Enabled = true;
                PasswordTB.Enabled = true;
                DoublePasswordTB.Enabled = true;
                NameTB.Enabled = true;
                SurnameTB.Enabled = true;
                PeselTB.Enabled = true;

                blockBoxs = false;
                VerifyBT.Text = "Weryfikuj";
                ConfirmBT.Enabled = false;
            }
            else
            {
                bool exitBuff = false;
                bool emptyBox = false;

                if (UsernameTB.Text == "")
                {
                    LoginLB.ForeColor = Color.Red;
                    emptyBox = true;
                    exitBuff = true;
                }
                else
                {
                    LoginLB.ForeColor = Color.Black;
                }

                if (PasswordTB.Text == "")
                {
                    PasswordLB.ForeColor = Color.Red;
                    emptyBox = true;
                    exitBuff = true;
                }
                else
                {
                    PasswordLB.ForeColor = Color.Black;
                }

                if (DoublePasswordTB.Text == "")
                {
                    DoublePasswordLB.ForeColor = Color.Red;
                    emptyBox = true;
                    exitBuff = true;
                }
                else
                {
                    DoublePasswordLB.ForeColor = Color.Black;
                }

                if (NameTB.Text == "")
                {
                    NameLB.ForeColor = Color.Red;
                    emptyBox = true;
                    exitBuff = true;
                }
                else
                {
                    NameLB.ForeColor = Color.Black;
                }

                if (SurnameTB.Text == "")
                {
                    SurnameLB.ForeColor = Color.Red;
                    emptyBox = true;
                    exitBuff = true;
                }
                else
                {
                    SurnameLB.ForeColor = Color.Black;
                }

                if (PeselTB.Text == "")
                {
                    PeselLB.ForeColor = Color.Red;
                    emptyBox = true;
                    exitBuff = true;
                }
                else
                {
                    PeselLB.ForeColor = Color.Black;
                }

                if (PasswordTB.Text != DoublePasswordTB.Text)
                {
                    DoublePasswordLB.ForeColor = Color.Red;
                    exitBuff = true;
                    MessageBox.Show("Hasła się nie zgadzają", "Złe Hasła", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (!Methods.CheckPesel(PeselTB.Text))
                {
                    PeselLB.ForeColor = Color.Red;
                    exitBuff = true;
                    MessageBox.Show("Niewłaściwa długość numeru PESEL", "Zły PESEL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (emptyBox)
                {
                    MessageBox.Show("Wszystkie pola muszą zawierać dane", "Puste Pola", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (exitBuff)
                {
                    return;
                }

                UsernameTB.Enabled = false;
                PasswordTB.Enabled = false;
                DoublePasswordTB.Enabled = false;
                NameTB.Enabled = false;
                SurnameTB.Enabled = false;
                PeselTB.Enabled = false;

                blockBoxs = true;
                VerifyBT.Text = "Zmień";
                ConfirmBT.Enabled = true;
            }
        }

        private void ConfirmBT_Click(object sender, EventArgs e)
        {
            LogicCore.Hook.UsersList.Add(new Admin(UsernameTB.Text,PasswordTB.Text,NameTB.Text,SurnameTB.Text,PeselTB.Text));
            this.Close();
        }

        private void PeselTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void Key_press_fromLetter(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
