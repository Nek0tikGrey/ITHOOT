using BLL.Core;
using DataLayer.Core;
using Domain;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class DeveloperService : IDeveloperService
    {
        IUnitOfWork unitOfWork;

        public DeveloperService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddAsync(DeveloperDTO developer)
        {
            await unitOfWork.DeveloperRepository.CreateAsync(developer.ToEntity());
            await unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<DeveloperDTO>> FindAsync(DeveloperDTO developerFilter)
        {
            var result = await unitOfWork.DeveloperRepository
                .FindAsync(p =>
                !string.IsNullOrEmpty(developerFilter.Name) ? p.Name.Contains(developerFilter.Name) : true
                && (developerFilter.PositionId != Guid.Empty) ? p.PositionId == developerFilter.PositionId : true);
            return result.Select(x => x.ToDTO());
        }

        public async Task<IEnumerable<DeveloperDTO>> FindDevelopersOnProjectAsync(Guid projectId)
        {
            var result = (await unitOfWork.ProjectRepository.GetAsync(projectId)).ToDTO();
            return result.Developers;
        }

        public async Task<IEnumerable<DeveloperDTO>> GetAllAsync()
        {
            var result = await unitOfWork.DeveloperRepository.GetAllAsync();
            return result.Select(x => x.ToDTO());
        }

        public async Task<DeveloperDTO> GetAsync(Guid id)
        {
            return (await unitOfWork.DeveloperRepository.GetAsync(id)).ToDTO();
        }

        public async Task RemoveAsync(DeveloperDTO developer)
        {
            unitOfWork.DeveloperRepository.Delete(developer.ToEntity());
            await unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(DeveloperDTO developer)
        {
            unitOfWork.DeveloperRepository.Update(developer.ToEntity());
            await unitOfWork.SaveAsync();
        }
    }
}
