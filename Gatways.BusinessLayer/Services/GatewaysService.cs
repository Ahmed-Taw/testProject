using AutoMapper;
using Gatways.BusinessLayer.Infrastructure.DTOs;
using Gatways.BusinessLayer.Infrastructure.IServices;
using Gatways.Dataaccesslayer.Infrastructure.Entities;
using Gatways.Dataaccesslayer.Infrastructure.IRepositories;
using Gatways.Dataaccesslayer.Infrastructure.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.BusinessLayer.Services
{
    public class GatewayService : IGatewayService
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly IMapper _mapper;

        public GatewayService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitofWork = unitOfWork;
            this._mapper = mapper;
        }
        public bool AddDeviceToGateway(PeripheralDeviceDTO peripheralDevice, string gatewayId)
        {
           

            if (!IsAddingNewDeviceToGatewaysAllowed(gatewayId))
            {
                throw new Exception("can not be more than 10 devices in the gateway ");
            }
            var deviceEntity = _mapper.Map<PeripheralDeviceEntity>(peripheralDevice);
            deviceEntity.GatewayId = gatewayId;
            _unitofWork.PeripheralDeviceRepo.Add(deviceEntity);
            return _unitofWork.Complete() > 0;
        }

        private bool IsAddingNewDeviceToGatewaysAllowed(string gatewayId)
        {
            return _unitofWork.GatewayRepo.GetGatewaysPeripheralDevicesCount(gatewayId) < 10;
        }
        public bool AddNewGateway(GatewayDTO gatewayDTO)
        {
            var existingGateway = _unitofWork.GatewayRepo.GetById(gatewayDTO.Id);
            if (existingGateway != null)
                throw new Exception("Gateway with that ID already exists");

            _unitofWork.GatewayRepo.Add(_mapper.Map<GatewayEntity>(gatewayDTO));
           return _unitofWork.Complete() > 0;
        }

        public GatewayDTO GetGatewayDetails(string gatewaysId)
        {
            var gateway = _unitofWork.GatewayRepo.GetGatewayDetails(gatewaysId);
            return _mapper.Map<GatewayDTO>(gateway);
        }

        public IEnumerable<GatewayDTO> GetGateways()
        {
            var gateways = _unitofWork.GatewayRepo.GetAllGatewaysWithDevicesData();
            return _mapper.Map<IEnumerable<GatewayDTO>>(gateways);
        }

        public bool DeleteDeviceFromGateway(int deviceId)
        {
            var device = _unitofWork.PeripheralDeviceRepo.GetById(deviceId);
            _unitofWork.PeripheralDeviceRepo.Remove(device);
            return _unitofWork.Complete() > 0;
        }
    }
}
