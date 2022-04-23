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
    public partial class UserPanel : Form
    {
        User user;

        public UserPanel(User user)
        {
            this.user = user;

            InitializeComponent();

            NameLB.Text = user.Name;
            SurnameLB.Text = user.Surname;

            RoleLB.Text = user.Role == User.UserRoles.Doctor ? "Lekarz" : "Pielęgniarka";

            RoleListCB.Text = "Wszyscy";
            RoleListCB_SelectedIndexChanged(null, null);

            DateUserGRIDm1.DataSource = LogicCore.Hook.DataTimePlaner.GetDataTimeFromUser(user);
            DateUserGRIDm2.DataSource = LogicCore.Hook.DataTimePlaner2.GetDataTimeFromUser(user);
        }

        private void UserInfoBT_Click(object sender, EventArgs e)
        {
            try
            {
                new UserInfo((User)UsersGrid.SelectedRows[0].DataBoundItem).Show();
            }
            catch
            {
                return;
            }
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
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
                    UsersGrid.Columns["NumberPWZ"].Visible = false;
                    break;
                case "Pielęgniarki":
                    UsersGrid.DataSource = Array.FindAll(LogicCore.Hook.UsersList.ToArray(), x => x.Role == User.UserRoles.Nurse).ToList().ConvertAll(x => (Nurse)x);
                    break;
            }
            UsersGrid.Columns["Username"].Visible = false;
            UsersGrid.Columns["Password"].Visible = false;
            UsersGrid.Columns["Pesel"].Visible = false;
        }

        private void UsersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                new UserInfo((User)UsersGrid.SelectedRows[0].DataBoundItem).Show();
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserInfo(user, true).Show();
        }

        private void ChangePasswordBT_Click(object sender, EventArgs e)
        {
            string buff = user.Password;
            new ChangePassword(user).ShowDialog(this);

            if (user.Password != buff)
            {
                LogicCore.Serialization(LogicCore.Path, LogicCore.Hook);
            }
        }
    }
}
