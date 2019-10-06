using DataLayer.DtoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [DataContract]
    class ServiceUser
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string IpAddress { get; set; }
        [DataMember]
        public string HostName { get; set; }

        public override string ToString()
        {
            return UserName;
        }
    }
    [DataContract]
    class ServiceMessage
    {
        [DataMember]
        public ServiceUser User { get; set; }
        [DataMember]
        public DtoGood Message { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }
}
