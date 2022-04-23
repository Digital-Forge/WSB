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
    public partial class DatePlanerActionReset : Form
    {
        public DatePlanerActionReset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicCore.Hook.DataTimePlaner = new DatePlaner();
            LogicCore.Hook.DataTimePlaner2 = DatePlaner.Copy(LogicCore.Hook.DataTimePlaner);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogicCore.Hook.DataTimePlaner = new DatePlaner(LogicCore.Hook.DataTimePlaner.month, LogicCore.Hook.DataTimePlaner.year); ;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogicCore.Hook.DataTimePlaner2 = new DatePlaner(LogicCore.Hook.DataTimePlaner2.month, LogicCore.Hook.DataTimePlaner2.year); ;
            this.Close();
        }
    }
}
