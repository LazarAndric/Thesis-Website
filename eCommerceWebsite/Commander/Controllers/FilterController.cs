using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;
using AutoMapper;
using Commander.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Commander.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        List<Product> products = new List<Product>();
        private ISizeOfProductRepo _sizeOfProductRepo;
        private ICategoryRepo _categoryRepo;
        private IProductRepo _productRepo;
        private IGenderOfProductRepo _genderOfProductRepo;
        private IMapper _mapper;

        public FilterController(ISizeOfProductRepo sizeOfProductRepo, IProductRepo repostory, IMapper mapper, ICategoryRepo categoryRepo, IGenderOfProductRepo genderOfProductRepo)
        {
            _sizeOfProductRepo=sizeOfProductRepo;
            _genderOfProductRepo=genderOfProductRepo;
            _categoryRepo=categoryRepo;
            _productRepo = repostory;
            _mapper= mapper;
            products.AddRange(_productRepo.GetAllProduct());
        }

        //[Authorize]
        [HttpGet("{action}")]
        public ActionResult <IEnumerable<ProductReadDto>> Search(FiltersSearchDto filter)
        {
            var productList=_productRepo.GetAllProductOfPriceRange(filter.PriceFilter);
            if(productList==null)
                return NoContent();
            products=productList;

            productList=_productRepo.GetAllProductOfCategory(filter.CategoryFilter, products);
            if(productList!=null)
                products=productList;

            var filtratedProductWithGender = _genderOfProductRepo.GetAllProductOfGender(filter.GenderFilter);
            if(filtratedProductWithGender!=null)
            {
                productList=_productRepo.GetAllProductOfGender(filtratedProductWithGender, products);
                if(productList!=null)
                    products=productList;
            }
            
            var filtratedProductWithSize = _sizeOfProductRepo.GetAllProductsOfSize(filter.SizeFilter);
            if(filtratedProductWithSize!=null)
            {
                productList=_productRepo.GetAllProductOfSize(filtratedProductWithSize, products);
                if(productList!=null)
                    products=productList;
            }
            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }
    }
}