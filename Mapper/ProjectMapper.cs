using Domain;
using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class ProjectMapper
    {
        public static ProjectEntity ToEntity(this ProjectDTO project)
        {
            project ??= new ProjectDTO();
            return new ProjectEntity
            {
                Id = project.Id,
                Client = project.Client?.ToEntity(),
                ClientId = project.ClientId,
                Developers = project.Developers?.Select(x => x.ToEntity()).ToList(),
                Name = project.Name
            };
        }
        public static ProjectDTO ToDTO(this ProjectEntity project)
        {
            project ??= new ProjectEntity();
            return new ProjectDTO
            {
                Id = project.Id,
                Client = project.Client?.ToDTO(),
                ClientId = project.ClientId,
                Developers = project.Developers?.Select(x => x.ToDTO()).ToList(),
                Name = project.Name
            };
        }
        public static ProjectDTO ToDTO(this ProjectModel project)
        {
            project ??= new ProjectModel();
            return new ProjectDTO
            {
                Id = project.Id,
                Client = project.Client?.ToDTO(),
                ClientId = project.ClientId,
                Developers = project.Developers?.Select(x => x.ToDTO()).ToList(),
                Name = project.Name
            };
        }
        public static ProjectModel ToModel(this ProjectDTO project)
        {
            project ??= new ProjectDTO();
            return new ProjectModel
            {
                Id = project.Id,
                Client = project.Client?.ToModel(),
                ClientId = project.ClientId,
                Developers = project.Developers?.Select(x => x.ToModel()).ToList(),
                Name = project.Name
            };
        }

    }
}
