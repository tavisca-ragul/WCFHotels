using System.Runtime.Serialization;

namespace WCFHotel
{
    [DataContract]
    class Hotel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public double StarRating { get; set; }
    }
}