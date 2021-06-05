using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.BusinessLayer.Infrastructure.DTOs
{
   public class GatewayDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string IP4 { get; set; }

        public ICollection<PeripheralDeviceDTO> AssociatedPeripheralDevices { get; set; }
    }
}
