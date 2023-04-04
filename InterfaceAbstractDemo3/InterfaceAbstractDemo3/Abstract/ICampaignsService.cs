using InterfaceAbstractDemo3.Entitties;

namespace InterfaceAbstractDemo3.Concrete
{
    public interface ICampaignsService
    {
        void Add(Campaigns campaigns);
        void Remove(Campaigns campaigns);
        void Update(Campaigns campaigns);
    }
}