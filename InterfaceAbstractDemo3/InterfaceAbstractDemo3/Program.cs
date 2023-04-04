using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Adapter;
using InterfaceAbstractDemo3.Concrete;
using InterfaceAbstractDemo3.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu kayıt, güncelleme ve silme işlemlerini mernis doğrulama ile yapımı
            IGamersService gamersService = new GamersManager(new MernisServiceAdapter());
            gamersService.Remove(new Gamers
            {
                FirstName = "Hakan",
                LastName = "Sönmez",
                DateOfBirthay = new DateTime(1996, 5, 31),
                NationilityId = "12312312312"
            });
           
            //Oyunun hangi oyuncu tarafından ve hangi kampanyadan yararlanarak satın alım işlemleri
            IGameService gameService = new GameManager(new MernisServiceAdapter());
            gameService.Sell(new Game
            {
                Name = "Black Desert",
                Price = 100
            }, new Gamers
            {
                FirstName = "Hakan",
                LastName = "Sönmez",
                DateOfBirthay = new DateTime(1996, 5, 31),
                NationilityId = "12312312312"
            }, new Campaigns
            {
                Name = "Ön Satış İndirimi",
                Rate = 25
            });

            //Kampanya işlemleri
            ICampaignsService campaignsService = new CampaignsManager();
            campaignsService.Add(new Campaigns
            {
                Name = "Ön Satış İndirimi",
                Rate = 25
            });

            Console.ReadLine();
        }
    }
}
