using RegisterOfPersons.App;
using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    [Serializable]
    public class ActionDataHook
    {
        public Person Data;

        [NonSerialized]
        private ConsoleMenu menu;
        [NonSerialized]
        private bool exit = false;
        [NonSerialized]
        private bool reload = false;

        public ActionDataHook(Person p)
        {
            Data = p;
        }

        public void View()
        {
            do
            {
                exit = false;
                reload = false;

                var style = Action.SearchMenuStyle.Clone();

                style.MenuTitle = new ConsoleColorString($"{Data.FirstName} {Data.Surname}\n", ConsoleColor.Green);
                style.MenuTitle.AddText($" {Data.Sex.ToString()}, Age : {Data.Age}\n", ConsoleColor.Yellow);
                style.MenuTitle.AddText($" Addres : {Data.Address.Street} {Data.Address.HouseNo}", ConsoleColor.Gray);
                if (!string.IsNullOrEmpty(Data.Address.FlatNo)) style.MenuTitle.AddText($"/{Data.Address.FlatNo}", ConsoleColor.Gray);
                style.MenuTitle.AddText($", {Data.Address.PostalCode} {Data.Address.City}\n\n", ConsoleColor.Gray);


                menu = new ConsoleMenu(style);
                menu.add(new ConsoleColorString("Edit", ConsoleColor.Yellow), Edit);
                menu.add(new ConsoleColorString("Delete", ConsoleColor.Red), Delete);
                menu.add(new ConsoleColorString("Back\n", ConsoleColor.DarkGray), menu.exitFunction);

                menu.show();
            } while (reload && !exit);
        }

        public void Delete()
        {
            LogicCORE<ActionDataHook>.Core.ListOfPersons.Remove(this);
            LogicCORE<ActionDataHook>.Core.Save();

            if (menu != null) menu.exitFunction();
            exit = true;

            ActionControler.ReloadSearch();
            ActionControler.ExitAdvSearch();
        }

        public void Edit()
        {
            IConsoleDataReader read = new ConsoleDataReader<Person>(Data, Action.DataReaderStyle);
            read.DataRead();

            LogicCORE<ActionDataHook>.Core.Save();

            if (menu != null) menu.exitFunction();
            reload = true;

            ActionControler.ReloadSearch();
        }
    }
}
