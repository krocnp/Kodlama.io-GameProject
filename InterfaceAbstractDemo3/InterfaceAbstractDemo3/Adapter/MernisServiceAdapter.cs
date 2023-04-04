using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3.Adapter
{
    public class MernisServiceAdapter : IGamersCheckService
    {
        public bool GamersCheckIfReal(Gamers gamers)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamers.NationilityId), gamers.FirstName, gamers.LastName, gamers.DateOfBirthay.Year);
        }
    }
}
