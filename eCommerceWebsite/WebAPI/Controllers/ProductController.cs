using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using AutoMapper;
using WebAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using System;

namespace WebAPI.Conrollers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ISizeOfProductRepo _sizeOfProductRepo;
        private IGenderRepo _genderRepo;
        private ISizeRepo _sizeRepo;
        private IGenderOfProductRepo _genderOfProductRepo;
        private ICategoryRepo _categoryRepo;
        private IProductRepo _repository;
        private IMapper _mapper;

        public ProductController(IGenderRepo genderRepo, ISizeRepo sizeRepo, IProductRepo repostory, IMapper mapper, ICategoryRepo categoryRepo, ISizeOfProductRepo sizeOfProductRepo, IGenderOfProductRepo genderOfProductRepo)
        {
            _genderRepo=genderRepo;
            _sizeRepo=sizeRepo;
            _categoryRepo=categoryRepo;
            _repository = repostory;
            _sizeOfProductRepo=sizeOfProductRepo;
            _genderOfProductRepo=genderOfProductRepo;
            _mapper= mapper;
        }
        
        [AllowAnonymous]
        [HttpGet]
        public ActionResult <IEnumerable<ProductReadDto>> GetAllProducts()
        {
            var products = _repository.GetAllProduct();
            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }

        [AllowAnonymous]
        [HttpGet("{action}")]
        public IActionResult MostPopular()
        {
            return Ok(_repository.GetMostPopularProduct());
        }

        [AllowAnonymous]
        [HttpGet("{action}")]
        public IActionResult MostPurchases()
        {
            return Ok(_repository.GetMostPurchasesProduct());
        }
        [AllowAnonymous]
        [HttpGet("{action}")]
        public IActionResult LatestProduct()
        {
            return Ok(_repository.GetLatestProduct());
        }

        [AllowAnonymous]
        [HttpGet("{action}/{id}")]
        public IActionResult ViewsCounts(int id)
        {
            var product=_repository.GetProductById(id);
            product.NumberOfViews++;

            _repository.SaveChanges();
            return Ok();
        }
        [AllowAnonymous]
        [HttpGet("{action}/{id}")]
        public IActionResult PurchasesCounts(int id)
        {
            var product=_repository.GetProductById(id);
            product.NumberOfPurchases++;
            return Ok();
        }
        [AllowAnonymous]
        [HttpGet("{action}/{id}")]
        public ActionResult <ProductReadDto> GetProductById(int id)
        {
            ProductReadDto product= new ProductReadDto();
            var productItem = _repository.GetProductById(id);
            product=_mapper.Map<ProductReadDto>(productItem);

            Category category= new Category();
            category=_categoryRepo.GetCategoryById((int)productItem.CategoryId);
            product.Category=category;

            List<Gender> gender= new List<Gender>();
            var genderId= _genderOfProductRepo.GetAllIdOfGender(productItem);
            foreach(var gId in genderId)
                gender.Add(_genderRepo.GetGenderById(gId));
            product.Genders=gender;

            List<Size> size = new List<Size>();
            var sizeId= _sizeOfProductRepo.GetAllProductIdsOfSize(productItem);
            foreach(var sId in sizeId)
                size.Add(_sizeRepo.GetSizeById(sId));
            product.Size=size;
            if(productItem!=null)
            {
                return Ok(product);
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto productCreateDto)
        {
            if(_categoryRepo.GetCategoryById((int)productCreateDto.CategoryId)==null)
                return NotFound();
            productCreateDto.DateOfCreate=DateTime.Now;
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.CreateProduct(productModel);
            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return Ok(productReadDto);
        }
        

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
             if(_categoryRepo.GetCategoryById((int)productUpdateDto.ProductCategoryId)==null)
                return NotFound();
            var productModelFromRepo = _repository.GetProductById(id);
            if(productUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(productUpdateDto, productModelFromRepo);

            _repository.UpdateProduct(productModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialProductUpdate(int id, JsonPatchDocument<ProductUpdateDto> pathDoc)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if(productModelFromRepo == null)
            {
                return NotFound();
            }
            
            if(_categoryRepo.GetCategoryById((int)productModelFromRepo.CategoryId)==null)
                return NotFound();
            var productToPatch = _mapper.Map<ProductUpdateDto>(productModelFromRepo);
            pathDoc.ApplyTo(productToPatch, ModelState);
            if(!TryValidateModel(productToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(productToPatch,productModelFromRepo);

            _repository.UpdateProduct(productModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //DELETE api/comands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if(productModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteProduct(productModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}