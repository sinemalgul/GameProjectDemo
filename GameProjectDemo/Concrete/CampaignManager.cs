using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("A new campaign has been added : " + campaign.CampaignName);
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been removed");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been extended");
        }
    }
}
