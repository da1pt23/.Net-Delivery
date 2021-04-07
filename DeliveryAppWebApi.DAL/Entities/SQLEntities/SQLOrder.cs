using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryManagement.DataAccess.Entities.SQLEntities
{
    public class SqlOrder : IEntity<long>
    {
        public long Id { get; set; }
        public long Bonus { get; set; }
        public string Name { get; set; }
        public string PaymentOption { get; set; }
        public double Price;
    }
}
