using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface ICampaignService
    {
        void CampaignAdd(Campaign campaign);
        void CampaignUpdate(Campaign campaign);
        void CampaignDelete(Campaign campaign);
    }
}
