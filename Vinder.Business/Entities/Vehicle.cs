namespace Vinder.Business.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle
    {
        public int Id { get; set; }

        public int? DealerId { get; set; }

        [StringLength(17)]
        public string Vin { get; set; }

        [StringLength(20)]
        public string StockNumber { get; set; }

        public int? ModelYear { get; set; }

        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(45)]
        public string Series { get; set; }

        public int? Odometer { get; set; }

        public int? Price { get; set; }

        [StringLength(200)]
        public string BodyDescription { get; set; }

        [StringLength(200)]
        public string TransmissionDescription { get; set; }

        [StringLength(50)]
        public string ExteriorColor { get; set; }

        [StringLength(50)]
        public string InteriorColor { get; set; }

        [StringLength(50)]
        public string InteriorType { get; set; }

        [StringLength(10)]
        public string NewUsed { get; set; }

        public virtual Dealer Dealer { get; set; }
    }
}
