using AutoMapper;
using Gateways.Models;
using Gatways.BusinessLayer.Infrastructure.DTOs;
using Gatways.Dataaccesslayer.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.AutomapperProfilers
{
    public class GatewayProfiler : Profile
    {
        public GatewayProfiler()
        {
            CreateMap<GatewayModel, GatewayDTO>();

            CreateMap<GatewayDTO, GatewayModel>();
        }
    }
}
