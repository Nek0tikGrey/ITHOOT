using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Core
{
    public interface IPositionService
    {
        public Task AddAsync(PositionDTO position);
        public Task RemoveAsync(PositionDTO position);
        public Task<IEnumerable<PositionDTO>> FindAsync(PositionDTO positionFilter);
        public Task UpdateAsync(PositionDTO position);
        public Task<IEnumerable<PositionDTO>> GetAllAsync();
        public Task<PositionDTO> GetAsync(Guid id);
    }
}
