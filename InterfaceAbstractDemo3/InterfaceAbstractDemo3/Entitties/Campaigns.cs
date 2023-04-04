using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3.Entitties
{
    public class Campaigns:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
    }
}
