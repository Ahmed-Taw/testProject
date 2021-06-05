using Gatways.Dataaccesslayer.Infrastructure.Entities;
using Gatways.Dataaccesslayer.Infrastructure.IRepositories;
using Gatways.Dataaccesslayer.Infrastructure.IUnitOfWork;
using Gatways.Dataaccesslayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.Dataaccesslayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GatewaysDbContext _gatewaysDbContext;
        private IGatewayRepository _gatewayRepo;
        private IRepository<PeripheralDeviceEntity> _PeripheralDeviceRepo;

        public UnitOfWork(GatewaysDbContext gatewaysDbContext)
        {
            this._gatewaysDbContext = gatewaysDbContext;
        }
        public IGatewayRepository GatewayRepo
        {
            get
            {
                if(_gatewayRepo == null)
                {
                    _gatewayRepo = new GatewayRepository(_gatewaysDbContext);
                }
                return _gatewayRepo;
            }
        }

        public IRepository<PeripheralDeviceEntity> PeripheralDeviceRepo
        {
            get
            {
                if(_PeripheralDeviceRepo == null)
                {
                    _PeripheralDeviceRepo = new Repository<PeripheralDeviceEntity>(_gatewaysDbContext);
                }
                return _PeripheralDeviceRepo;
            }
        }

        public int Complete()
        {
           return _gatewaysDbContext.SaveChanges();
        }
    }
}
