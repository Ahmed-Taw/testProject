using Gateways.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gateways.Models
{
    public class PeripheralDeviceModel
    {
        public string Vendor { get; set; }

        public DateTime CreatedDate { get; set; }

        public PeripheralDeviceStatus Status { get; set; }
    }
}
