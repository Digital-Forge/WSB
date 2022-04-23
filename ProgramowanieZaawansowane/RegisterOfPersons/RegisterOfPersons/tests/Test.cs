using RegisterOfPersons.App;
using RegisterOfPersons.ConsoleTerminal;

using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    static class Test
    {
        public static void test1()
        {
            //CommandsManager.HandleCommands();
        }

        public static void test2()
        {
            ConsoleMenu.MenuStyle baseMenuStyle = new ConsoleMenu.MenuStyle();
            baseMenuStyle.MenuTitle = new ConsoleColorString("----------MENU----------", ConsoleColor.Red, ConsoleColor.Yellow);

            ConsoleMenu menu = new ConsoleMenu(baseMenuStyle);

            menu.add(new ConsoleColorString("Opcja 1"), null);
            menu.add(new ConsoleColorString("Opcja 22"), null);
            menu.add(new ConsoleColorString("Opcja 333"), null);
            menu.add(new ConsoleColorString("Opcja 4444"), null);
            menu.add(new ConsoleColorString("Opcja 55555"), null);
            menu.add(new ConsoleColorString("Opcja 666666"), null);
            menu.add(new ConsoleColorString("Opcja 7777777"), null);
            menu.add(new ConsoleColorString("Opcja 88888888"), null);
            menu.add(new ConsoleColorString("Wypierdalać w podskokach", ConsoleColor.Red, ConsoleColor.DarkMagenta), menu.exitFunction);


            menu.show();
        }

        public static void test3()
        {
            Console.WriteLine("0123456789");
            Console.WriteLine("0123456789");
            Console.WriteLine("0123456789");
            Console.WriteLine("0123456789");
            Console.WriteLine();
            Console.WriteLine(Console.CursorTop);
            Console.WriteLine(Console.CursorLeft);
            Console.WriteLine();
            Console.CursorTop = 2;
            Console.CursorLeft = 3;
            Console.WriteLine(Console.ReadLine());

            Console.ReadLine();
        }

        public static void test4()
        {
            ConsoleTerminal.IConsoleReadable a = new App.Person();

            (a as App.Person).Age = 5;
            (a as App.Person).FirstName = "abba";
            (a as App.Person).Sex = App.Sex.Men;

            var properties = a.GetType().GetProperty("Sex");

            //Console.WriteLine((ConsoleTerminal.IConsoleReadable)properties.GetValue(a));
            Console.WriteLine(properties.GetValue(a));
        }

        public static void test5()
        {
            ConsoleTerminal.IConsoleReadable a = new Person();

            IConsoleDataReader.DataConsoleReaderStyle style = new IConsoleDataReader.DataConsoleReaderStyle();
            style.ValueColor = ConsoleColor.Green;
            style.ValueColorOfSelectedItem = ConsoleColor.Red;
            style.TextMiddleFixOfSelectItem = new ConsoleColorString(" = ");
            style.TextMiddleFix = new ConsoleColorString(" : ");

            new ConsoleDataReader<ConsoleTerminal.IConsoleReadable>(a, style).DataRead();
        }
    }
}
