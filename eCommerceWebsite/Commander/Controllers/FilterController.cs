using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;
using AutoMapper;
using Commander.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;

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
            //ADD EVERYTHING WITH CONTEXT NOT WITH products
            if(_categoryRepo.GetCategoryById(filter.CategoryFilter.Id)==null)
                return NoContent();

            products=_productRepo.GetAllProductOfPriceRange(filter.PriceFilter);
            if(products==null)
                return NotFound();

            products=_productRepo.GetAllProductOfCategory(filter.CategoryFilter, products);
            if(products==null)
                return NotFound();

            var filtratedProductWithGender = _genderOfProductRepo.GetAllProductOfGender(filter.GenderFilter);
            if(filtratedProductWithGender==null)
                return NotFound();

            products=_productRepo.GetAllProductOfGender(filtratedProductWithGender, products);
            if(filtratedProductWithGender==null)
                return NotFound();

            var filtratedProductWithSize = _sizeOfProductRepo.GetAllProductsOfSize(filter.SizeFilter);
            if(filtratedProductWithGender==null)
                return NotFound();

            products=_productRepo.GetAllProductOfSize(filtratedProductWithSize, products);
            if(filtratedProductWithGender==null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }
    }
}