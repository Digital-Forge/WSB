using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons.ConsoleTerminal
{
    public interface IConsoleDataReader
    {
        object GetReadObject { get; }
        Type GetReadObjectType { get; }
        DataConsoleReaderStyle Style { get; set; }

        void DataRead();

        class DataConsoleReaderStyle
        {
            public ConsoleColor? DescriptionColorOfSelectedItem;
            public ConsoleColor? DescriptionBackgroundColorOfSelectedItem;

            public ConsoleColor? ValueColorOfSelectedItem;
            public ConsoleColor? ValueBackgroundColorOfSelectedItem;

            public ConsoleColor? ValueColor;
            public ConsoleColor? ValueBackgroundColor;

            public ConsoleColorString TextPrefixOfSelectItem;
            public ConsoleColorString TextMiddleFixOfSelectItem;

            public ConsoleColorString TextPrefix;
            public ConsoleColorString TextMiddleFix;

            public ConsoleColorString ActionDescription;

            public DataConsoleReaderStyle()
            {
                DescriptionColorOfSelectedItem = null;
                DescriptionBackgroundColorOfSelectedItem = null;

                ValueColorOfSelectedItem = null;
                ValueBackgroundColorOfSelectedItem = null;

                ValueColor = null;
                ValueBackgroundColor = null;

                TextPrefixOfSelectItem = new ConsoleColorString(" -> ");
                TextMiddleFixOfSelectItem = new ConsoleColorString(" : ");

                TextPrefix = new ConsoleColorString("    ");
                TextMiddleFix = new ConsoleColorString(" : ");

                ActionDescription = new ConsoleColorString("Enter - edit/save, Arrow Up/Down, Backspace - back");
            }

            
        }
    }
}
