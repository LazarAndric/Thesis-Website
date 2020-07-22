using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;
using AutoMapper;
using Commander.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace Commander.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeOfProductController : ControllerBase
    {
        private ISizeOfProductRepo _repository;
        private IMapper _mapper;

        public SizeOfProductController(ISizeOfProductRepo repostory, IMapper mapper)
        {
            _repository = repostory;
            _mapper= mapper;
        }
        
        //[Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<SizeOfProductReadDto>> GetAllSizeOfProducts()
        {
            var sizeOfProductItems = _repository.GetAllSizeOfProducts();
            return Ok(_mapper.Map<IEnumerable<SizeOfProductReadDto>>(sizeOfProductItems));
        }

        //[Authorize]
        [HttpGet("{id}", Name="GetSizeOfProductByIdd")]
        public ActionResult <SizeOfProductReadDto> GetSizeOfProductById(int id)
        {
            var sizeOfProductItem = _repository.GetSizeOfProductById(id);
            if(sizeOfProductItem!=null)
            {
                return Ok(_mapper.Map<SizeOfProductReadDto>(sizeOfProductItem));
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<SizeOfProductReadDto> CreateSizeOfProduct(SizeOfProductCreateDto sizeOfProductCreateDto)
        {
            var sizeOfProductModel = _mapper.Map<SizeOfProduct>(sizeOfProductCreateDto);
            _repository.CreateSizeOfProduct(sizeOfProductModel);
            _repository.SaveChanges();

            var SizeOfProductReadDto = _mapper.Map<SizeOfProductReadDto>(sizeOfProductModel);

            return GetSizeOfProductById(SizeOfProductReadDto.Id);
        }

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateSizeOfProduct(int id, SizeOfProductUpdateDto sizeOfProductUpdateDto)
        {
            var sizeOfProductModelFromRepo = _repository.GetSizeOfProductById(id);
            if(sizeOfProductUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(sizeOfProductUpdateDto, sizeOfProductModelFromRepo);

            _repository.UpdateSizeOfProduct(sizeOfProductModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialSizeOfProductUpdate(int id, JsonPatchDocument<SizeOfProductUpdateDto> pathDoc)
        {
            var sizeOfProductModelFromRepo = _repository.GetSizeOfProductById(id);
            if(sizeOfProductModelFromRepo == null)
            {
                return NotFound();
            }

            var sizeOfProductToPatch = _mapper.Map<SizeOfProductUpdateDto>(sizeOfProductModelFromRepo);
            pathDoc.ApplyTo(sizeOfProductToPatch, ModelState);
            if(!TryValidateModel(sizeOfProductToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(sizeOfProductToPatch,sizeOfProductModelFromRepo);

            _repository.UpdateSizeOfProduct(sizeOfProductModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteSizeOfProduct(int id)
        {
            var sizeOfProductModelFromRepo = _repository.GetSizeOfProductById(id);
            if(sizeOfProductModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteSizeOfProduct(sizeOfProductModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}