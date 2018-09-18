using System.Collections.Generic;
using System.ServiceModel;

namespace WCFHotel
{
    [ServiceContract]
    interface IHotelService
    {
        [OperationContract]
        Hotel GetHotelById(int id);
        [OperationContract]
        List<Hotel> GetAllHotels();
    }
}