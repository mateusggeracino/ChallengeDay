using SC.Domain.Models.Base;

namespace SC.Domain.Models
{
    public sealed class Scholarity : Entity
    {
        public string Description { get; set; }
        public short Point { get; set; }
    }
}