using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class GameLogic
    {
        private static int k;
        private static int n;
        private static bool firstTurn;
        internal void kset (int set)
        {
            k = set;
        }
        internal void nset(int set)
        {
            n = set;
        }
        internal int kget()
        {
            return k;
        }
        internal int nget()
        {
            return n;
        }
        internal void firstTurnset (bool set)
        {
            firstTurn = set;
        }
        internal bool firstTurnget()
        {
            return firstTurn;
        }
    }
}
