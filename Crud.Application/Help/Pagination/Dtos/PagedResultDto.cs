﻿namespace Crud.Application.Help.Pagination.Dtos;

public class PagedResultDto<T> : ListResultDto<T>, IPagedResult<T>
{
    public int TotalCount { get; set; }
    
    public PagedResultDto()
    {
    }

    public PagedResultDto(int totalCount, IReadOnlyList<T> items) : base(items)
    {
        TotalCount = totalCount;
    }
}