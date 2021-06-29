using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Core
{
    public interface IDeveloperService
    {
        public Task AddAsync(DeveloperDTO developer);
        public Task RemoveAsync(DeveloperDTO developer);
        public Task<IEnumerable<DeveloperDTO>> FindAsync(DeveloperDTO developerFilter);
        public Task UpdateAsync(DeveloperDTO developer);
        public Task<IEnumerable<DeveloperDTO>> FindDevelopersOnProjectAsync(Guid projectId);
        public Task<IEnumerable<DeveloperDTO>> GetAllAsync();
        public Task<DeveloperDTO> GetAsync(Guid id);
    }
}
