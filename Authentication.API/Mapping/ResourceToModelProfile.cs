using Authentication.Core.Models;
using Authentication.Core.Resources;
using AutoMapper;

namespace Authentication.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UserCredentialsResource, User>();
        }
    }
}
