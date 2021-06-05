using Gatways.BusinessLayer.Infrastructure.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.BusinessLayer.Infrastructure.DTOs
{
    public class PeripheralDeviceDTO
    {
        public int Id { get; set; }

        public string Vendor { get; set; }

        public DateTime CreatedDate { get; set; }

        public string GatewayId { get; set; }

        public int Status { get; set; }
    }
}
