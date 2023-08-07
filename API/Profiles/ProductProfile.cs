using API.DTOs;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
