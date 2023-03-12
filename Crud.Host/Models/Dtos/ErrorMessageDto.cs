using Newtonsoft.Json;

namespace Crud.Host.Models.Dtos;

public class ErrorMessageDto
{
    public int StatusCode { get; set; }

    public string ErrorMessage { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}