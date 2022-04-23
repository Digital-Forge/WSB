using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    partial class Action
    {
        public static ConsoleMenu.MenuStyle MenuStyle;
        public static ConsoleMenu.MenuStyle SearchMenuStyle;
        public static IConsoleDataReader.DataConsoleReaderStyle DataReaderStyle;

        public void InitStyleElement()
        {
            InitMenuStyle();
            InitConsoleDataReaderStyle();
            InitSearchMenuStyle();
        }

        private void InitConsoleDataReaderStyle()
        {
            DataReaderStyle = new IConsoleDataReader.DataConsoleReaderStyle();
            DataReaderStyle.ValueColor = ConsoleColor.Green;
            DataReaderStyle.ValueColorOfSelectedItem = ConsoleColor.Red;
            DataReaderStyle.TextMiddleFixOfSelectItem = new ConsoleColorString(" = ");
            DataReaderStyle.TextMiddleFix = new ConsoleColorString(" : ");
        }

        private void InitMenuStyle()
        {
            MenuStyle = new ConsoleMenu.MenuStyle();

            MenuStyle.TextPreFix = new ConsoleColorString("     ");
            MenuStyle.TextPreFixOfSelectOption = new ConsoleColorString(" --> ", ConsoleColor.Cyan);

            MenuStyle.TextPostFix = new ConsoleColorString("     ");
            MenuStyle.TextPostFixOfSelectOption = new ConsoleColorString(" <-- ", ConsoleColor.Cyan);

            MenuStyle.TextColorOfSelectedOptionText = ConsoleColor.DarkGreen;
            MenuStyle.TextBackgroundColorOfSelectedOptionText = ConsoleColor.Gray;
        }

        private void InitSearchMenuStyle()
        {
            SearchMenuStyle = MenuStyle.Clone();
            SearchMenuStyle.TextPostFixOfSelectOption = new ConsoleColorString("");
        }
    }
}
