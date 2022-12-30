namespace MvcEgitimi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UrunAdi { get; set; }

        public decimal UrunFiyati { get; set; }

        public int? StokMiktari { get; set; }
    }
}
