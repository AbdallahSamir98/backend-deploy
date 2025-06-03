//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AutoMapper;
//using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;
//using GraduationProjectStore.Core.Feature.Authentications.Query.Model;

//namespace GraduationProjectStore.Core.Mapping.Authentication
//{
//    public partial class AuthenticationProfile
//    {
//        public void UserQueryMapping()
//        {
//            CreateMap<UserModel, ApplicationUser>()
//                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid())) 
//                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User_UserName))
//                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User_PhoneNumber))
//                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.User_Password))
//                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User_Email))
//                .ForMember(dest => dest.EmailConfirmed, opt => opt.MapFrom(src => src.User_emailConfirmed))
//                .ForMember(dest => dest.PhoneNumberConfirmed, opt => opt.MapFrom(src => src.User_phoneNumberConfirmed))
//                .ForMember(dest => dest.SecurityStamp, opt => opt.MapFrom(src => src.User_securityStamp))
//                .ForMember(dest => dest.AccessFailedCount, opt => opt.MapFrom(src => int.Parse(src.User_accessFailedCount))) 
//                .ReverseMap()
//                .ForMember(dest => dest.User_accessFailedCount, opt => opt.MapFrom(src => src.AccessFailedCount.ToString()));
//        }
//    }

//}
