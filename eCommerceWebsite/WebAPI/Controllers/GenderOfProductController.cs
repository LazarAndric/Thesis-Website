using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using AutoMapper;
using WebAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace WebAPI.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderOfProductController : ControllerBase
    {
        private IGenderOfProductRepo _repository;
        private IMapper _mapper;

        public GenderOfProductController(IGenderOfProductRepo repostory, IMapper mapper)
        {
            _repository = repostory;
            _mapper= mapper;
        }
        
        //[Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<GenderOfProductReadDto>> GetAllGenderOfProducts()
        {
            var genderOfProductItems = _repository.GetAllGenderOfProducts();
            return Ok(_mapper.Map<IEnumerable<GenderOfProductReadDto>>(genderOfProductItems));
        }

        //[Authorize]
        [HttpGet("{id}", Name="GetGenderOfProductByIdd")]
        public ActionResult <GenderOfProductReadDto> GetGenderOfProductById(int id)
        {
            var genderOfProductItem = _repository.GetGenderOfProductById(id);
            if(genderOfProductItem!=null)
            {
                return Ok(_mapper.Map<GenderOfProductReadDto>(genderOfProductItem));
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<GenderOfProductReadDto> CreateGenderOfProduct(GenderOfProductCreateDto genderOfProductCreateDto)
        {
            var genderOfProductModel = _mapper.Map<GenderOfProduct>(genderOfProductCreateDto);
            _repository.CreateGenderOfProduct(genderOfProductModel);
            _repository.SaveChanges();

            var genderOfProductReadDto = _mapper.Map<GenderOfProductReadDto>(genderOfProductModel);

            return GetGenderOfProductById(genderOfProductReadDto.Id);
        }

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateGender(int id, GenderOfProductUpdateDto genderUpdateDto)
        {
            var genderModelFromRepo = _repository.GetGenderOfProductById(id);
            if(genderUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(genderUpdateDto, genderModelFromRepo);

            _repository.UpdateGenderOfProduct(genderModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialGenderUpdate(int id, JsonPatchDocument<GenderOfProductUpdateDto> pathDoc)
        {
            var genderModelFromRepo = _repository.GetGenderOfProductById(id);
            if(genderModelFromRepo == null)
            {
                return NotFound();
            }

            var genderToPatch = _mapper.Map<GenderOfProductUpdateDto>(genderModelFromRepo);
            pathDoc.ApplyTo(genderToPatch, ModelState);
            if(!TryValidateModel(genderToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(genderToPatch,genderModelFromRepo);

            _repository.UpdateGenderOfProduct(genderModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteGender(int id)
        {
            var genderModelFromRepo = _repository.GetGenderOfProductById(id);
            if(genderModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteGenderOfProduct(genderModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}