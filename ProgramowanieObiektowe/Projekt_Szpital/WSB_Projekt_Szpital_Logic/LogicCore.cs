using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WSB_Projekt_Szpital_Logic
{
    [Serializable]
    public class LogicCore
    {
        [NonSerialized]
        public static LogicCore Hook;

        [XmlArrayItem(typeof(User)), XmlArrayItem(typeof(Admin)), XmlArrayItem(typeof(Doctor)), XmlArrayItem(typeof(Nurse))]
        public List<User> UsersList;

        [XmlArrayItem(typeof(StringModulDoctorSpec))]
        public List<StringModulDoctorSpec> DoctorSpecialization;

        public DatePlaner DataTimePlaner;
        public DatePlaner DataTimePlaner2;

        public bool Error { get; set; }

        public int MinLenghtPassword;

        public const string Path = "DataBase.dat";

        public LogicCore()
        {
            this.Error = false;
            this.UsersList = new List<User>();
            this.DoctorSpecialization = new List<StringModulDoctorSpec>();
            this.DataTimePlaner = new DatePlaner();
            this.DataTimePlaner2 = DatePlaner.Copy(DataTimePlaner);

            this.DoctorSpecialization.Add(new StringModulDoctorSpec("kardiolog"));
            this.DoctorSpecialization.Add(new StringModulDoctorSpec("urolog"));
            this.DoctorSpecialization.Add(new StringModulDoctorSpec("neurolog"));
            this.DoctorSpecialization.Add(new StringModulDoctorSpec("laryngolog"));

            this.MinLenghtPassword = 0;
        }

        public void DatePlanerRefresh()
        {
            if (DataTimePlaner.month < DateTime.Now.Month || (DataTimePlaner.month == 12 && DateTime.Now.Month == 1))
            {
                DataTimePlaner = DataTimePlaner2;
                DataTimePlaner2 = DatePlaner.Copy(new DatePlaner());
            }
        }

        public static bool SerializationToXML(string path, LogicCore core)
        {
            try
            {
                XmlSerializer xmlFormattter = new XmlSerializer(typeof(LogicCore));
                using (StreamWriter streamW = new StreamWriter(path))
                {
                    xmlFormattter.Serialize(streamW, core);
                    streamW.Close();
                }
                return true;
            }
            catch
            {
                core.Error = true;
                return false;
            }
        }

        public static bool DeserializationFromXML(string path, out LogicCore core)
        {
            try
            {
                XmlSerializer xmlFormattter = new XmlSerializer(typeof(LogicCore));
                using (StreamReader streamR = new StreamReader(path))
                {
                    core = (LogicCore)xmlFormattter.Deserialize(streamR);
                    streamR.Close();
                }
                core.Error = false;
                if (core.UsersList.Count == 0) core.Error = true;
                return true;
            }
            catch
            {
                core = new LogicCore();
                core.Error = true;
                return false;
            }
        }

        public static bool Serialization(string path, LogicCore core)
        {
            try
            {
                BinaryFormatter bin = new BinaryFormatter();
                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    bin.Serialize(fStream, core);
                    fStream.Close();
                }
                return true;
            }
            catch
            {
                core.Error = true;
                return false;
            }
        }

        public static bool Deserialization(string path, out LogicCore core)
        {
            try
            {
                BinaryFormatter binFormattter = new BinaryFormatter();
                using (Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    core = (LogicCore)binFormattter.Deserialize(fStream);
                    fStream.Close();
                }
                core.Error = false;
                if (core.UsersList.Count == 0) core.Error = true;
                return true;
            }
            catch
            {
                core = new LogicCore();
                core.Error = true;
                return false;
            }
        }
    }

    [Serializable]
    public class StringModulDoctorSpec
    {
        public string Specjalizacje { get; set; }

        public StringModulDoctorSpec(string text)
        {
            this.Specjalizacje = text;
        }
    }
}
