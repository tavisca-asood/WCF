using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelService
{
    [DataContract]
    class HotelData
    {
        [DataMember]
        public int ID;
        [DataMember]
        public string Name;
        [DataMember]
        public string Address;
        [DataMember]
        public int Rating;
    }
}
