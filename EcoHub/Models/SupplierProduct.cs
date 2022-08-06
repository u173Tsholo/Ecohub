namespace EcoHub.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table(nameof(SupplierProduct))]
    public class SupplierProduct
    { //id, userId, name, price, imageUrl [my tuks drive], description
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public User? User { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }

        public string? ImageUrl { get; set; }

        public string? Decription { get; set; }

        public bool? Approved { get; set; }

        public bool? Flagged { get; set; }
    }
}
