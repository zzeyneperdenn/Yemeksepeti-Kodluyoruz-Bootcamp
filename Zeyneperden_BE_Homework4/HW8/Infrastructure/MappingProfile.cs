﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HW8.Entities;
using HW8.Models;
using HW8.Models.Derived;

namespace HW8.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomEntity, Room>().ForMember(dest => dest.Rate, opt => opt.MapFrom(scr => scr.Rate / 100));

            CreateMap<UserEntity, UserInfo>().ForMember(desc => desc.FullName, opt => opt.MapFrom(scr => string.Concat(scr.Name, scr.SurName)));
        }
    }
}
