using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SingleFamProperties.Models
{
    public class Property
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        public int YearBuilt { get; set; }

        public decimal ListPrice { get; set; }

        public decimal MonthlyRent { get; set; }

        public decimal GrossYield { get; set; }
    }
}