using AutoMapper;
using Gateways.Models;
using Gatways.BusinessLayer.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.AutomapperProfilers
{
    public class PeripheralDeviceProfiler : Profile
    {
        public PeripheralDeviceProfiler()
        {
            CreateMap<PeripheralDeviceDTO, PeripheralDeviceModel>();

            CreateMap<PeripheralDeviceModel, PeripheralDeviceDTO>();
        }
    }
}
