using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAMODEL.DBModels
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
