using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSB_Projekt_Szpital_Logic;

namespace WSB_Projekt_Szpital_Interface
{
    public partial class DataBaseImportExport : Form
    {
        public DataBaseImportExport()
        {
            InitializeComponent();
            comboBox1.Text = ".dat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz bezpowrotnie usunąć bazę danych ?","Usuwanie bazy danych",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(LogicCore.Path);
                }
                catch 
                {
                    MessageBox.Show("Nie udało się");
                }

                LogicCore.Hook = null;
                Owner.Close();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz nadpisać obecną bazę danych ?", "Importowanie Bazy Danych",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                switch (comboBox1.Text)
                {
                    case ".dat":

                        using (OpenFileDialog dialog = new OpenFileDialog())
                        {
                            dialog.RestoreDirectory = true;
                            dialog.Filter = "*.dat|*.dat| all files (*.*)|*.*";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                LogicCore buff;
                                if (LogicCore.Deserialization(dialog.FileName, out buff))
                                {
                                    LogicCore.Hook = buff;
                                    Owner.Close();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Operacja się nie powiodła");
                                }
                            }
                        }
                        break;
                    case ".xml":
                        using (OpenFileDialog dialog = new OpenFileDialog())
                        {
                            dialog.RestoreDirectory = true;
                            dialog.Filter = "*.xml|*.xml| all files (*.*)|*.*";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                LogicCore buff;
                                if (LogicCore.DeserializationFromXML(dialog.FileName, out buff))
                                {
                                    LogicCore.Hook = buff;
                                    Owner.Close();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Operacja się nie powiodła");
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case ".dat":

                    using (SaveFileDialog dialog = new SaveFileDialog())
                    {
                        dialog.RestoreDirectory = true;
                        dialog.Filter = "*.dat|*.dat| all files (*.*)|*.*";

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            if (!LogicCore.Serialization(dialog.FileName, LogicCore.Hook))
                            {
                                MessageBox.Show("Operacja się nie powiodła");
                            }
                        }
                    }
                    break;
                case ".xml":
                    using (SaveFileDialog dialog = new SaveFileDialog())
                    {
                        dialog.RestoreDirectory = true;
                        dialog.Filter = "*.xml|*.xml| all files (*.*)|*.*";

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            if (!LogicCore.SerializationToXML(dialog.FileName, LogicCore.Hook))
                            {
                                MessageBox.Show("Operacja się nie powiodła");
                            }
                        }
                    }
                    break;
            }
        }
    }
}
