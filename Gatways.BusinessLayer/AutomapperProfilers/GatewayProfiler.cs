using AutoMapper;
using Gatways.BusinessLayer.Infrastructure.DTOs;
using Gatways.Dataaccesslayer.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.BusinessLayer.AutomapperProfilers
{
    public class GatewayProfiler : Profile
    {
        public GatewayProfiler()
        {
            CreateMap<GatewayEntity, GatewayDTO>();

            CreateMap<GatewayDTO, GatewayEntity>();
        }
    }
}
