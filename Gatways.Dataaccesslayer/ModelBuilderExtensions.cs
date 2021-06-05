using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Gatways.Dataaccesslayer.Infrastructure.Entities;

namespace Gatways.Dataaccesslayer
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeripheralDeviceStatus>().HasData(
                new PeripheralDeviceStatus
                {
                    Id = 1,
                    Description= "OnLine"
                },
                new PeripheralDeviceStatus
                {
                    Id = 2,
                    Description = "OffLine"
                }
            );
            modelBuilder.Entity<GatewayEntity>().HasData(
                new GatewayEntity { Id = "Test-gateway-1", Name = "Gate-1", IP4= "192.158.1.38" },
                new GatewayEntity { Id = "Test-gateway-2", Name = " Gate-2" , IP4 = "192.158.1.100" },
                new GatewayEntity { Id = "Test-gateway-3", Name = "Gate-3", IP4 = "192.158.1.50" }
            );

            modelBuilder.Entity<PeripheralDeviceEntity>().HasData(
               new PeripheralDeviceEntity { Id = 1,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-1", GatewayId= "Test-gateway-1", StatusId=1 },
               new PeripheralDeviceEntity { Id = 2,CreatedDate=DateTime.UtcNow, Vendor = " Gate1-2", GatewayId = "Test-gateway-1", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 3,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-3", GatewayId = "Test-gateway-1", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 4,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-4", GatewayId = "Test-gateway-1", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 5,CreatedDate=DateTime.UtcNow, Vendor = " Gate1-5", GatewayId = "Test-gateway-1", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 6,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-6", GatewayId = "Test-gateway-1", StatusId = 2 },
               new PeripheralDeviceEntity { Id = 7,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-7", GatewayId = "Test-gateway-1", StatusId = 2 },
               new PeripheralDeviceEntity { Id = 8,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-8", GatewayId = "Test-gateway-1", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 9,CreatedDate=DateTime.UtcNow, Vendor = " Gate1-9", GatewayId = "Test-gateway-1", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 10, CreatedDate = DateTime.UtcNow, Vendor = "Gate1-10", GatewayId = "Test-gateway-1", StatusId = 1 },

               new PeripheralDeviceEntity { Id = 11,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-8", GatewayId = "Test-gateway-2", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 12,CreatedDate=DateTime.UtcNow, Vendor = " Gate1-9", GatewayId = "Test-gateway-2", StatusId = 2 },
               new PeripheralDeviceEntity { Id = 13,CreatedDate=DateTime.UtcNow, Vendor = "Gate1-10", GatewayId = "Test-gateway-2", StatusId = 1 },
               new PeripheralDeviceEntity { Id = 14, CreatedDate = DateTime.UtcNow, Vendor = "Gate1-8", GatewayId = "Test-gateway-3", StatusId = 1 }
             
           );
        }
    }
}
