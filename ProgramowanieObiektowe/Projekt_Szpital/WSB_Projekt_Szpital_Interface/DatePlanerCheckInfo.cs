using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSB_Projekt_Szpital_Interface
{
    public partial class DatePlanerCheckInfo : Form
    {
        public DatePlanerCheckInfo(string text)
        {
            InitializeComponent();
            textBox.Text = text;
        }
    }
}
