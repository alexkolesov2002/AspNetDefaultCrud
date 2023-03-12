namespace Crud.Core.Help;

[Serializable]
public abstract class Entity<TPrimaryKey> : IEntityGen<TPrimaryKey>
{
    public TPrimaryKey Id { get; set; }
    
    public override string ToString() => $"[{(object)this.GetType().Name} {(object)this.Id!}]";
}