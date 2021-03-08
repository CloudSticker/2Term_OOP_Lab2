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
        internal void kset(int set)
        {
            k = set;
        }
        private static int n;
        private static bool firstTurn;
        private static int availableTurns;
        private static int resultOfGame;
        
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
        internal void aset(int set)
        {
            availableTurns = set;
        }
        internal int aget()
        {
            return availableTurns;
        }
        internal void recount() 
        {
            if (availableTurns > n)
                availableTurns = n;
        }
        internal bool playerTurn(int del)
        {
            n -= del;
            if (n == 0)
            {
                return false; 
            }
            return true;
        }
        internal bool aiTurn()
        {
            if (n != 0) 
            {

                if (n > availableTurns)
                {
                    n -= availableTurns;
                    return true;
                } else if (n == availableTurns+1) {
                    
                }
                
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
