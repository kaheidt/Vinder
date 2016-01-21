using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
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
        private const double Distance = 24140.2;

        [Route("")]
        [HttpGet]
        public Vehicle[] GetVehicles(
            [FromUri] Guid? uid,
            [FromUri] string[] vins,
            [FromUri] double? latitude,
            [FromUri] double? longitude)
        {
            string pointText = null;
            DbGeography location = null;

            List<Vehicle> vehicles = new List<Vehicle>();
            using (var context = new Business.Entities.Vinder())
            {
                IQueryable<Business.Entities.Vehicle> databaseVehicles = null;

                if (latitude == null || longitude == null)
                {
                    databaseVehicles = context.Vehicles.OrderBy(r => Guid.NewGuid()).Take(5);
                }
                else
                {
                    pointText = String.Format("POINT({0} {1})", longitude, latitude);
                    location = DbGeography.FromText(pointText);

                    if (vins != null && vins.Length == 5)
                    {
                        //exclude vins
                    }
                    else
                    {
                        var dealers = context.Dealers.Where(d => location.Distance(d.GeoLocation) <= Distance);

                        databaseVehicles = (from d in dealers
                                            from v in d.Vehicles
                                            select v).OrderBy(r => Guid.NewGuid()).Take(5);
                    }
                }

                foreach (var databaseVehicle in databaseVehicles.ToList())
                {
                    var vehicle = new Vehicle()
                    {
                        AttributesDictionary = new Dictionary<string, string>(),
                        Images = new[] { "Test1.jpg", "Test2.jpg", "Test3.jpg" },
                        MasterImage = "MasterImage.jpg",
                        Vin = databaseVehicle.Vin,
                    };

                    if (pointText != null && location != null)
                    {
                        double miles = databaseVehicle.Dealer.GeoLocation.Distance(location).Value / 0.000621371;
                        vehicle.Distance = miles;
                    }

                    vehicle.AttributesDictionary.Add("Stock Number", databaseVehicle.StockNumber);
                    vehicle.AttributesDictionary.Add("Model Year", databaseVehicle.ModelYear.HasValue ? databaseVehicle.ModelYear.Value.ToString() : null);
                    vehicle.AttributesDictionary.Add("Make", databaseVehicle.Make);
                    vehicle.AttributesDictionary.Add("Model", databaseVehicle.Model);
                    vehicle.AttributesDictionary.Add("Series", databaseVehicle.Series);
                    vehicle.AttributesDictionary.Add("Odometer", databaseVehicle.Odometer.HasValue ? databaseVehicle.Odometer.Value.ToString() : null);
                    vehicle.AttributesDictionary.Add("Price", databaseVehicle.Price.HasValue ? databaseVehicle.Price.Value.ToString() : null);
                    vehicle.AttributesDictionary.Add("Body Description", databaseVehicle.BodyDescription);
                    vehicle.AttributesDictionary.Add("Engine Description", databaseVehicle.EngineDescription);
                    vehicle.AttributesDictionary.Add("Transmission Description", databaseVehicle.TransmissionDescription);
                    vehicle.AttributesDictionary.Add("Exterior Color", databaseVehicle.ExteriorColor);
                    vehicle.AttributesDictionary.Add("Interior Color", databaseVehicle.InteriorColor);
                    vehicle.AttributesDictionary.Add("Interior Type", databaseVehicle.InteriorType);
                    vehicle.AttributesDictionary.Add("New/Used", databaseVehicle.NewUsed);

                    vehicles.Add(vehicle);
                }
            }

            return vehicles.ToArray();
        }

        private Vehicle[] GenerateDummyVehicles(Guid? uid, string[] vins, double? latitude, double? longitude)
        {
            var vehicles = new List<Vehicle>();

            var vehicle = new Vehicle()
            {
                AttributesDictionary = new Dictionary<string, string>(),
                Distance = 10.0,
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