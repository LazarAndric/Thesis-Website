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
    public class SizeController : ControllerBase
    {
        private ISizeRepo _repository;
        private IMapper _mapper;

        public SizeController(ISizeRepo repostory, IMapper mapper)
        {
            _repository = repostory;
            _mapper= mapper;
        }
        
        //[Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<SizeReadDto>> GetAllSizes()
        {
            var sizeItems = _repository.GetAllSizes();
            return Ok(_mapper.Map<IEnumerable<SizeReadDto>>(sizeItems));
        }

        //[Authorize]
        [HttpGet("{id}", Name="GetSizeByIdd")]
        public ActionResult <SizeReadDto> GetSizeById(int id)
        {
            var sizeItem = _repository.GetSizeById(id);
            if(sizeItem!=null)
            {
                return Ok(_mapper.Map<SizeReadDto>(sizeItem));
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<SizeReadDto> CreateSize(SizeCreateDto sizeCreateDto)
        {
            var sizeModel = _mapper.Map<Size>(sizeCreateDto);
            _repository.CreateSize(sizeModel);
            _repository.SaveChanges();

            var sizeReadDto = _mapper.Map<SizeReadDto>(sizeModel);

            return GetSizeById(sizeReadDto.Id);
        }

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, SizeUpdateDto sizeUpdateDto)
        {
            var sizeModelFromRepo = _repository.GetSizeById(id);
            if(sizeUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(sizeUpdateDto, sizeModelFromRepo);

            _repository.UpdateSize(sizeModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialSizeUpdate(int id, JsonPatchDocument<SizeUpdateDto> pathDoc)
        {
            var sizeModelFromRepo = _repository.GetSizeById(id);
            if(sizeModelFromRepo == null)
            {
                return NotFound();
            }

            var sizeToPatch = _mapper.Map<SizeUpdateDto>(sizeModelFromRepo);
            pathDoc.ApplyTo(sizeToPatch, ModelState);
            if(!TryValidateModel(sizeToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(sizeToPatch,sizeModelFromRepo);

            _repository.UpdateSize(sizeModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteSize(int id)
        {
            var sizeModelFromRepo = _repository.GetSizeById(id);
            if(sizeModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteSize(sizeModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}