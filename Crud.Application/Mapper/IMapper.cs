using AutoMapper;

namespace Crud.Application.Mapper;

public interface IMapper<T>
{
    void Mapping(Profile profile) => profile
        .CreateMap(typeof(T), GetType())
        .ReverseMap();
}