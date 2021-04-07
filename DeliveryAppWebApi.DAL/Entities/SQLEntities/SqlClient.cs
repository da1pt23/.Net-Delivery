using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryManagement.DataAccess.Entities.SQLEntities
{
    public class SqlClient : IEntity<long>
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
    
}
