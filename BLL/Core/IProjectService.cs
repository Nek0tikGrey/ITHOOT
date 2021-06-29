using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Core
{
    public interface IProjectService
    {
        public Task AddAsync(ProjectDTO project);
        public Task RemoveAsync(ProjectDTO project);
        public Task<IEnumerable<ProjectDTO>> FindAsync(ProjectDTO projectFilter);
        public Task UpdateAsync(ProjectDTO project);
        public Task<IEnumerable<ProjectDTO>> FindDeveloperProjectsAsync(Guid developerId);
        public Task<IEnumerable<ProjectDTO>> GetAllAsync();
        public Task<ProjectDTO> GetAsync(Guid id);
    }
}
