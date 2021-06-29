using Domain;
using Entity;
using Model;
using System;

namespace Mapper
{
    public static class ClientMapper
    {
        public static ClientEntity ToEntity (this ClientDTO client)
        {
            client ??= new ClientDTO();
            return new ClientEntity
            {
                Id = client.Id,
                Name = client.Name
            };
        }
        public static ClientDTO ToDTO(this ClientEntity client)
        {
            client ??= new ClientEntity();
            return new ClientDTO
            {
                Id = client.Id,
                Name = client.Name
            };
        }
        public static ClientDTO ToDTO(this ClientModel client)
        {
            client ??= new ClientModel();
            return new ClientDTO
            {
                Id = client.Id,
                Name = client.Name
            };
        }
        public static ClientModel ToModel(this ClientDTO client)
        {
            client ??= new ClientDTO();
            return new ClientModel
            {
                Id = client.Id,
                Name = client.Name
            };
        }
        
    }
}
