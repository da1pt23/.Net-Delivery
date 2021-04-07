using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryManagement.DataAccess.Entities.SQLEntities
{
    public class SqlCall : IEntity<long>
    {
        public long Id { get; set; }
        public string CallStatus { get; set; }
        public SqlClient Client { get; set; }
        public SqlDeliveryMen Deliveryman { get; set; }
        public SqlOrder Order { get; set; }
    }
    
}
