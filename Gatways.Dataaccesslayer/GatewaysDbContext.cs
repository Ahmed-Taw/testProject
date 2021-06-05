using Gatways.Dataaccesslayer.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gatways.Dataaccesslayer
{
    public class GatewaysDbContext  : DbContext
    {
        public GatewaysDbContext(DbContextOptions<GatewaysDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();

        }


        public DbSet<GatewayEntity> Gateways { get; set; }

        public DbSet<PeripheralDeviceEntity> PeripheralDevices { get; set; }

        public DbSet<PeripheralDeviceStatus> PeripheralDeviceStatus { get; set; }

    }
}
