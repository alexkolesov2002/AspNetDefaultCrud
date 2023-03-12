using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Crud.Core.Help;

namespace Crud.Core.Orders;

public class OrderItem : Entity<int>
{
    
    [Required] 
    public virtual int OrderId  { get; set; }

    [ForeignKey("OrderId")] 
    public virtual Order OrderFk { get; set; }
    
    [Required] 
    public virtual string Name  { get; set; }
    
    public virtual decimal Quantity  { get; set; }
    
    public virtual string Unit  { get; set; }
}