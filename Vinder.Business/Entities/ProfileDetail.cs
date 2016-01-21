namespace Vinder.Business.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProfileDetail
    {
        public int Id { get; set; }

        public int? ProfileId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Value { get; set; }

        public int? Score { get; set; }
    }
}
