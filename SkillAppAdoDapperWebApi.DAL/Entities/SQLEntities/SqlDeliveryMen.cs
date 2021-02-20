using SkillManagement.DataAccess.Interfaces;

namespace SkillManagement.DataAccess.Entities.SQLEntities
{
    public class SqlDeliveryMen : IEntity<long>
    {
        public long Id { get; set; }
        public long Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long Wages { get; set; }
    }
    
}
