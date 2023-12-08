using Application.Features.Categories.Commands.Create;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        }

    }

}
