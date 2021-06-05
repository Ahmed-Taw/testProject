using Gatways.Dataaccesslayer.Infrastructure.Entities;
using Gatways.Dataaccesslayer.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.Dataaccesslayer.Infrastructure.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IGatewayRepository GatewayRepo { get; }
        IRepository<PeripheralDeviceEntity> PeripheralDeviceRepo { get; }

        int Complete();
    }
}
