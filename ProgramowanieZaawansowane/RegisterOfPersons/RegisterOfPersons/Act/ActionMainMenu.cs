using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    partial class Action
    {
        public void MainMenu()
        {
            var MainMenuStyle = MenuStyle.Clone();
            MainMenuStyle.MenuTitle = new ConsoleColorString("--- ");
            MainMenuStyle.MenuTitle.AddText("Register Of Persons", ConsoleColor.Black, ConsoleColor.White);
            MainMenuStyle.MenuTitle.AddText(" ---");

            ConsoleMenu menu = new ConsoleMenu(MainMenuStyle);
            menu.add(new ConsoleColorString("    Search    "), Search);
            menu.add(new ConsoleColorString("Add new person"), Add);
            menu.add(new ConsoleColorString("Manual  Option"), ManualOptions);
            menu.add(new ConsoleColorString("EXIT", ConsoleColor.DarkGray), menu.exitFunction);

            menu.show();
        }
    }
}
