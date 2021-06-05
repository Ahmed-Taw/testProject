using AutoFixture.Xunit2;
using AutoMapper;
using Gatways.BusinessLayer.Infrastructure.DTOs;
using Gatways.BusinessLayer.Infrastructure.IServices;
using Gatways.BusinessLayer.Services;
using Gatways.Dataaccesslayer.Infrastructure.Entities;
using Gatways.Dataaccesslayer.Infrastructure.IUnitOfWork;
using Moq;
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateway.Business.Tests.GatewayServieTests
{
    public class GatewayServiceTest
    {
        private readonly IGatewayService _GatewayService;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IMapper> _mockMapper;
       

        public GatewayServiceTest()
        {
            _mockMapper = new Mock<IMapper>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
           
            _GatewayService = new GatewayService(_mockUnitOfWork.Object, _mockMapper.Object);
        }

        [Theory]
        [AutoData]
        public void AddGateway_withvalidId_shouldSuccess(GatewayDTO gatewaydto)
        {

            var existingEntity =_mockUnitOfWork.Setup(u => u.GatewayRepo.GetById(gatewaydto.Id)).Returns(null as GatewayEntity);
            _mockUnitOfWork.Setup(uof => uof.GatewayRepo.Add(It.IsAny<GatewayEntity>())).Verifiable();
            _mockUnitOfWork.Setup(uof => uof.Complete()).Returns(1);


            //ACT
            var result = _GatewayService.AddNewGateway(gatewaydto);


            //Assert
            _mockUnitOfWork.Verify(uof => uof.GatewayRepo.Add(It.IsAny<GatewayEntity>()), Times.Once);
            _mockUnitOfWork.Verify(uof => uof.Complete(), Times.Once);
            Assert.True(result);
        }
        [Theory]
        [AutoData]
        public void AddGateway_withExistingId_shouldFail(GatewayDTO gatewaydto)
        {

            
            _mockUnitOfWork.Setup(u => u.GatewayRepo.GetById(gatewaydto.Id)).Returns(new GatewayEntity() { Id = gatewaydto.Id});

            //Assert
            Assert.Throws<Exception>( () => _GatewayService.AddNewGateway(gatewaydto));

            _mockUnitOfWork.Verify(uof => uof.GatewayRepo.Add(It.IsAny<GatewayEntity>()), Times.Never);
            _mockUnitOfWork.Verify(uof => uof.Complete(), Times.Never);
        }

        [Theory]
        [AutoData]
        public void AddDeviceGateway_withLessthantenDevicesExists_shouldSuccess(PeripheralDeviceDTO peripheralDeviceDTO, string gatewayId)
        {

            _mockUnitOfWork.Setup(u => u.GatewayRepo.GetGatewaysPeripheralDevicesCount(gatewayId)).Returns(8);
            _mockMapper.Setup(m => m.Map<PeripheralDeviceEntity>(peripheralDeviceDTO)).Returns(new PeripheralDeviceEntity(){StatusId = 1});

            _mockUnitOfWork.Setup(uof => uof.PeripheralDeviceRepo.Add(It.IsAny<PeripheralDeviceEntity>())).Verifiable();
            _mockUnitOfWork.Setup(uof => uof.Complete()).Returns(1);


            //ACT
            var result = _GatewayService.AddDeviceToGateway(peripheralDeviceDTO, gatewayId);


            //Assert
            _mockUnitOfWork.Verify(uof => uof.PeripheralDeviceRepo.Add(It.IsAny<PeripheralDeviceEntity>()), Times.Once);
            _mockUnitOfWork.Verify(uof => uof.Complete(), Times.Once);
            Assert.True(result);
        }
        [Theory]
        [AutoData]
        public void AddDeviceGateway_withthantenDevicesExists_shouldFail(PeripheralDeviceDTO peripheralDeviceDTO, string gatewayId)
        {


            _mockUnitOfWork.Setup(u => u.GatewayRepo.GetGatewaysPeripheralDevicesCount(gatewayId)).Returns(11);

            //Assert
            Assert.Throws<Exception>(() => _GatewayService.AddDeviceToGateway(peripheralDeviceDTO,gatewayId));

            _mockUnitOfWork.Verify(uof => uof.PeripheralDeviceRepo.Add(It.IsAny<PeripheralDeviceEntity>()), Times.Never);
            _mockUnitOfWork.Verify(uof => uof.Complete(), Times.Never);
        }
    }
}
