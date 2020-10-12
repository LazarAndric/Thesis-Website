using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using AutoMapper;
using WebAPI.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Conrollers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private IGenderRepo _genderRepo;
        private ISizeOfProductRepo _sizeOfProductRepo;
        private ICategoryRepo _categoryRepo;
        private IProductRepo _productRepo;
        private IGenderOfProductRepo _genderOfProductRepo;
        private ISizeRepo _sizeRepo;
        private IMapper _mapper;

        public ShopController(ISizeRepo sizeRepo, IGenderRepo genderRepo, ISizeOfProductRepo sizeOfProductRepo, IProductRepo repostory, IMapper mapper, ICategoryRepo categoryRepo, IGenderOfProductRepo genderOfProductRepo)
        {
            _sizeRepo=sizeRepo;
            _sizeOfProductRepo=sizeOfProductRepo;
            _genderOfProductRepo=genderOfProductRepo;
            _genderRepo=genderRepo;
            _categoryRepo=categoryRepo;
            _productRepo = repostory;
            _mapper= mapper;
        }
        [AllowAnonymous]
        [HttpGet("{action}")]
        public ActionResult <List<ProductReadDto>> Filtrate(FiltersSearchDto filter)
        {
            List<Product> products= _productRepo.GetAllProduct();
            var productList = new List<Product>();
            //Search
            if(!string.IsNullOrWhiteSpace(filter.Search) || !string.IsNullOrEmpty(filter.Search))
            {
                foreach(Product product in products)
                    if(product.Name.ToLower().Contains(filter.Search.ToLower()))
                        productList.Add(product);
                    products=productList;
                    if(products==null)
                        return NoContent();
            }
            

            if(filter.PriceFilter!=null){
                productList=_productRepo.GetAllProductOfPriceRange(filter.PriceFilter, products);
                if(productList!=null)
                    products=productList;
            }
            
            if(filter.CategoryFilter!=null)
            {
            productList=_productRepo.GetAllProductOfCategory(filter.CategoryFilter, products);
            if(productList!=null)
                products=productList;
            }

            if(filter.GenderFilter!=null)
            {
                var filtratedProductWithGender = _genderOfProductRepo.GetAllProductOfGender(filter.GenderFilter);
                if(filtratedProductWithGender!=null)
                {
                    productList=_productRepo.GetAllProductOfGender(filtratedProductWithGender, products);
                    if(productList!=null)
                        products=productList;
                }
            }
            
            if(filter.SizeFilter!=null){
                var filtratedProductWithSize = _sizeOfProductRepo.GetAllProductsOfSize(filter.SizeFilter);
                if(filtratedProductWithSize!=null)
                {
                    productList=_productRepo.GetAllProductOfSize(filtratedProductWithSize, products);
                    if(productList!=null)
                        products=productList;
                }
            }
            
            if(filter.SortItems!=null){
                if(filter.SortItems.NameOfSort!=null){
                    switch (filter.SortItems.NameOfSort.ToLower())
                    {
                        case "name" : productList= _productRepo.SortProductsByName(products, filter.SortItems.OrderBy); break;
                        case "price" : productList= _productRepo.SortProductsByPrice(products, filter.SortItems.OrderBy); break;
                        case "views" : productList= _productRepo.SortProductsByViews(products, filter.SortItems.OrderBy); break;
                        default: break;
                    }
                    if(productList==null)
                        return NoContent();
                    products=productList;
                }
            }
            return Ok(_mapper.Map<List<ProductReadDto>>(products));
        }
        
        [AllowAnonymous]
        [HttpGet("Filter/{action}")]
        public ActionResult <List<ProductReadDto>> Create()
        {
            List<Product> products = _productRepo.GetAllProduct();
            FiltersReadDto filter = new FiltersReadDto();

            //ReadPrice
            var priceFilter = new FilterForPriceReadDto();
            priceFilter.MaxPriceFrom=_productRepo.GetMinPriceOfProducts(products);
            priceFilter.MaxPriceTo=_productRepo.GetMaxPriceOfProducts(products);
            if(priceFilter.MaxPriceFrom !=null || priceFilter.MaxPriceTo!=null)
                filter.PriceFilter=priceFilter;

            //ReadCategory
            var categories= new List<Category>();
            if(products!=null)
                foreach(Product product in products)
                    if(!categories.Contains(product.Category))
                        categories.Add(product.Category);
            var categoriesFilter = new FilterForCategoriesReadDto();
            var categoryList = new List<FilterForCategoryReadDto>();
            for(int i=0;i<categories.Count;i++)
            {
                var length= _productRepo.GetLegthOfProductList(categories[i], products);
                if(length>0)
                {
                    var filterCategory  = new FilterForCategoryReadDto();
                    filterCategory.Length=length;
                    filterCategory.Id =  categories[i].Id;
                    filterCategory.Name =  categories[i].Name;
                    categoryList.Add(filterCategory);
                }
            }
            categoriesFilter.listOfCategoryFilter=categoryList;
            filter.CategoriesFilter=categoriesFilter;

            //ReadGender
            var genderFilterList= new GendersFilter();
            var genderList= new List<FilterForGenderReadDto>();
            var listOfGenderId= _genderOfProductRepo.GetAllIdOfGenders(products);
            if(listOfGenderId!=null)
            {
                foreach(int Id in listOfGenderId)
                {
                    var genderFilter= new FilterForGenderReadDto();
                    var gender=_genderRepo.GetGenderById(Id);
                    var length=_genderOfProductRepo.LengthOfGender(gender, products);
                    if(length>0)
                    {
                        genderFilter.Id=gender.Id;
                        genderFilter.Name=gender.Name;
                        genderFilter.Length=length;
                        genderList.Add(genderFilter);
                    }
                }
                genderFilterList.GenderList=genderList;
            }
            filter.GenderFilter=genderFilterList;

            //ReadSize
            var sizeFilter= new FilterSizes();
            var sizeFilters = new List<FilterForSizeReadDto>();
            var sizesList = _sizeOfProductRepo.GetAllIdOfSize(products);
            if(sizesList!=null)
            {
                foreach (var Id in sizesList)
                {
                    var sizes= new FilterForSizeReadDto();
                    var size=_sizeRepo.GetSizeById(Id);
                    var length=_sizeOfProductRepo.LengthOfSize(size, products);
                    if(length>0)
                    {
                        sizes.Id=size.Id;
                        sizes.Name=size.Name;
                        sizes.Length=length;
                        sizeFilters.Add(sizes);
                    }
                }
                sizeFilter.sizesFilterList=sizeFilters;
                filter.SizeFilter=sizeFilter;
                
            }
            return Ok(filter);
        }
    }
}