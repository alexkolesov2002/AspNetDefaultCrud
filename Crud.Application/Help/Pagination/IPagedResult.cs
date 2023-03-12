namespace Crud.Application.Help.Pagination;

public interface IPagedResult<T> : IListResult<T>, IHasTotalCount
{
    
}