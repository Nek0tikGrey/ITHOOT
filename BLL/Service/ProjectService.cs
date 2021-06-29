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
    public class ProjectService : IProjectService
    {
        IUnitOfWork unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddAsync(ProjectDTO project)
        {
            await unitOfWork.ProjectRepository.CreateAsync(project.ToEntity());
            await unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<ProjectDTO>> FindAsync(ProjectDTO projectFilter)
        {
            var result = await unitOfWork.ProjectRepository.FindAsync(p =>
                 !string.IsNullOrEmpty(projectFilter.Name) ? p.Name.Contains(projectFilter.Name) : true
                 && (projectFilter.ClientId != Guid.Empty) ? p.ClientId == projectFilter.ClientId:true);
            return result.Select(x => x.ToDTO());
        }

        public async Task<IEnumerable<ProjectDTO>> FindDeveloperProjectsAsync(Guid developerId)
        {
            var result = (await unitOfWork.DeveloperRepository.GetAsync(developerId)).ToDTO();
            return result.Projects;
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllAsync()
        {
            var result = await unitOfWork.ProjectRepository.GetAllAsync();
            return result.Select(x => x.ToDTO());
        }

        public async Task<ProjectDTO> GetAsync(Guid id)
        {
            return (await unitOfWork.ProjectRepository.GetAsync(id)).ToDTO();
        }

        public async Task RemoveAsync(ProjectDTO project)
        {
            unitOfWork.ProjectRepository.Delete(project.ToEntity());
            await unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(ProjectDTO project)
        {
            unitOfWork.ProjectRepository.Update(project.ToEntity());
            await unitOfWork.SaveAsync();
        }
    }
}
