using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Crud.Core.Help;
using Crud.Core.Providers;

namespace Crud.Core.Orders;

[Table("Orders")]
public class Order : Entity<int>
{
    [Required] 
    public virtual string Number  { get; set; }
    
    [Required] 
    public virtual DateTime Date  { get; set; }
    
    [Required] 
    public virtual int ProviderId { get; set; }

    [ForeignKey("ProviderId")] 
    public virtual Provider ProviderFk { get; set; }
    
    public virtual ICollection<OrderItem> OrderItems { get; set; }
}