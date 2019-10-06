using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DtoLayer;

namespace Service
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    interface IContract
    {
        [OperationContract]
        bool TestConnection();

        [OperationContract]
        IEnumerable<DtoGood> GetGoods();

        [OperationContract]
        IEnumerable<DtoUser> GetUsers();

        [OperationContract]
        void SendOrder(IEnumerable<DtoGood> list, DtoUser user, int terminalNum);

        [OperationContract]
        ServiceUser ClientConnect(string userName);

        [OperationContract]
        List<ServiceMessage> GetNewMessages(ServiceUser user);

        [OperationContract]
        void SendNewMessage(ServiceMessage newMessage);

        [OperationContract]
        void RemoveUser(ServiceUser user);
    }
}
