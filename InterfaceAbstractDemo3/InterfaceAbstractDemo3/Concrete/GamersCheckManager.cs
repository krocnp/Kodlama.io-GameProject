using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3.Concrete
{
    public class GamersCheckManager : IGamersCheckService
    {
        public bool GamersCheckIfReal(Gamers gamers)
        {
            return true;
        }
    }
}
