using System;
using GameProject.Abstract;
using GameProject.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesManager
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            int hesap = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100);
            Console.WriteLine(gamer.FirstName + "-" + game.GameName + "oyunu" + campaign.CampaignName + "kampanyası ile %" + campaign.DiscountRate + "indirimle" + hesap + "TL ye satın aldı.");
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "" + gamer.LastName + "-" + game.GameName + "oyunu" + game.GamePrice + "TL ye satın aldı.");
        }
    }
}
