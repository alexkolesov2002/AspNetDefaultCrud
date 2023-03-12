using System.ComponentModel.DataAnnotations;

namespace Crud.Application.Help.Pagination.Dtos;


public class PagedResultRequestDto : LimitedResultRequestDto, IPagedResultRequest
{
    [Range(0, 2147483647)] 
    public virtual int SkipCount { get; set; }
}