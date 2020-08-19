using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;
using AutoMapper;
using Commander.Dtos;

namespace Commander.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        static List<Product> products = new List<Product>();
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

        //[Authorize]
        [HttpGet("{action}")]
        public ActionResult <IEnumerable<ProductReadDto>> Initialize()
        {
            products=_productRepo.GetAllProduct();
            return Ok(products);
        }
        //[Authorize]
        [HttpGet("filter/{action}")]
        public ActionResult <IEnumerable<ProductReadDto>> Filtrate(FiltersSearchDto filter)
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

        [HttpGet("filter/{action}")]
        public ActionResult <IEnumerable<ProductReadDto>> Create()
        {
            FiltersReadDto filter = new FiltersReadDto();

            //ReadPrice
            var priceFilter = new FilterForPriceReadDto();
            priceFilter.MaxPriceFrom=_productRepo.GetMinPriceOfProducts();
            priceFilter.MaxPriceTo=_productRepo.GetMaxPriceOfProducts();
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
        //[Authorize]
        [HttpGet("{action}/{name}")]
        public ActionResult <List<ProductReadDto>> Search(string name)
        {
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
            {
                products=_productRepo.GetAllProduct();
                return NoContent();
            }
            var newList= new List<Product>();
            foreach(Product product in products)
                if(product.Name.ToLower().Contains(name.ToLower()))
                    newList.Add(product);
            products=newList;
            return Ok(products);
        }
    }
}