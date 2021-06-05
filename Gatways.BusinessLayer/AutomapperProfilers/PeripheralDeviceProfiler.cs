using AutoMapper;
using Gatways.BusinessLayer.Infrastructure.DTOs;
using Gatways.Dataaccesslayer.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.BusinessLayer.AutomapperProfilers
{
    public class PeripheralDeviceProfiler : Profile
    {
        public PeripheralDeviceProfiler()
        {
            CreateMap<PeripheralDeviceEntity, PeripheralDeviceDTO>()
                .ForMember(d => d.Status, opt => opt.MapFrom(e => e.StatusId));

            CreateMap<PeripheralDeviceDTO, PeripheralDeviceEntity>()
                .ForMember(e => e.StatusId, opt => opt.MapFrom(d => d.Status));
        }
    }
}
