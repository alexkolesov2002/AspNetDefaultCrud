namespace Crud.Application.Help;

public interface IEntityDtoGen<TPrimaryKey>
{
    TPrimaryKey Id { get; set; }
}