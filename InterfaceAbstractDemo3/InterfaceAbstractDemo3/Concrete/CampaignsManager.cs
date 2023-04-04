using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3.Concrete
{
    public class CampaignsManager:ICampaignsService
    {
        

        public void Add(Campaigns campaigns)
        {
            
                Console.WriteLine("Added to db:" + campaigns.Name);


        }

        public void Remove(Campaigns campaigns)
        {
            
                Console.WriteLine("Removed to db:" + campaigns.Name);
           

        }

        public void Update(Campaigns campaigns)
        {
            
                Console.WriteLine("Updated to db:" + campaigns.Name);

        }
    }
}
