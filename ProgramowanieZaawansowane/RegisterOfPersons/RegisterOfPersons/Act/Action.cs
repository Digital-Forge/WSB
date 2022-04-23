using RegisterOfPersons.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    partial class Action
    {
        public Action()
        {
            LogicCORE<ActionDataHook>.Core = new LogicCORE<ActionDataHook>();
            InitStyleElement();
            ActionControler.pointer = this;
        }

        public void Run()
        {
            MainMenu();
        }
    }
}
