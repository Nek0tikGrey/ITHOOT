using Entity.Core;

namespace Entity
{
    public class ClientEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ushort Age { get; set; }
    }
}
