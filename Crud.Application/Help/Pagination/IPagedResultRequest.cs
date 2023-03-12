namespace Crud.Application.Help.Pagination;

public interface IPagedResultRequest
{
    int SkipCount { get; set; }
}