using System.ComponentModel.DataAnnotations;

namespace Crud.Application.Help.Pagination.Dtos;

public class LimitedResultRequestDto : ILimitedResultRequest
{
    [Range(1, 2147483647)] 
    public virtual int MaxResultCount { get; set; } = 10;
}