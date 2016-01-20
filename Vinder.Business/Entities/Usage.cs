namespace Vinder.Business.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usage
    {
        public int Id { get; set; }

        public int? Year { get; set; }

        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Action { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
