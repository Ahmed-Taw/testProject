using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gatways.Dataaccesslayer.Infrastructure.Entities
{
    public class PeripheralDeviceEntity
    {
        [Key]
        public int Id { get; set; }

        public string Vendor { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Gateway")]
        [Required]
        public string GatewayId { get; set; }
        public  GatewayEntity Gateway { get; set; }

        [ForeignKey("Status")]
        [Required]
        public int StatusId { get; set; }

    }
}
