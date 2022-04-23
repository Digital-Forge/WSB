using RegisterOfPersons.App;
using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegisterOfPersons
{
    partial class Action
    {
        public bool AdvSearcExit = false;
        public bool AdvSearchReload = false;
        private ConsoleMenu AdvSearchMenu;
        private ConsoleMenu filterMenu;
        private List<ActionDataHook> selectedList;

        public void AdvSearch()
        {
            selectedList = LogicCORE<ActionDataHook>.Core.ListOfPersons;

            do
            {
                AdvSearcExit = false;
                AdvSearchReload = false;

                AdvSearchMenu = new ConsoleMenu(SearchMenuStyle);
                AdvSearchMenu.add(new ConsoleColorString("Filter"), filter);
                AdvSearchMenu.add(new ConsoleColorString("Back\n", ConsoleColor.DarkGray), AdvSearchExit);

                var list = LogicCORE<ActionDataHook>.Core.ListOfPersons.OrderBy(x => x.Data.FirstName + x.Data.Surname);

                ConsoleColorString buff = new ConsoleColorString();

                foreach (var item in selectedList)
                {
                    buff.Clear();
                    buff.AddText($"{item.Data.FirstName} {item.Data.Surname}\n", ConsoleColor.Green);
                    buff.AddText($" {item.Data.Sex.ToString()}, Age : {item.Data.Age}\n", ConsoleColor.Yellow);
                    buff.AddText($" Addres : {item.Data.Address.Street} {item.Data.Address.HouseNo}", ConsoleColor.Gray);
                    if (!string.IsNullOrEmpty(item.Data.Address.FlatNo)) buff.AddText($"/{item.Data.Address.FlatNo}", ConsoleColor.Gray);
                    buff.AddText($", {item.Data.Address.PostalCode} {item.Data.Address.City}\n\n", ConsoleColor.Gray);

                    AdvSearchMenu.add(buff.Copy(), item.View);
                }

                AdvSearchMenu.show();
            } while (AdvSearchReload && !AdvSearcExit);
        }

        public void AdvSearchExit()
        {
            if (AdvSearchMenu != null) AdvSearchMenu.exitFunction();
        }

        private void filter()
        {
            filterMenu = new ConsoleMenu(MenuStyle);
            filterMenu.add(new ConsoleColorString("FirstName"), filterFirstName);
            filterMenu.add(new ConsoleColorString("Surname"), filterSurname);
            filterMenu.add(new ConsoleColorString("Sex"), filterSex);
            filterMenu.add(new ConsoleColorString("Age"), filterAge);
            filterMenu.add(new ConsoleColorString("City"), filterCity);

            filterMenu.show();
        }
                
        private void filterFirstName()
        {
            Console.Clear();

            Console.Write("FirstName : ");
            string buff = Console.ReadLine();

            buff = $"{buff}";

            Regex regex = new Regex(buff);

            if (string.IsNullOrEmpty(buff)) selectedList = selectedList.Where(x => string.IsNullOrEmpty(x.Data.FirstName)).ToList();
            else selectedList = selectedList.Where(x => regex.IsMatch(x.Data.FirstName)).ToList();

            filterMenu.exitFunction();
            ActionControler.ReloadSearch();
        }
        
        private void filterSurname()
        {
            Console.Clear();

            Console.Write("Surname : ");
            string buff = Console.ReadLine();

            buff = $"{buff}";

            Regex regex = new Regex(buff);

            if (string.IsNullOrEmpty(buff)) selectedList = selectedList.Where(x => string.IsNullOrEmpty(x.Data.Surname)).ToList();
            else selectedList = selectedList.Where(x => regex.IsMatch(x.Data.Surname)).ToList();

            filterMenu.exitFunction();
            ActionControler.ReloadSearch();
        }

        private void filterSex()
        {
            Console.Clear();

            Sex buff = (Sex)sexSelector();

            selectedList = selectedList.Where(x => x.Data.Sex == buff).ToList();

            filterMenu.exitFunction();
            ActionControler.ReloadSearch();
        }

        private void filterCity()
        {
            Console.Clear();

            Console.Write("City : ");
            string buff = Console.ReadLine();

            buff = $"{buff}";

            Regex regex = new Regex(buff);

            if (string.IsNullOrEmpty(buff)) selectedList = selectedList.Where(x => string.IsNullOrEmpty(x.Data.Address.City)).ToList();
            else selectedList = selectedList.Where(x => regex.IsMatch(x.Data.Address.City)).ToList();

            filterMenu.exitFunction();
            ActionControler.ReloadSearch();
        }
        
        private void filterAge()
        {
            Console.Clear();

            MathOperator operators = (MathOperator)MathOperatorSelector();

            string buff;
            int age;
            string info = "";

            do
            {
                Console.Clear();
                Console.WriteLine(info);

                Console.Write("Age : ");
                buff = Console.ReadLine();

                info = "Wrong number !!!";
            } while (!int.TryParse(buff, out age));

            switch (operators)
            {
                case MathOperator.More:
                    selectedList = selectedList.Where(x => x.Data.Age > age).ToList();
                    break;
                case MathOperator.Less:
                    selectedList = selectedList.Where(x => x.Data.Age < age).ToList();
                    break;
                case MathOperator.Equal:
                    selectedList = selectedList.Where(x => x.Data.Age == age).ToList();
                    break;
                case MathOperator.Different:
                    selectedList = selectedList.Where(x => x.Data.Age != age).ToList();
                    break;
            }

            filterMenu.exitFunction();
            ActionControler.ReloadSearch();
        }

        private Sex? sexSelector()
        {
            string[] enumOption = Enum.GetNames(typeof(Sex));
            if (enumOption.Length == 0) return null;

            int position2 = 0;
            bool back = false;
            ConsoleColorString buff = new ConsoleColorString();
            var Style = DataReaderStyle;

            do
            {
                Console.Clear();

                for (int i = 0; i < enumOption.Length; i++)
                {
                    buff.Clear();
                    if (i == position2)
                    {
                        (Style.TextPrefixOfSelectItem + new ConsoleColorString(enumOption[i], Style.ValueColorOfSelectedItem, Style.ValueBackgroundColorOfSelectedItem)).ConsoleWriteLine();
                    }
                    else
                    {
                        (Style.TextPrefix + new ConsoleColorString(enumOption[i], Style.ValueColor, Style.ValueBackgroundColor)).ConsoleWriteLine();
                    }
                }
                Console.WriteLine();
                Style.ActionDescription.ConsoleWriteLine();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        return (Sex)Enum.Parse(typeof(Sex), enumOption[position2]);
                        back = true;
                        break;
                    case ConsoleKey.UpArrow:
                        position2 = position2 - 1 >= 0 ? position2 - 1 : 0;
                        break;
                    case ConsoleKey.DownArrow:
                        position2 = position2 + 1 < enumOption.Length ? position2 + 1 : position2;
                        break;
                }
            } while (!back);
            back = false;
            return null;
        }

        private MathOperator? MathOperatorSelector()
        {
            string[] enumOption = Enum.GetNames(typeof(MathOperator));
            if (enumOption.Length == 0) return null;

            int position2 = 0;
            bool back = false;
            ConsoleColorString buff = new ConsoleColorString();
            var Style = DataReaderStyle;

            do
            {
                Console.Clear();

                for (int i = 0; i < enumOption.Length; i++)
                {
                    buff.Clear();
                    if (i == position2)
                    {
                        (Style.TextPrefixOfSelectItem + new ConsoleColorString(enumOption[i], Style.ValueColorOfSelectedItem, Style.ValueBackgroundColorOfSelectedItem)).ConsoleWriteLine();
                    }
                    else
                    {
                        (Style.TextPrefix + new ConsoleColorString(enumOption[i], Style.ValueColor, Style.ValueBackgroundColor)).ConsoleWriteLine();
                    }
                }
                Console.WriteLine();
                Style.ActionDescription.ConsoleWriteLine();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        return (MathOperator)Enum.Parse(typeof(MathOperator), enumOption[position2]);
                        back = true;
                        break;
                    case ConsoleKey.UpArrow:
                        position2 = position2 - 1 >= 0 ? position2 - 1 : 0;
                        break;
                    case ConsoleKey.DownArrow:
                        position2 = position2 + 1 < enumOption.Length ? position2 + 1 : position2;
                        break;
                }
            } while (!back);
            back = false;
            return null;
        }
    }
}
