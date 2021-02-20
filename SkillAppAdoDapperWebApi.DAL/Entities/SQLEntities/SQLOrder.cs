using SkillManagement.DataAccess.Interfaces;

namespace SkillManagement.DataAccess.Entities.SQLEntities
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
