using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gateways.Models
{
    public class GatewayModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string IP4 { get; set; }

        public ICollection<PeripheralDeviceModel> AssociatedPeripheralDevices { get; set; } = new List<PeripheralDeviceModel>();
    }
}
