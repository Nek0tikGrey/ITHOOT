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
    public class ClientService : IClientService
    {
        IUnitOfWork unitOfWork;

        public ClientService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddAsync(ClientDTO client)
        {
            await unitOfWork.ClientRepository.CreateAsync(client.ToEntity());
            await unitOfWork.SaveAsync();
        }
        public async Task<IEnumerable<ClientDTO>> FindAsync(ClientDTO clientFilter)
        {
            var result = await unitOfWork.ClientRepository.FindAsync(p =>
                 !String.IsNullOrEmpty(clientFilter.Name) ? p.Name.Contains(clientFilter.Name) : true);
            return result.Select(x => x.ToDTO());
        }

        public async Task<IEnumerable<ClientDTO>> GetAllAsync()
        {
            var result = await unitOfWork.ClientRepository.GetAllAsync();
            return result.Select(x=>x.ToDTO());
        }

        public async Task<ClientDTO> GetAsync(Guid id)
        {
            return (await unitOfWork.ClientRepository.GetAsync(id)).ToDTO();
        }

        public async Task RemoveAsync(ClientDTO client)
        {
            unitOfWork.ClientRepository.Delete(client.ToEntity());
            await unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(ClientDTO client)
        {
            unitOfWork.ClientRepository.Update(client.ToEntity());
            await unitOfWork.SaveAsync();
        }
    }
}
