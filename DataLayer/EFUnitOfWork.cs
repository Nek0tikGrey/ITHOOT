using DataLayer.Core;
using DataLayer.Repositories;
using Entity;
using System;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public IRepository<ClientEntity> ClientRepository
        {
            get
            {
                return _ClientRepository;
            }
        }

        public IRepository<DeveloperEntity> DeveloperRepository
        {
            get 
            {
                return _DeveloperRepository;
            }
        }

        public IRepository<PositionEntity> PositionRepository
        {
            get 
            { 
                return _PositionRepository; 
            }
        }

        public IRepository<ProjectEntity> ProjectRepository
        {
            get
            {
                return _ProjectRepository;
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        private AppContext _context;
        private IRepository<ClientEntity> _ClientRepository;
        private IRepository<DeveloperEntity> _DeveloperRepository;
        private IRepository<PositionEntity> _PositionRepository;
        private IRepository<ProjectEntity> _ProjectRepository;
        public EFUnitOfWork(AppContext context)
        {
            _context = context;
            _ClientRepository = new ClientRepository(_context);
            _DeveloperRepository = new DeveloperRepository(_context);
            _PositionRepository = new PositionRepository(_context);
            _ProjectRepository = new ProjectRepository(_context);

        }
    }
}
