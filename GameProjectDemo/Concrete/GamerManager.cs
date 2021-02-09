using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GamerManager:IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer) == true)
            {
                Console.WriteLine("Record added");
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Record deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Record updated");
        }
    }
}
