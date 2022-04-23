using RegisterOfPersons.App;
using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    partial class Action
    {
        public void ManualOptions()
        {
            var menu = new ConsoleMenu(MenuStyle);
            menu.add(new ConsoleColorString("Manual Save"), LogicCORE<ActionDataHook>.Core.Save);
            menu.add(new ConsoleColorString("Manual Load"), LogicCORE<ActionDataHook>.Core.Load);
            menu.add(new ConsoleColorString("Back", ConsoleColor.DarkGray), menu.exitFunction);

            menu.show();
        }
    }
}
