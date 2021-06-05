using Gatways.Dataaccesslayer.Infrastructure.Entities;
using Gatways.Dataaccesslayer.Infrastructure.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gatways.Dataaccesslayer.Repositories
{
    public class GatewayRepository : Repository<GatewayEntity>, IGatewayRepository
    {
        private readonly GatewaysDbContext _gatewaysDbContext;

        public GatewayRepository(GatewaysDbContext gatewaysDbContext) : base(gatewaysDbContext)
        {
            this._gatewaysDbContext = gatewaysDbContext;
        }

        public IEnumerable<GatewayEntity> GetAllGatewaysWithDevicesData()
        {
           return _gatewaysDbContext.Gateways.Include(g => g.AssociatedPeripheralDevices).ToList();
        }

        public GatewayEntity GetGatewayDetails(string gatewayId)
        {
            return _gatewaysDbContext.Gateways.Include(g => g.AssociatedPeripheralDevices).First(g => g.Id == gatewayId);
        }

        public int GetGatewaysPeripheralDevicesCount(string gatewaysId)
        {
            return _gatewaysDbContext.Gateways.Include(g => g.AssociatedPeripheralDevices).First(g => g.Id == gatewaysId).AssociatedPeripheralDevices.Count;
        }
    }
}
