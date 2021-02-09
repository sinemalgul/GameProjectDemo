using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { FirstName = "Sinem", LastName = "Algül", BirthYear = 2000, IdentityNumber = 12345678901, UserName = "sinemalgul", CreditCardNumber = 1111111 };
            Gamer gamer2 = new Gamer() { FirstName = "Şimal", LastName = "Baykal", BirthYear = 2000, IdentityNumber = 12345678900, UserName = "simalbaykal", CreditCardNumber = 1111110 };
            Gamer gamer3 = new Gamer() { FirstName = "Serenay", LastName = "Ungör", BirthYear = 2000, IdentityNumber = 12345678911, UserName = "serenayungor", CreditCardNumber = 1111100 };

            Game game1 = new Game() { Id = 1, Name = "Crusader Kings 3", Price = 70 };
            Game game2 = new Game() { Id = 2, Name = "FIFA21", Price = 200 };
            Game game3 = new Game() { Id = 3, Name = "Hearts of Iron 4", Price = 50 };

            Campaign campaign1 = new Campaign() { Id = 100, CampaignName = "WINTER SALE", Discount = 25 };
            Campaign campaign2 = new Campaign() { Id = 200, CampaignName = "SUMMER SALE", Discount = 50 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignDelete(campaign1);
            campaignManager.CampaignUpdate(campaign2);

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer3);

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(game1, gamer2);
            salesManager.Buy(game2, gamer1);
            salesManager.Buy(game3, gamer3);
        }
    }
}
