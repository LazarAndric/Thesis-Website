using System;
using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReadDto>();  
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserUpdateDto>();
            
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductUpdateDto>();

            CreateMap<Category, CategoryReadDto>();  
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();

            CreateMap<ProductOfUser, ProductOfUserReadDto>();  
            CreateMap<ProductOfUserCreateDto, ProductOfUser>();
            CreateMap<ProductOfUserUpdateDto, ProductOfUser>();
            CreateMap<ProductOfUser, ProductOfUserUpdateDto>();

            CreateMap<Size, SizeReadDto>();  
            CreateMap<SizeCreateDto, Size>();
            CreateMap<SizeUpdateDto, Size>();
            CreateMap<Size, SizeUpdateDto>();

            CreateMap<Gender, GenderReadDto>();
            CreateMap<GenderCreateDto, Gender>();
            CreateMap<GenderUpdateDto, Gender>();
            CreateMap<Gender, GenderUpdateDto>();

            CreateMap<SizeOfProduct, SizeOfProductReadDto>();  
            CreateMap<SizeOfProductCreateDto, SizeOfProduct>();
            CreateMap<SizeOfProductUpdateDto, SizeOfProduct>();
            CreateMap<SizeOfProduct, SizeOfProductUpdateDto>();

            CreateMap<GenderOfProduct, GenderOfProductReadDto>();
            CreateMap<GenderOfProductCreateDto, GenderOfProduct>();
            CreateMap<GenderOfProductUpdateDto, GenderOfProduct>();
            CreateMap<GenderOfProduct, GenderOfProductUpdateDto>();
        }
    }
}