using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryManagement.DataAccess.Entities.SQLEntities
{
    public class SqlCar : IEntity<long>
    {
        public long Id { get; set; }
        public string CarStatus { get; set; }
        public string Model { get; set; }
        public long DeliverymanId { get; set;}
    }

}
