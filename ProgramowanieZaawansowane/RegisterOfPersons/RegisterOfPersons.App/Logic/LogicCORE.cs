using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons.App
{
    public class LogicCORE<T> where T: class
    {
        public static LogicCORE<T> Core;

        public List<T> ListOfPersons;

        public static string DataPath = "RegisterData.dat";

        public LogicCORE()
        {
            Core = this;
            Load();
        }

        public LogicCORE(List<T> list)
        {
            if (list == null) throw new Exception("DataEnvironmentException");
            
            ListOfPersons = list;
            Core = this;
        }

        public void Save()
        {
            if (!Serialization<List<T>>.SerializationToFile(DataPath, ListOfPersons))
            {
                ConsoleAlert.Show("Save error\n Try to save manually", ConsoleColor.Yellow);
            }
        }

        public void Load()
        {
            var buff = Serialization<List< T >>.DeserializationFromFile(DataPath);

            if (buff == null)
            {
                ConsoleAlert.Show("Load error\n Try to load manually\n  Or continue if this first time", ConsoleColor.Yellow);
                ListOfPersons = new List<T>();
            }
            else ListOfPersons = buff;
        }
    }
}
