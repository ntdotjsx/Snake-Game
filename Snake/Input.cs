using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Input
    {
        private static Hashtable keyTable = new Hashtable();

        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        public static void ChangeState(KeyEventArgs key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
