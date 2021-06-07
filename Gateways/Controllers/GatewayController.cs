using AutoMapper;
using Gateways.Models;
using Gatways.BusinessLayer.Infrastructure.DTOs;
using Gatways.BusinessLayer.Infrastructure.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Gateways.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        private readonly IGatewayService _gatewayService;
        private readonly IMapper _mapper;

        public GatewayController(IGatewayService gatewayService, IMapper mapper)
        {
            this._gatewayService = gatewayService;
            this._mapper = mapper;
        }
        [HttpGet]
        [ActionName("All")]
        public IActionResult GetGateways()
        {

            var allgatewaysDtos = _gatewayService.GetGateways();

            return Ok(_mapper.Map<IEnumerable<GatewayModel>>(allgatewaysDtos));
        }
        [HttpGet("{gatewayId}")]
        [ActionName("Details")]
        public IActionResult GetGatewayDetails(string gatewayId)
        {

            var allgatewaysDto = _gatewayService.GetGatewayDetails(gatewayId);

            return Ok(_mapper.Map<GatewayModel>(allgatewaysDto));
        }
        [HttpPost]
        [ActionName("Add")]

        public IActionResult AddGateway(GatewayModel gatewayModel)
        {
            try
            {
                IPAddress ip;

                if (!IPAddress.TryParse(gatewayModel.IP4, out ip))
                    return BadRequest("Ip4 is not valid ");

                var result = _gatewayService.AddNewGateway(_mapper.Map<GatewayDTO>(gatewayModel));

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
           
        }

        [HttpPost("{gatewayId}")]
        [ActionName("AddDevice")]

        public IActionResult AddGatewayPeripheralDevice(string gatewayId, [FromBody]PeripheralDeviceModel peripheralDevice)
        {
            try
            {
                var result = _gatewayService.AddDeviceToGateway(_mapper.Map<PeripheralDeviceDTO>(peripheralDevice), gatewayId);

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
            
        }

        [HttpDelete("{deviceId}")]
        [ActionName("RemoveDevice")]

        public IActionResult DeleteGatewayPeripheralDevice(int deviceId)
        {
            try
            {
                var result = _gatewayService.DeleteDeviceFromGateway(deviceId);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
