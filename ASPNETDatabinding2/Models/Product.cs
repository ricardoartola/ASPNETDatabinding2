using System.ComponentModel.DataAnnotations;

namespace ASPNETDatabinding2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(255)]
        public string Description { get; set; }
    }
}