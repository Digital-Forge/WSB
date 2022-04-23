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
    public partial class UserInfo : Form
    {
        public UserInfo(User user, bool adminMode = false)
        {
            InitializeComponent();

            NameLB.Text = user.Name;
            SurnameLB.Text = user.Surname;
            RoleLB.Text = user.Role.ToString();

            if (adminMode)
            {
                DatePlanerTP.Size = new Size(310, 274);
                LoginLB.Text = user.Username;
                PeselLB.Text = user.Pesel;
            }

            switch (user.Role)
            {
                case User.UserRoles.Admin:
                    NurseGRID.Visible = false;
                    DoctorSpecLB.Visible = false;
                    DoctorSpecTextLB.Visible = false;
                    NurseTextLB.Visible = false;
                    PWZLB.Visible = false;
                    PWZTextLB.Visible = false;
                    break;
                case User.UserRoles.Doctor:
                    if (adminMode)
                    {
                        PWZLB.Text = (user as Doctor).NumberPWZ;
                    }

                    DoctorSpecLB.Text = (user as Doctor).TypeDoctor;

                    NurseGRID.Visible = false;
                    NurseTextLB.Visible = false;
                    break;
                case User.UserRoles.Nurse:
                    NurseGRID.DataSource = (user as Nurse).Abilities;
                    DoctorSpecLB.Visible = false;
                    DoctorSpecTextLB.Visible = false;
                    PWZLB.Visible = false;
                    PWZTextLB.Visible = false;
                    break;
            }

            FirstMonthGRID.DataSource = LogicCore.Hook.DataTimePlaner.GetDataTimeFromUser(user);
            SecendMonthGRID.DataSource = LogicCore.Hook.DataTimePlaner2.GetDataTimeFromUser(user);

        }
    }
}
