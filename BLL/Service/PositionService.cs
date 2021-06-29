using BLL.Core;
using DataLayer.Core;
using Domain;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class PositionService : IPositionService
    {
        IUnitOfWork unitOfWork;

        public PositionService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddAsync(PositionDTO position)
        {
            await unitOfWork.PositionRepository.CreateAsync(position.ToEntity());
            await unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<PositionDTO>> FindAsync(PositionDTO positionFilter)
        {
            var result = await unitOfWork.PositionRepository.
                FindAsync(p => 
                !string.IsNullOrEmpty(positionFilter.Name) ? p.Name.Contains(positionFilter.Name) : true);
            return result.Select(x => x.ToDTO());
        }

        public async Task<IEnumerable<PositionDTO>> GetAllAsync()
        {
            var result = await unitOfWork.PositionRepository.GetAllAsync();
            return result.Select(x => x.ToDTO());
        }

        public async Task<PositionDTO> GetAsync(Guid id)
        {
            return (await unitOfWork.PositionRepository.GetAsync(id)).ToDTO();
        }

        public async Task RemoveAsync(PositionDTO position)
        {
            unitOfWork.PositionRepository.Delete(position.ToEntity());
            await unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(PositionDTO position)
        {
            unitOfWork.PositionRepository.Update(position.ToEntity());
            await unitOfWork.SaveAsync();
        }
    }
}
