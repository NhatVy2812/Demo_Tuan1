using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Enitities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        [Required]
        [StringLength(9)]
        public string Code { get; set; } 

        [Required]
        [StringLength(90)]
        public string Name { get; set; }

        [Required]
        [StringLength(28)]
        public string Category { get; set; } 

        [StringLength(28)]
        public string Brand { get; set; } 

        [StringLength(21)]
        public string? Type { get; set; } 

        [StringLength(180)]
        public string Description { get; set; } 

        public DateTime? CreatedAt { get; set; } 

        public DateTime? UpdatedAt { get; set; } 

    }
}
