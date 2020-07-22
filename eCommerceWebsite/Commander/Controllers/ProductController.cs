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
    public class ProductController : ControllerBase
    {
        private ICategoryRepo _categoryRepo;
        private IProductRepo _repository;
        private IMapper _mapper;

        public ProductController(IProductRepo repostory, IMapper mapper, ICategoryRepo categoryRepo)
        {
            _categoryRepo=categoryRepo;
            _repository = repostory;
            _mapper= mapper;
        }
        
        //[Authorize]
        [HttpGet]
        public ActionResult <IEnumerable<ProductReadDto>> GetAllProducts()
        {
            var productItems = _repository.GetAllProduct();
            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }

        //[Authorize]
        [HttpGet("{id}", Name="GetProductById")]
        public ActionResult <ProductReadDto> GetProductById(int id)
        {
            var productItem = _repository.GetProductById(id);
            if(productItem!=null)
            {
                return Ok(_mapper.Map<ProductReadDto>(productItem));
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto productCreateDto)
        {
            if(_categoryRepo.GetCategoryById((int)productCreateDto.ProductCategoryId)==null)
                return NoContent();
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.CreateProduct(productModel);
            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtRoute(nameof(GetProductById), new {Id = productReadDto}, productReadDto);
        }

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
             if(_categoryRepo.GetCategoryById((int)productUpdateDto.ProductCategoryId)==null)
                return NoContent();
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
            
            if(_categoryRepo.GetCategoryById((int)productModelFromRepo.ProductCategoryId)==null)
                return NoContent();
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