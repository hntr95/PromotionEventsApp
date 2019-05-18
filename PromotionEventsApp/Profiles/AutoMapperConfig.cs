﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PromotionEventsApp.Models;
using PromotionEventsApp.ViewModels;

namespace PromotionEventsApp.Profiles
{

    public class EventToEventViewModel : Profile
    {
        public EventToEventViewModel()
        {
            CreateMap<Event, EventViewModel>()
                .ForMember(_ => _.Id, __ => __.MapFrom(___ => ___.Id))
                .ForMember(_ => _.Description, __ => __.MapFrom(___ => ___.Description))
                .ForMember(_ => _.StartTime, __ => __.MapFrom(___ => ___.StartTime))
                .ForMember(_ => _.EndTime, __ => __.MapFrom(___ => ___.EndTime))
                .ForMember(_ => _.Image, __ => __.MapFrom(___ => ___.Image))
                .ForMember(_ => _.Members, __ => __.MapFrom(___ => ___.Members))
                .ForMember(_ => _.Spots, __ => __.MapFrom(___ => ___.Spots));
        }
    }

    public class EventViewModelToEvent : Profile
    {
        public EventViewModelToEvent()
        {
            CreateMap<EventViewModel, Event>()
                .ForMember(_ => _.Id, __ => __.MapFrom(___ => ___.Id))
                .ForMember(_ => _.Description, __ => __.MapFrom(___ => ___.Description))
                .ForMember(_ => _.StartTime, __ => __.MapFrom(___ => ___.StartTime))
                .ForMember(_ => _.EndTime, __ => __.MapFrom(___ => ___.EndTime))
                .ForMember(_ => _.Image, __ => __.MapFrom(___ => ___.Image))
                .ForMember(_ => _.Members, __ => __.MapFrom(___ => ___.Members))
                .ForMember(_ => _.Spots, __ => __.MapFrom(___ => ___.Spots));
        }
    }
    public class AutoMapperConfig
    {
    }
}