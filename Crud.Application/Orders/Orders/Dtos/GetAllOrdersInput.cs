using Crud.Application.Help.Pagination.Dtos;

namespace Crud.Application.Orders.Orders.Dtos;

public class GetAllOrdersInput : PagedResultRequestDto
{
    public string NameFilter { get; set; }
}