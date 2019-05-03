using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApplicationCore.Services;

namespace StoreManagement.Controllers.Api
{
    public class WarehouseLocationsController : ApiController
    {
        private readonly ILocationService locationService;

        public WarehouseLocationsController(ILocationService locationService)
        {
            this.locationService = locationService ?? throw new ArgumentNullException("locationService");
        }
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var locations = locationService.GetWarehouseLocations();
            return Ok(locations);
        }
    }
}