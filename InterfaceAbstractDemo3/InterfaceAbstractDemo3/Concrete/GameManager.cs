using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3.Concrete
{
    public class GameManager : IGameService
    {
        IGamersCheckService _gamersCheckService;

        public GameManager(IGamersCheckService gamersCheckService)
        {
            _gamersCheckService = gamersCheckService;
        }

        public void Sell(Game game, Gamers gamers, Campaigns campaigns)
        {
            if(_gamersCheckService.GamersCheckIfReal(gamers))
            {
                Console.WriteLine("{0} adındaki oyuncu {1} oyununu %{2} indirim ile {3} tl ye satın aldı", gamers.FirstName,game.Name,campaigns.Rate,game.Price-((game.Price*campaigns.Rate)/100));
            }
            else
            {
                throw new Exception("Kimlik bilgileri doğru olmadığı için satış işlemi gerçekleştirilemedi!");
            }
        }
    }
}
