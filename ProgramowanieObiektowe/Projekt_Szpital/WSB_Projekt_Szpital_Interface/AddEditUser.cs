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
    public partial class AddEditUser : Form
    {
        User BuffUser;
        List<StringModulNurseAbilitie> nurseList;

        private bool blockBoxs = false;

        public AddEditUser()
        {
            BuffUser = null;
            nurseList = new List<StringModulNurseAbilitie>();
            InitializeComponent();
            this.Text = "Dodaj";
            SpecCB.Items.AddRange(LogicCore.Hook.DoctorSpecialization.ConvertAll(x => (string)x.Specjalizacje).ToArray());

            RoleCB.Text = "Admin";
            RoleCB_SelectedIndexChanged(null, null);
            NurseSkillDGV.DataSource = nurseList;
        }

        public AddEditUser(User user)
        {
            BuffUser = user;
            nurseList = null;
            InitializeComponent();
            this.Text = "Edytuj";
            SpecCB.Items.AddRange(LogicCore.Hook.DoctorSpecialization.ToArray());

            loginTB.Text = BuffUser.Username;
            PasswordTB.Text = BuffUser.Password;
            DoublePasswordTB.Text = BuffUser.Password;
            NameTB.Text = BuffUser.Name;
            SurnameTB.Text = BuffUser.Surname;
            PeselTB.Text = BuffUser.Pesel;

            if (user is Admin)
            {
                RoleCB.Text = "Admin";
                RoleCB_SelectedIndexChanged(null, null);
            }
            else if (user is Doctor)
            {
                RoleCB.Text = "Lekarz";
                RoleCB_SelectedIndexChanged(null, null);
                NrPWZTB.Text = (BuffUser as Doctor).NumberPWZ;
                SpecCB.Text = (BuffUser as Doctor).TypeDoctor;
            }
            else
            {
                RoleCB.Text = "Pielęgniarka";
                RoleCB_SelectedIndexChanged(null, null);
                NurseSkillDGV.DataSource = (user as Nurse).Abilities;
            }

            RoleCB.Enabled = false;
        }

        private void VerifyBT_Click(object sender, EventArgs e)
        {
            if (blockBoxs)
            {
                loginTB.Enabled = true;
                PasswordTB.Enabled = true;
                DoublePasswordTB.Enabled = true;
                NameTB.Enabled = true;
                SurnameTB.Enabled = true;
                PeselTB.Enabled = true;

                if (BuffUser == null)
                {
                    RoleCB.Enabled = true;
                }

                NrPWZTB.Enabled = true;
                SpecCB.Enabled = true;

                NurseSkillDGV.Enabled = true;
                NurseSkillAddBT.Enabled = true;
                NurseSkillRemoveBT.Enabled = true;

                blockBoxs = false;
                VerifyBT.Text = "Weryfikuj";
                ConfirmBT.Enabled = false;
            }
            else
            {
                bool exitBuff = false;
                bool emptyBox = false;

                if (loginTB.Text == "")
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

                if (RoleCB.Text == "")
                {
                    emptyBox = true;
                    exitBuff = true;
                }
                else
                {
                    if (RoleCB.Text == "Lekarz")
                    {
                        if (NrPWZTB.Text == "")
                        {
                            NrPWZLB.ForeColor = Color.Red;
                            emptyBox = true;
                            exitBuff = true;
                        }
                        else
                        {
                            NrPWZLB.ForeColor = Color.Black;
                        }

                        if (SpecCB.Text == "" || SpecCB.Text == "--Select--")
                        {
                            SpecLB.ForeColor = Color.Red;
                            emptyBox = true;
                            exitBuff = true;
                        }
                        else
                        {
                            SpecLB.ForeColor = Color.Black;
                        }

                        if (!Methods.CheckPWZ(NrPWZTB.Text))
                        {
                            NrPWZLB.ForeColor = Color.Red;
                            exitBuff = true;
                            MessageBox.Show("Niezgodny identyfikator PWZ", "Zły Numer PWZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
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

                for (int i = 0; i < LogicCore.Hook.UsersList.Count(); i++)
                {
                    if (LogicCore.Hook.UsersList[i].Username == loginTB.Text)
                    {
                        if (BuffUser != null)
                        {
                            if (BuffUser.Username == loginTB.Text)
                            {
                                break;
                            }
                        }

                        exitBuff = true;
                        LoginLB.ForeColor = Color.Red;
                        MessageBox.Show("Taki login już istnieje", "Login zajęty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (PasswordTB.Text.Length < LogicCore.Hook.MinLenghtPassword)
                {
                    exitBuff = true;
                    PasswordLB.ForeColor = Color.Red;
                    MessageBox.Show($"Hasło nie spełnia minimalnej długości ({LogicCore.Hook.MinLenghtPassword})", "Za któtkie hasło", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PasswordLB.ForeColor = Color.Black;
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

                loginTB.Enabled = false;
                PasswordTB.Enabled = false;
                DoublePasswordTB.Enabled = false;
                NameTB.Enabled = false;
                SurnameTB.Enabled = false;
                PeselTB.Enabled = false;

                RoleCB.Enabled = false;

                NrPWZTB.Enabled = false;
                SpecCB.Enabled = false;

                NurseSkillDGV.Enabled = false;
                NurseSkillAddBT.Enabled = false;
                NurseSkillRemoveBT.Enabled = false;

                blockBoxs = true;
                VerifyBT.Text = "Zmień";
                ConfirmBT.Enabled = true;
            }
        }

        private void ConfirmBT_Click(object sender, EventArgs e)
        {
            if (BuffUser == null)
            {
                switch (RoleCB.Text)
                {
                    case "Admin":
                        LogicCore.Hook.UsersList.Add(new Admin(loginTB.Text, PasswordTB.Text, NameTB.Text, SurnameTB.Text, PeselTB.Text));
                        break;
                    case "Lekarz":
                        LogicCore.Hook.UsersList.Add(new Doctor(loginTB.Text, PasswordTB.Text, NameTB.Text, SurnameTB.Text, PeselTB.Text,NrPWZTB.Text, SpecCB.Text));
                        break;
                    case "Pielęgniarka":
                        LogicCore.Hook.UsersList.Add(new Nurse(loginTB.Text, PasswordTB.Text, NameTB.Text, SurnameTB.Text, PeselTB.Text));
                        (LogicCore.Hook.UsersList[LogicCore.Hook.UsersList.Count - 1] as Nurse).Abilities = nurseList;
                        break;
                }

                loginTB.Clear();
                PasswordTB.Clear();
                DoublePasswordTB.Clear();
                NameTB.Clear();
                SurnameTB.Clear();
                PeselTB.Clear();
                NrPWZTB.Clear();
                SpecCB.SelectedIndex = -1;
                nurseList = new List<StringModulNurseAbilitie>();
                NurseSkillDGV.DataSource = nurseList.ToArray();

                VerifyBT_Click(null, null);
            }
            else
            {
                BuffUser.Username = loginTB.Text;
                BuffUser.Password = PasswordTB.Text;
                BuffUser.Name = NameTB.Text;
                BuffUser.Surname = SurnameTB.Text;
                BuffUser.Pesel = PeselTB.Text;

                if (RoleCB.Text == "Lekarz")
                {
                    (BuffUser as Doctor).NumberPWZ = NrPWZTB.Text;
                    (BuffUser as Doctor).TypeDoctor = SpecCB.Text;
                }

                this.Close();
            }
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

        private void RoleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RoleCB.Text)
            {
                case "Admin":
                    NrPWZLB.Visible = false;
                    NrPWZTB.Visible = false;
                    SpecCB.Visible = false;
                    SpecLB.Visible = false;

                    NurseSkillDGV.Visible = false;
                    NurseKursLB.Visible = false;
                    NurseSkillAddBT.Visible = false;
                    NurseSkillRemoveBT.Visible = false;

                    VerifyBT.Location = new Point(96, 195);
                    ConfirmBT.Location = new Point(226, 195);

                    this.MinimumSize = new Size(329, 263);
                    this.Size = new Size(329, 263);
                    this.MaximumSize = new Size(329, 263);
                    break;
                case "Lekarz":
                    NrPWZLB.Visible = true;
                    NrPWZTB.Visible = true;
                    SpecCB.Visible = true;
                    SpecLB.Visible = true;

                    NurseSkillDGV.Visible = false;
                    NurseKursLB.Visible = false;
                    NurseSkillAddBT.Visible = false;
                    NurseSkillRemoveBT.Visible = false;

                    VerifyBT.Location = new Point(96, 248);
                    ConfirmBT.Location = new Point(226, 248);

                    this.MinimumSize = new Size(329, 317);
                    this.Size = new Size(329, 317);
                    this.MaximumSize = new Size(329, 317);

                    SpecCB.Text = "--Select--";
                    break;
                case "Pielęgniarka":
                    NrPWZLB.Visible = false;
                    NrPWZTB.Visible = false;
                    SpecCB.Visible = false;
                    SpecLB.Visible = false;

                    NurseSkillDGV.Visible = true;
                    NurseKursLB.Visible = true;
                    NurseSkillAddBT.Visible = true;
                    NurseSkillRemoveBT.Visible = true;

                    VerifyBT.Location = new Point(96, 387);
                    ConfirmBT.Location = new Point(226, 387);

                    this.MinimumSize = new Size(329, 459);
                    this.Size = new Size(329, 459);
                    this.MaximumSize = new Size(329, 459);
                    break;
            }
        }

        private void NurseSkillAddBT_Click(object sender, EventArgs e)
        {
            if (BuffUser == null)
            {
                nurseList.Add(new StringModulNurseAbilitie());
                NurseSkillDGV.DataSource = nurseList.ToArray();
            }
            else
            {
                (BuffUser as Nurse).Abilities.Add(new StringModulNurseAbilitie());
                NurseSkillDGV.DataSource = (BuffUser as Nurse).Abilities.ToArray();
            }
        }

        private void NurseSkillRemoveBT_Click(object sender, EventArgs e)
        {
            StringModulNurseAbilitie text = new StringModulNurseAbilitie();
            try
            {
                text = (StringModulNurseAbilitie)NurseSkillDGV.SelectedRows[0].DataBoundItem;
            }
            catch 
            {
                MessageBox.Show("Proszę wybrać pole do usunięcia", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (BuffUser == null)
            {
                nurseList.Remove(text);
                NurseSkillDGV.DataSource = nurseList.ToArray();
            }
            else
            {
                (BuffUser as Nurse).Abilities.Remove(text);
                NurseSkillDGV.DataSource = (BuffUser as Nurse).Abilities.ToArray();
            }
        }
    }
}
