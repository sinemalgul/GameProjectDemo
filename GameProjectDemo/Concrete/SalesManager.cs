using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class SalesManager : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine("User " + gamer.UserName + " bought game " + game.Name);
        }
    }
}
