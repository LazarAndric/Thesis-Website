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
    public class GenderController : ControllerBase
    {
        private IGenderRepo _repository;
        private IMapper _mapper;

        public GenderController(IGenderRepo repostory, IMapper mapper)
        {
            _repository = repostory;
            _mapper= mapper;
        }
        
        //[Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<GenderReadDto>> GetAllGenders()
        {
            var genderItems = _repository.GetAllGenders();
            return Ok(_mapper.Map<IEnumerable<GenderReadDto>>(genderItems));
        }

        //[Authorize]
        [HttpGet("{id}", Name="GetGenderByIdd")]
        public ActionResult <GenderReadDto> GetGenderById(int id)
        {
            var genderItem = _repository.GetGenderById(id);
            if(genderItem!=null)
            {
                return Ok(_mapper.Map<GenderReadDto>(genderItem));
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<GenderReadDto> CreateGender(GenderCreateDto genderCreateDto)
        {
            var genderModel = _mapper.Map<Gender>(genderCreateDto);
            _repository.CreateGender(genderModel);
            _repository.SaveChanges();

            var GenderReadDto = _mapper.Map<GenderReadDto>(genderModel);

            return GetGenderById(GenderReadDto.Id);
        }

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateGender(int id, GenderUpdateDto genderUpdateDto)
        {
            var genderModelFromRepo = _repository.GetGenderById(id);
            if(genderUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(genderUpdateDto, genderModelFromRepo);

            _repository.UpdateGender(genderModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialGenderUpdate(int id, JsonPatchDocument<GenderUpdateDto> pathDoc)
        {
            var genderModelFromRepo = _repository.GetGenderById(id);
            if(genderModelFromRepo == null)
            {
                return NotFound();
            }

            var genderToPatch = _mapper.Map<GenderUpdateDto>(genderModelFromRepo);
            pathDoc.ApplyTo(genderToPatch, ModelState);
            if(!TryValidateModel(genderToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(genderToPatch,genderModelFromRepo);

            _repository.UpdateGender(genderModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteGender(int id)
        {
            var genderModelFromRepo = _repository.GetGenderById(id);
            if(genderModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteGender(genderModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}