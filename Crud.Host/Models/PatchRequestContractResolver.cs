using System.Reflection;
using Crud.Application.Help;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Crud.Host.Models;

public class PatchRequestContractResolver : DefaultContractResolver
{
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        var prop = base.CreateProperty(member, memberSerialization);

        prop.SetIsSpecified += (o, o1) =>
        {
            if (o is PatchDto patchDtoBase) patchDtoBase.SetHasProperty(prop.PropertyName!);
        };

        return prop;
    }
}