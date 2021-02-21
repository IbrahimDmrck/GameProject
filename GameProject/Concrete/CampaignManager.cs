using System;
using GameProject.Abstract;
using GameProject.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager:ICampainService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası eklendi.");
        }
        public void Delete(Campaign campaign)
        { 
            Console.WriteLine(campaign.CampaignName + "kampanyası silindi"); 
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampnyası güncellendi");
        }
    }
}
