using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons
{
    static class ActionControler
    {
        public static Action pointer;

        public static void ReloadSearch()
        {
            pointer.SearchReload = true;
            pointer.SearchExit();

            pointer.AdvSearchReload = true;
            pointer.AdvSearchExit();
        }

        public static void ExitAdvSearch()
        {
            pointer.AdvSearchExit();
            pointer.AdvSearcExit = true;
        }
    }
}
