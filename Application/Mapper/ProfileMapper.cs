﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using AutoMapper;
using Domain.Model;

namespace Application.Mapper
{
   public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<User, UserRegisterDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Plant, AddPlantDto>().ReverseMap();
            CreateMap<Plant, UpdatePlantDto>().ReverseMap();
            CreateMap<Plant, PlantWithCategoryDto>()
                .ForMember(dest=>dest.CategoryName,opt=>opt.MapFrom(src=>src.Category != null?src.Category.CategoryName:null)).ReverseMap();
            CreateMap<Plan, PlanDto>().ReverseMap();
            CreateMap<UserPlan, UserPlanDto>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ReverseMap()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
            CreateMap<AddUserPlanDto, UserPlan>();
            //CreateMap<UserPlan, UserPlanDto>();

          
        }
    }
}
