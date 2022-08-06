namespace EcoHub.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(nameof(Order))]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? OrderNumber { get; set; }
        public virtual IList<SupplierProduct>? SupplierProducts { get; set; }
    }
}
