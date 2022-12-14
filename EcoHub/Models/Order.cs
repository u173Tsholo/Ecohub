namespace EcoHub.Models
{
    using EcoHub.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(nameof(Order))]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? OrderNumber { get; set; }
        public OrderStatus? Status { get; set; }
        public virtual IList<SupplierProduct>? MenuItems { get; set; }
    }
}
