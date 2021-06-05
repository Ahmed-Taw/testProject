using Gatways.Dataaccesslayer.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.Dataaccesslayer.Infrastructure.IRepositories
{
    public interface IGatewayRepository : IRepository<GatewayEntity>
    {
        IEnumerable<GatewayEntity> GetAllGatewaysWithDevicesData();

        int GetGatewaysPeripheralDevicesCount(string gatewaysId);

        GatewayEntity GetGatewayDetails(string gatewayId);
    }
}
