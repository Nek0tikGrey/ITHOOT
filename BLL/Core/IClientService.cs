using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Core
{
    public interface IClientService
    {
        public Task AddAsync(ClientDTO client);
        public Task RemoveAsync(ClientDTO client);
        public Task<IEnumerable<ClientDTO>> FindAsync(ClientDTO clientFilter);
        public Task UpdateAsync(ClientDTO client);
        public Task<IEnumerable<ClientDTO>> GetAllAsync();
        public Task<ClientDTO> GetAsync(Guid id);
    }
}
