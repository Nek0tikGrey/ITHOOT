using Domain.Core;

namespace Domain
{
    public class ClientDTO:BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ushort Age { get; set; }
    }
}
