using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryManagement.DataAccess.Entities.SQLEntities
{
    public class SqlCall : IEntity<long>
    {
        public long Id { get; set; }
        public string CallStatus { get; set; }
        public long ClientId { get; set; }
        public long DeliverymanId { get; set; }
        public long OrderId { get; set; }
    }
    
}
