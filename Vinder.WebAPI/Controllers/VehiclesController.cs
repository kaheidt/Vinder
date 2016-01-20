using System;
using System.Collections.Generic;
using System.Globalization;
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
        [HttpGet]
        public Vehicle[] GetVehicles(
            [FromUri] Guid? uid,
            [FromUri] string[] vins,
            [FromUri] double? latitude,
            [FromUri] double? longitude)
        {
            return GenerateDummyVehicles(uid, vins, latitude, longitude);
        }

        private Vehicle[] GenerateDummyVehicles(Guid? uid, string[] vins, double? latitude, double? longitude)
        {
            var vehicles = new List<Vehicle>();

            var vehicle = new Vehicle()
            {
                AttributesDictionary = new Dictionary<string, string>(),
                Distance = 10.0m,
                Images = new[] { "Test1.jpg", "Test2.jpg", "Test3.jpg" },
                MasterImage = "MasterImage.jpg",
                Vin = "12345678901234567"
            };

            if (vins != null)
            {
                int index = 0;

                foreach (var vin in vins)
                {
                    vehicle.AttributesDictionary.Add("ExcludeVin" + index, vin);
                    index++;
                }
            }

            vehicle.AttributesDictionary.Add("uid", uid.HasValue ? uid.Value.ToString() : null);

            vehicle.AttributesDictionary.Add("latitude", latitude.HasValue ? latitude.Value.ToString(CultureInfo.CurrentCulture) : null);

            vehicle.AttributesDictionary.Add("longitude", longitude.HasValue ? longitude.Value.ToString(CultureInfo.CurrentCulture) : null);

            vehicles.Add(vehicle);

            return vehicles.ToArray();
        }
    }
}