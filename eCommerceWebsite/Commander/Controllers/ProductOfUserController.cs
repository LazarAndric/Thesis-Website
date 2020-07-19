using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;
using AutoMapper;
using Commander.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using System;

namespace Commander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOfUserController : ControllerBase
    {
        private IProductRepo _productRepo;
        private IUserRepo _userRepo;
        private IProductOfUserRepo _repository;
        private IMapper _mapper;
        public ProductOfUserController(IProductOfUserRepo repository, IMapper mapper, IUserRepo userRepo, IProductRepo productRepo)
        {
            _productRepo=productRepo;
            _userRepo=userRepo;
            _repository=repository;
            _mapper=mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<ProductOfUser>> GetAllProductsOfUsers(){
            var productOfUsers = _repository.GetAllProductOfUsers();
            return Ok(_mapper.Map<IEnumerable<ProductOfUserReadDto>>(productOfUsers));
        }

        [HttpGet("{id}", Name="GetProductOfUserById")]
        public ActionResult <ProductOfUser> GetProductOfUserById(int id)
        {
            var productOfUserItem = _repository.GetProductOfUserById(id);
            return Ok(_mapper.Map<ProductOfUserReadDto>(productOfUserItem));
        }

        [HttpGet("user{id}", Name="GetProductsOfUserById")]
        public ActionResult <IEnumerable<ProductOfUser>> GetProductsOfUserById(int id)
        {
            var productsOfUser = _repository.GetProductsOfUserById(id);
            return Ok(_mapper.Map<IEnumerable<ProductOfUserReadDto>>(productsOfUser));
        }

        //POST api/command{id}
        [HttpPost]
        public ActionResult<ProductReadDto> CreateProductOfUser(ProductOfUserCreateDto prodcutOfUserCreateDto)
        {
            if(_userRepo.GetUserById((int)prodcutOfUserCreateDto.UserId)==null || _productRepo.GetProductById((int)prodcutOfUserCreateDto.UserId)==null)
                return NoContent();
            var productOfUserModel = _mapper.Map<ProductOfUser>(prodcutOfUserCreateDto);
            _repository.CreateProductOfUser(productOfUserModel);
            _repository.SaveChanges();

            var prodcutOfUserReadDto = _mapper.Map<ProductOfUserReadDto>(productOfUserModel);

            return CreatedAtRoute(nameof(GetProductOfUserById), new {Id= prodcutOfUserReadDto.Id}, prodcutOfUserReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, ProductOfUserUpdateDto productOfUserUpdateDto)
        {
            var productOfUserModelFromRepo = _repository.GetProductOfUserById(id);
            if(productOfUserUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(productOfUserUpdateDto, productOfUserModelFromRepo);

            _repository.UpdateProductOfUser(productOfUserModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialProductOfUserUpdate(int id, JsonPatchDocument<ProductOfUserUpdateDto> pathDoc)
        {
            var productOfUserModelFromRepo = _repository.GetProductOfUserById(id);
            if(productOfUserModelFromRepo==null)
            {
                return NotFound();
            }

            var productOfUserToPatch=_mapper.Map<ProductOfUserUpdateDto>(productOfUserModelFromRepo);
            pathDoc.ApplyTo(productOfUserToPatch, ModelState);
            if(!TryValidateModel(productOfUserToPatch))
            {
                return ValidationProblem(ModelState);
            }
            
            _mapper.Map(productOfUserToPatch,productOfUserModelFromRepo);

            _repository.UpdateProductOfUser(productOfUserModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProductOfUser(int id)
        {
            var productOfUserModelFromRepo =  _repository.GetProductOfUserById(id);
            if(productOfUserModelFromRepo==null)
            {
                return NotFound();
            }

            _repository.DeleteProductOfUser(productOfUserModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}