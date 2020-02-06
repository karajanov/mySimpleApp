using AutoMapper;
using SimpleCoreApp.Models;
using SimpleCoreApp.Models.DataTransferObjects;

namespace SimpleCoreApp.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Products, ProductViewModel>()
                .ReverseMap();

            CreateMap<Products, UpdateProductViewModel>()
                .ReverseMap();
        }
    }
}
