using Gatways.BusinessLayer.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.BusinessLayer.Infrastructure.IServices
{
    public interface IGatewayService
    {
        public IEnumerable<GatewayDTO> GetGateways();
        public GatewayDTO GetGatewayDetails(string gatewaysId);

        public bool AddNewGateway(GatewayDTO gatewayDTO);

        public bool AddDeviceToGateway(PeripheralDeviceDTO peripheralDevice, string gatewayId);
        public bool DeleteDeviceFromGateway(int deviceId);


    }
}
