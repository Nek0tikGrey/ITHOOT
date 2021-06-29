using Domain;
using Entity;
using Model;

namespace Mapper
{
    public static class PositionMapper
    {
        public static PositionEntity ToEntity(this PositionDTO position)
        {
            position ??= new PositionDTO();
            return new PositionEntity
            {
                Id = position.Id,
                Name = position.Name
            };
        }
        public static PositionDTO ToDTO(this PositionEntity position)
        {
            position ??= new PositionEntity();
            return new PositionDTO
            {
                Id = position.Id,
                Name = position.Name
            };
        }
        public static PositionDTO ToDTO(this PositionModel position)
        {
            position ??= new PositionModel();
            return new PositionDTO
            {
                Id = position.Id,
                Name = position.Name
            };
        }
        public static PositionModel ToModel(this PositionDTO position)
        {
            position ??= new PositionDTO();
            return new PositionModel
            {
                Id = position.Id,
                Name = position.Name
            };
        }
    }
}
