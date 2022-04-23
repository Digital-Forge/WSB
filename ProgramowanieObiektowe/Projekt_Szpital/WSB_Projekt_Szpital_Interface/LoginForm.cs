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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            LogicCore.Deserialization(LogicCore.Path, out LogicCore.Hook);

            LogicCore.Hook.DatePlanerRefresh();

            InitializeComponent();

            if (LogicCore.Hook.Error)
            {
                MessageBox.Show("Nie znaleziono Bazy Danych skontaktuj się z administratorem systemu", "DataBase No Found", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Click_LoginBT(object sender, EventArgs e)
        {
            LoginErrorLB.Visible = LoginTB.Text == "" || PasswordTB.Text == "" ? true : false;

            if (LogicCore.Hook.Error)
            {
                if (LoginTB.Text == "ADMIN" && PasswordTB.Text == "ADMIN")
                {
                    LoginErrorLB.Visible = false;
                    this.Visible = false;
                    new AdminPanelForm(null, true).ShowDialog(this);
                    this.Visible = true;
                    return;
                }
            }
            else
            {
                for (int i = 0; i < LogicCore.Hook.UsersList.Count; i++)
                {
                    if (LogicCore.Hook.UsersList[i].Username == LoginTB.Text)
                    {
                        if (LogicCore.Hook.UsersList[i].Password == PasswordTB.Text)
                        {
                            LoginErrorLB.Visible = false;
                            this.Visible = false;

                            if (LogicCore.Hook.UsersList[i].Password.Length < LogicCore.Hook.MinLenghtPassword)
                            {
                                if (MessageBox.Show($"Twoje hasło nie spełnia minimalnej długości ({LogicCore.Hook.MinLenghtPassword}) czy chcesz je zmienić", "Za krótkie hasło", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
                                {
                                    string buff = LogicCore.Hook.UsersList[i].Password;
                                    new ChangePassword(LogicCore.Hook.UsersList[i]).ShowDialog(this);

                                    if (LogicCore.Hook.UsersList[i].Password != buff)
                                    {
                                        LogicCore.Serialization(LogicCore.Path, LogicCore.Hook);
                                    }
                                }
                            }
                            else
                            {
                                if (LogicCore.Hook.UsersList[i].Role == User.UserRoles.Admin)
                                {
                                    new AdminPanelForm(LogicCore.Hook.UsersList[i]).ShowDialog(this);
                                }
                                else
                                {
                                    new UserPanel(LogicCore.Hook.UsersList[i]).ShowDialog(this);
                                }
                            }

                            this.Visible = true;
                            LoginTB.Clear();
                            PasswordTB.Clear();

                            if (LogicCore.Hook == null)
                            {
                                this.Close();
                            }

                            return;
                        }
                        else
                        {
                            break;
                        }  
                    }
                }
            }
            LoginErrorLB.Visible = true;
        }

        private void PasswordCHB_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB.PasswordChar = PasswordCHB.Checked ? '\0' : '*';
        }
    }
}
