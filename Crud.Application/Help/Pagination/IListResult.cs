namespace Crud.Application.Help.Pagination;

public interface IListResult<T>
{
    IReadOnlyList<T> Items { get; set; }
}