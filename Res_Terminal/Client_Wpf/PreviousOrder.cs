using Client_Wpf.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Wpf
{
    class PreviousOrder
    {
        public string Type { get; set; }
        public List<DtoGood> List { get; set; }
    }
}
