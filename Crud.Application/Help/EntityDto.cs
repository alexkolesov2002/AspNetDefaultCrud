namespace Crud.Application.Help;

[Serializable]
public abstract class EntityDto<TPrimaryKey> : IEntityDtoGen<TPrimaryKey>
{
    public TPrimaryKey Id { get; set; }
    
    public override string ToString() => $"[{(object)this.GetType().Name} {(object)this.Id!}]";
}