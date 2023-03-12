using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Crud.Core.Help;
using Crud.Core.Orders;

namespace Crud.Core.Providers;

[Table("Providers")]
public class Provider : Entity<int>
{
    [Required] 
    public virtual string Name { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }
}