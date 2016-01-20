using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vinder.WebAPI.Models;

namespace Vinder.WebAPI.Controllers
{
    [RoutePrefix("api/vehicles")]
    public class VehiclesController : ApiController
    {
        [Route("")]
        public Vehicle[] GetVehicles()
        {
            return new Vehicle[]
            {
                new Vehicle()
                {
                    AttributesDictionary = new Dictionary<string, string>{ { "Make", "Jeep" } },
                    Distance = 10.0m,
                    Images = new []{"Test1.jpg"},
                    MasterImage = "MasterImage.jpg",
                    Vin = "12345678901234567"
                },
            };
        }

        [Route("{latitude:double}/{longitude:double}")]
        public Vehicle[] GetLocalVehicles(double latitude, double longitude)
        {
            return new Vehicle[]
            {
                new Vehicle()
                {
                    AttributesDictionary = new Dictionary<string, string>{ { "Make", "Jeep" } },
                    Distance = 10.0m,
                    Images = new []{"Test1.jpg"},
                    MasterImage = "MasterImage.jpg",
                    Vin = "12345678901234567"
                },
            };
        }
    }
}