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
    public partial class DatePlanerActionCopy : Form
    {
        public DatePlanerActionCopy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicCore.Hook.DataTimePlaner2 = DatePlaner.Copy(LogicCore.Hook.DataTimePlaner);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogicCore.Hook.DataTimePlaner = DatePlaner.RewerseCopy(LogicCore.Hook.DataTimePlaner2);
            this.Close();
        }
    }
}
