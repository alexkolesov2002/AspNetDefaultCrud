namespace Crud.Core.Help;

public interface IEntityGen<TPrimaryKey>
{
    TPrimaryKey Id { get; set; }
}