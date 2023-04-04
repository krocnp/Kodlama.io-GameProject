using InterfaceAbstractDemo3.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3.Abstract
{
    public interface IGamersService
    {
        void Add(Gamers gamers);
        void Remove(Gamers gamers);
        void Update(Gamers gamers);
    }
}
