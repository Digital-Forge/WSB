using RegisterOfPersons.App;
using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    partial class Action
    {
        void Add()
        {
            IConsoleDataReader read = new ConsoleDataReader<Person>(new Person(), DataReaderStyle);
            read.DataRead();

            LogicCORE<ActionDataHook>.Core.ListOfPersons.Add(new ActionDataHook((Person)read.GetReadObject));
            LogicCORE<ActionDataHook>.Core.Save();
        }
    }
}
