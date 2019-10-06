using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DbLayer;
using DataLayer.DtoLayer;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class Contract : IContract
    {
        ResContext context = new ResContext();
        private ServiceEngine mainEngine = new ServiceEngine();

        public bool TestConnection()
        {
            return true;
        }

        public IEnumerable<DtoGood> GetGoods()
        {
            List<DtoGood> list = context.Goods.Select(g => new DtoGood
            {
                Id = g.Id,
                Name = g.Name,
                Image = g.Image,
                Price = g.Price,
                Category_Id = g.Category_Id
            }).ToList();

            return list;
        }

        public IEnumerable<DtoUser> GetUsers()
        {
            List<DtoUser> list = context.Users.Select(g => new DtoUser
            {
                Id = g.Id,
                Name = g.Name,
                Login = g.Login,
                Password = g.Password,
                Role_Id = g.Role_Id
            }).ToList();

            return list;
        }
        
        public void SendOrder(IEnumerable<DtoGood> list, DtoUser user, int terminalNum)
        {
            decimal price = 0;
            foreach(var n in list)
            {
                price += n.Price;
            }
            Order newOrder = new Order() { Order_Data = DateTime.Now, User_Id = user.Id, Terminal_Num = terminalNum, Total_Price = price };
            
            context.Orders.Add(newOrder);
            context.SaveChanges();
            var item = context.Orders.ToList();
            var num = item.LastOrDefault().Id;
            foreach (var n in list)
            {
                context.Order_Item.Add(new Order_Item() { Order_Id = num, Good_Id = n.Id });
            }
            context.SaveChanges();
        }

        public ServiceUser ClientConnect(string userName)
        {
            return mainEngine.AddNewServiceUser(new ServiceUser() { UserName = userName });
        }

        public List<ServiceMessage> GetNewMessages(ServiceUser user)
        {
            return mainEngine.GetNewMessages(user);
        }

        public void SendNewMessage(ServiceMessage newMessage)
        {
            mainEngine.AddNewMessage(newMessage);
        }

        public void RemoveUser(ServiceUser user)
        {
            mainEngine.RemoveUser(user);
        }
    }
}
