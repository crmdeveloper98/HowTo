using AutoMapper;
using HowToAPI.Dtos;
using HowToAPI.Models;

namespace HowToAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        { 
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
