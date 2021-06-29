using Domain;
using Entity;
using Model;
using System.Linq;

namespace Mapper
{
    public static class DeveloperMapper
    {
        public static DeveloperEntity ToEntity(this DeveloperDTO developer)
        {
            developer ??= new DeveloperDTO();
            return new DeveloperEntity
            {
                Id = developer.Id,
                Name = developer.Name,
                PositionId = developer.PositionId,
                Position = developer.Position?.ToEntity()
            };
        }
        public static DeveloperDTO ToDTO(this DeveloperEntity developer)
        {
            developer ??= new DeveloperEntity();
            return new DeveloperDTO
            {
                Id = developer.Id,
                Name = developer.Name,
                PositionId = developer.PositionId,
                Position = developer.Position?.ToDTO()
            };
        }
        public static DeveloperDTO ToDTO(this DeveloperModel developer)
        {
            developer ??= new DeveloperModel();
            return new DeveloperDTO
            {
                Id = developer.Id,
                Name = developer.Name,
                PositionId = developer.PositionId,
                Position = developer.Position?.ToDTO()
            };
        }
        public static DeveloperModel ToModel(this DeveloperDTO developer)
        {
            developer ??= new DeveloperDTO();
            return new DeveloperModel
            {
                Id = developer.Id,
                Name = developer.Name,
                PositionId = developer.PositionId,
                Position = developer.Position?.ToModel()
            };
        }
    }
}
