using RegisterOfPersons.App;
using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RegisterOfPersons
{
    partial class Action
    {
        public bool SearcExit = false;
        public bool SearchReload = false;
        private ConsoleMenu searchMenu;

        public void Search()
        {
            do
            {
                SearcExit = false;
                SearchReload = false;

                searchMenu = new ConsoleMenu(SearchMenuStyle);
                searchMenu.add(new ConsoleColorString("Advanced Search"), AdvSearch);
                searchMenu.add(new ConsoleColorString("Back\n", ConsoleColor.DarkGray), SearchExit);

                var list = LogicCORE<ActionDataHook>.Core.ListOfPersons.OrderBy(x => x.Data.FirstName + x.Data.Surname);

                ConsoleColorString buff = new ConsoleColorString();

                foreach (var item in list)
                {
                    buff.Clear();
                    buff.AddText($"{item.Data.FirstName} {item.Data.Surname}\n", ConsoleColor.Green);
                    buff.AddText($"{item.Data.Sex.ToString()}, Age : {item.Data.Age}\n", ConsoleColor.Yellow);
                    buff.AddText($"Addres {item.Data.Address.Street} {item.Data.Address.HouseNo}", ConsoleColor.Gray);
                    if (string.IsNullOrEmpty(item.Data.Address.FlatNo)) buff.AddText($"/{item.Data.Address.FlatNo}", ConsoleColor.Gray);
                    buff.AddText($", {item.Data.Address.PostalCode} {item.Data.Address.City}\n\n", ConsoleColor.Gray);

                    searchMenu.add(buff.Copy(), item.View);
                }

                searchMenu.show();
            } while (SearchReload && !SearcExit);
        }

        public void SearchExit()
        {
            if (searchMenu != null) searchMenu.exitFunction();
        }
    }
}
