using AutoMapper;
using HellocareAssessment.Model.Dtos;
using HellocareAssessment.Model.Entities;

namespace HellocareAssessment.Core.Mappings.Posts
{
    public class PostMappings : Profile
    {
        public PostMappings() 
        {
            CreateMap<Post, PostDto>();
        }
    }
}
