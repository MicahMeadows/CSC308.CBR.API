using AutoMapper;
using DataObjects;

namespace Data.AutoMapper;

public class MapperProfiles : Profile
{
    public MapperProfiles()
    {
        SourceMemberNamingConvention = new PascalCaseNamingConvention();
        DestinationMemberNamingConvention = new LowerUnderscoreNamingConvention();
        
        CreateMap<Models.Location, DbLocation>().ReverseMap();
        
        CreateMap<Models.Match, DbMatch>()
            .ForMember(dst => dst.ID, opt => opt.MapFrom(src => src.MatchID))
            .ForMember(dst => dst.BlueTeamLocation, opt => opt.MapFrom(src => src.BlueTeam))
            .ForMember(dst => dst.RedTeamLocation, opt => opt.MapFrom(src => src.RedTeam))
            .ForMember(dst => dst.RedTeamID, opt => opt.MapFrom(src => src.RedTeam.ID))
            .ForMember(dst => dst.BlueTeamID, opt => opt.MapFrom(src => src.BlueTeam.ID))
            .ReverseMap();

        CreateMap<Models.MatchResult, DbMatchResult>()
            .ReverseMap();
    }
}