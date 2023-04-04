using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3.Concrete
{
    public class GamersManager : IGamersService
    {
        IGamersCheckService _gamersCheckService;

        public GamersManager(IGamersCheckService gamersCheckService)
        {
            _gamersCheckService = gamersCheckService;
        }

        public void Add(Gamers gamers)
        {
            if(_gamersCheckService.GamersCheckIfReal(gamers))
            {
                Console.WriteLine("Added to db:" + gamers.FirstName);
            }
            else
            {
                throw new Exception("Kimlik bilgileri doğru olmadığı için ekleme işlemi yapılamadı!");
            }
            
        }

        public void Remove(Gamers gamers)
        {
            if (_gamersCheckService.GamersCheckIfReal(gamers))
            {
                Console.WriteLine("Removed to db:" + gamers.FirstName);
            }
            else
            {
                throw new Exception("Kimlik bilgileri doğru olmadığı için silme işlemi yapılamadı!");
            }
            
        }

        public void Update(Gamers gamers)
        {
            if (_gamersCheckService.GamersCheckIfReal(gamers))
            {
                Console.WriteLine("Updated to db:" + gamers.FirstName);
            }
            else
            {
                throw new Exception("Kimlik bilgileri doğru olmadığı için güncelleme işlemi yapılamadı!");
            }
            
        }
    }
}
