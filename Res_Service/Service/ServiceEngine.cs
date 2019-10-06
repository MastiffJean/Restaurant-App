using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class ServiceEngine
    {
        private List<ServiceUser> conectedUsers = new List<ServiceUser>();
        private Dictionary<string, List<ServiceMessage>> incomingMessages = new Dictionary<string, List<ServiceMessage>>();

        public List<ServiceUser> ConectedUsers
        {
            get { return conectedUsers; }
        }

        public ServiceUser AddNewServiceUser(ServiceUser user)
        {
            var exists =
                from ServiceUser e in this.ConectedUsers
                where e.UserName == user.UserName
                select e;

            if (exists.Count() == 0)
            {
                this.ConectedUsers.Add(user);
                incomingMessages.Add(user.UserName, new List<ServiceMessage>());

                Console.WriteLine("New user connected: " + user);
                return user;
            }
            else
                return null;
        }

        public void AddNewMessage(ServiceMessage newMessage)
        {
            foreach (var user in this.ConectedUsers)
            {
                if (!newMessage.User.UserName.Equals(user.UserName))
                {
                    incomingMessages[user.UserName].Add(newMessage);
                }
            }
        }

        public List<ServiceMessage> GetNewMessages(ServiceUser user)
        {
            List<ServiceMessage> myNewMessages = incomingMessages[user.UserName];

            incomingMessages[user.UserName] = new List<ServiceMessage>();

            if (myNewMessages.Count > 0)
                return myNewMessages;
            else
                return null;
        }

        public void RemoveUser(ServiceUser user)
        {
            Console.WriteLine(user.UserName + " disconected");
            this.ConectedUsers.RemoveAll(u => u.UserName == user.UserName);
            this.incomingMessages.Remove(user.UserName);
        }
    }
}
