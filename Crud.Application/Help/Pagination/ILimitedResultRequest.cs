namespace Crud.Application.Help.Pagination;

public interface ILimitedResultRequest
{
    int MaxResultCount { get; set; }
}