using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gatways.Dataaccesslayer.Infrastructure.Entities
{
    public class GatewayEntity
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string IP4 { get; set; }

        public ICollection<PeripheralDeviceEntity> AssociatedPeripheralDevices { get; set; }
    }
}
