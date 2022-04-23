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
    public partial class AdminPanelForm : Form
    {
        public bool StartMode { private set; get; }

        bool firstAdminError = false;

        bool dateInNow = true;

        User user;

        public AdminPanelForm(User user, bool startMode = false)
        {
            this.StartMode = startMode;

            InitializeComponent();

            this.user = user;

            if (this.StartMode)
            {
                FirstAdmin buff = new FirstAdmin();
                buff.ShowDialog(this);

                if (LogicCore.Hook.UsersList.Count == 0)
                {
                    firstAdminError = true;
                    return;
                }
                else
                {
                    LogicCore.Hook.Error = false;
                    this.user = LogicCore.Hook.UsersList[0];
                    
                }
            }
            RoleListCB.Text = "Wszyscy";
            RoleListCB_SelectedIndexChanged(null, null);

            DatePlanerAddCB.Text = "Wszyscy";
            DatePlanerAddCB_SelectedIndexChanged(null, null);

            DatePlanerRemoveCB.Text = "Wszyscy";
            DatePlanerRemoveCB_SelectedIndexChanged(null, null);

            PasswordLenghtNB.Value = LogicCore.Hook.MinLenghtPassword;
            DoctorSpecGRID.DataSource = LogicCore.Hook.DoctorSpecialization.ToArray();

            tabPage3_Enter(null, null);
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            if (firstAdminError)
            {
                this.Close();
            }
        }

        private void AdminPanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LogicCore.Hook != null)
            {
                LogicCore.Serialization(LogicCore.Path, LogicCore.Hook);
            }
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            RoleListCB_SelectedIndexChanged(null, null);
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            new AddEditUser().ShowDialog(this);
            RoleListCB_SelectedIndexChanged(null, null);

        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            User user = null;
            try
            {
                user = UsersGrid.SelectedRows[0].DataBoundItem as User;
            }
            catch
            {
                MessageBox.Show("Proszę wybrać użytkownika do edycji", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            for (int i = 0; i < LogicCore.Hook.UsersList.Count(); i++)
            {
                if (user.Username == LogicCore.Hook.UsersList[i].Username)
                {
                    new AddEditUser(LogicCore.Hook.UsersList[i]).ShowDialog(this);
                    break;
                }
            }
            RoleListCB_SelectedIndexChanged(null, null);
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            User user = null;
            try
            {
                user = UsersGrid.SelectedRows[0].DataBoundItem as User;
            }
            catch
            {
                MessageBox.Show("Proszę wybrać użytkownika do usunięcia", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            for (int i = 0; i < LogicCore.Hook.UsersList.Count(); i++)
            {
                if (user.Username == LogicCore.Hook.UsersList[i].Username)
                {
                    if (MessageBox.Show($"Czy napewno chcesz usunąć użytkownika : {user.Role} - {user.Name} {user.Surname} ?", "Czy usunąć ?", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        LogicCore.Hook.UsersList.RemoveAt(i);
                    }
                    break;
                }
            }
            RoleListCB_SelectedIndexChanged(null, null);
        }

        private void RoleListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RoleListCB.Text)
            {
                case "Wszyscy":
                    UsersGrid.DataSource = LogicCore.Hook.UsersList.ToArray();
                    break;
                case "Administratorzy":
                    UsersGrid.DataSource = Array.FindAll(LogicCore.Hook.UsersList.ToArray(), x => x.Role == User.UserRoles.Admin).ToList().ConvertAll(x => (Admin)x);
                    break;
                case "Lekarze":
                    UsersGrid.DataSource = Array.FindAll(LogicCore.Hook.UsersList.ToArray(), x => x.Role == User.UserRoles.Doctor).ToList().ConvertAll(x => (Doctor)x);
                    break;
                case "Pielęgniarki":
                    UsersGrid.DataSource = Array.FindAll(LogicCore.Hook.UsersList.ToArray(), x => x.Role == User.UserRoles.Nurse).ToList().ConvertAll(x => (Nurse)x);
                    break;
            }
            UsersGrid.Columns["Password"].Visible = false;
        }

        private void UserInfoBT_Click(object sender, EventArgs e)
        {
            try
            {
                new UserInfo((User)UsersGrid.SelectedRows[0].DataBoundItem, true).Show();
            }
            catch
            {
                return;
            }
        }

        private void UsersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatePlanerAddBT_Click(object sender, EventArgs e)
        {
            if (dateInNow)
            {
                try
                {
                    LogicCore.Hook.DataTimePlaner.Add(DatePlanerDT.Value.Day, (User)DatePlanerAddGRID.SelectedRows[0].DataBoundItem);
                }
                catch 
                {
                    return;
                }
            }
            else
            {
                try
                {
                    LogicCore.Hook.DataTimePlaner2.Add(DatePlanerDT.Value.Day, (User)DatePlanerAddGRID.SelectedRows[0].DataBoundItem);
                }
                catch
                {
                    return;
                }
            }
            DatePlanerRemoveCB_SelectedIndexChanged(null, null);
        }

        private void DatePlanerRemoveBT_Click(object sender, EventArgs e)
        {
            if (dateInNow)
            {
                try
                {
                    LogicCore.Hook.DataTimePlaner.Remove(DatePlanerDT.Value.Day, (User)DatePlanerRemoveGRID.SelectedRows[0].DataBoundItem);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                try
                {
                    LogicCore.Hook.DataTimePlaner2.Remove(DatePlanerDT.Value.Day, (User)DatePlanerRemoveGRID.SelectedRows[0].DataBoundItem);
                }
                catch
                {
                    return;
                }
            }
            DatePlanerRemoveCB_SelectedIndexChanged(null, null);
        }

        private void DatePlanerAddCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (DatePlanerAddCB.Text)
            {
                case "Wszyscy":
                    DatePlanerAddGRID.DataSource = Array.FindAll(LogicCore.Hook.UsersList.ToArray(), x => x.Role == User.UserRoles.Doctor || x.Role == User.UserRoles.Nurse);
                    break;
                case "Lekarze":
                    DatePlanerAddGRID.DataSource = Array.FindAll(LogicCore.Hook.UsersList.ToArray(), x => x.Role == User.UserRoles.Doctor).ToList().ConvertAll(x => (Doctor)x);
                    DatePlanerAddGRID.Columns["NumberPWZ"].Visible = false;
                    break;
                case "Pielęgniarki":
                    DatePlanerAddGRID.DataSource = Array.FindAll(LogicCore.Hook.UsersList.ToArray(), x => x.Role == User.UserRoles.Nurse);
                    break;
            }
            DatePlanerAddGRID.Columns["Username"].Visible = false;
            DatePlanerAddGRID.Columns["Password"].Visible = false;
            DatePlanerAddGRID.Columns["Pesel"].Visible = false;
        }

        private void DatePlanerRemoveCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DatePlanerRemoveCB.Text)
            {
                case "Wszyscy":
                    if (dateInNow)
                    {
                        DatePlanerRemoveGRID.DataSource = LogicCore.Hook.DataTimePlaner.GetDayUserList(DatePlanerDT.Value.Day);
                    }
                    else
                    {
                        DatePlanerRemoveGRID.DataSource = LogicCore.Hook.DataTimePlaner2.GetDayUserList(DatePlanerDT.Value.Day);
                    }
                    break;
                case "Lekarze":
                    if (dateInNow)
                    {
                        DatePlanerRemoveGRID.DataSource = Array.FindAll(LogicCore.Hook.DataTimePlaner.GetDayUserList(DatePlanerDT.Value.Day).ToArray(), x => x is Doctor).ToList().ConvertAll(x => (Doctor)x);
                    }
                    else
                    {
                        DatePlanerRemoveGRID.DataSource = Array.FindAll(LogicCore.Hook.DataTimePlaner.GetDayUserList(DatePlanerDT.Value.Day).ToArray(), x => x is Nurse);
                    }
                    DatePlanerRemoveGRID.Columns["NumberPWZ"].Visible = false;
                    break;
                case "Pielęgniarki":
                    if (dateInNow)
                    {
                        DatePlanerRemoveGRID.DataSource = LogicCore.Hook.DataTimePlaner.GetDayUserList(DatePlanerDT.Value.Day);
                    }
                    else
                    {
                        DatePlanerRemoveGRID.DataSource = LogicCore.Hook.DataTimePlaner2.GetDayUserList(DatePlanerDT.Value.Day);
                    }
                    break;
            }
            DatePlanerRemoveGRID.Columns["Username"].Visible = false;
            DatePlanerRemoveGRID.Columns["Password"].Visible = false;
            DatePlanerRemoveGRID.Columns["Pesel"].Visible = false;
        }

        private void DatePlanerDT_ValueChanged(object sender, EventArgs e)
        {
            if (DatePlanerDT.Value.Month == LogicCore.Hook.DataTimePlaner.month)
            {
                dateInNow = true;
            }
            else if (DatePlanerDT.Value.Month == LogicCore.Hook.DataTimePlaner2.month)
            {
                dateInNow = false;
            }
            else
            {
                if (dateInNow)
                {
                    DatePlanerDT.Value = new DateTime(LogicCore.Hook.DataTimePlaner.year, LogicCore.Hook.DataTimePlaner.month, DatePlanerDT.Value.Day);
                }
                else
                {
                    DatePlanerDT.Value = new DateTime(LogicCore.Hook.DataTimePlaner2.year, LogicCore.Hook.DataTimePlaner2.month, DatePlanerDT.Value.Day);

                }
                DatePlanerDT_ValueChanged(null, null);
                return;
            }
            DatePlanerRemoveCB_SelectedIndexChanged(null, null);
        }

        private void DatePlanerCheckBT_Click(object sender, EventArgs e)
        {
            if (dateInNow)
            {
                if (LogicCore.Hook.DataTimePlaner.Check())
                {
                    MessageBox.Show("Grafik jest ułożony poprawnie", "Sprawdzenie grafiku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    new DatePlanerCheckInfo(LogicCore.Hook.DataTimePlaner.CheckInfo).Show();
                }
            }
            else
            {
                if (LogicCore.Hook.DataTimePlaner2.Check())
                {
                    MessageBox.Show("Grafik jest ułożony poprawnie", "Sprawdzenie grafiku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    new DatePlanerCheckInfo(LogicCore.Hook.DataTimePlaner2.CheckInfo).Show();
                }
            }
        }

        private void ChangePasswordBT_Click(object sender, EventArgs e)
        {
            new ChangePassword(user).ShowDialog(this);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            NameLB.Text = user.Name;
            SurnameLB.Text = user.Surname;

            HowManyPeopleLB.Text = $"Liczba użytkowników : {LogicCore.Hook.UsersList.Count}";
            WrongPasswordLB.Text = $"Ilość niepoprawnych haseł : {LogicCore.Hook.UsersList.ToArray().Count(x => x.Password.Length < LogicCore.Hook.MinLenghtPassword)}";
            lenghtPasswordLB.Text = $"Minimalna długość hasła : {LogicCore.Hook.MinLenghtPassword}";
            DocSpecNumberLB.Text = $"Liczba specjalizacji lekarzy : {LogicCore.Hook.DoctorSpecialization.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserInfo(user, true).Show();
        }

        private void AddSpecBT_Click(object sender, EventArgs e)
        {
            LogicCore.Hook.DoctorSpecialization.Add(new StringModulDoctorSpec(""));
            DoctorSpecGRID.DataSource = LogicCore.Hook.DoctorSpecialization.ToArray();
        }

        private void RemoveSpecBT_Click(object sender, EventArgs e)
        {
            StringModulDoctorSpec spec = null;
            try
            {
                spec = (StringModulDoctorSpec)DoctorSpecGRID.SelectedRows[0].DataBoundItem;
            }
            catch
            {
                MessageBox.Show("Proszę wybrać specjalizację do usunięcia", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LogicCore.Hook.DoctorSpecialization.Remove(spec);
            DoctorSpecGRID.DataSource = LogicCore.Hook.DoctorSpecialization.ToArray();
        }

        private void PasswordLenghtNB_ValueChanged(object sender, EventArgs e)
        {
            LogicCore.Hook.MinLenghtPassword = Convert.ToInt32(PasswordLenghtNB.Value);
        }

        private void DatePlanerCopyBT_Click(object sender, EventArgs e)
        {
            new DatePlanerActionCopy().ShowDialog(this);

            DatePlanerAddCB_SelectedIndexChanged(null, null);
            DatePlanerRemoveCB_SelectedIndexChanged(null, null);
        }

        private void DatePlanerResetBT_Click(object sender, EventArgs e)
        {
            new DatePlanerActionReset().ShowDialog(this);

            DatePlanerAddCB_SelectedIndexChanged(null, null);
            DatePlanerRemoveCB_SelectedIndexChanged(null, null);
        }

        private void ImportExportBT_Click(object sender, EventArgs e)
        {

            DataBaseImportExport buff = new DataBaseImportExport();
            buff.Owner = this;
            buff.ShowDialog(this);
        }
    }
}
