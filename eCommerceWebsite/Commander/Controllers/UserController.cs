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
    public class UserController : ControllerBase
    {
        private IUserRepo _repository;
        private IMapper _mapper;

        public UserController(IUserRepo repostory, IMapper mapper)
        {
            _repository = repostory;
            _mapper= mapper;
        }
        
        //GET api/comands
        [HttpGet]
        public ActionResult <IEnumerable<UserReadDto>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItems));
        }

        //GET api/commands/{id}
        [HttpGet("{id}", Name="GetUserByIdd")]
        public ActionResult <UserReadDto> GetUserById(int id)
        {
            var userItem = _repository.GetUserById(id);
            if(userItem!=null)
            {
                return Ok(_mapper.Map<UserReadDto>(userItem));
            }
            return NotFound();
        }

        //POST api/command/{id}
        [HttpPost]
        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return GetUserById(userReadDto.Id);
        }

        //PUT api/command/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, UserUpdateDto commandUpdateDto)
        {
            var commandModelFromRepo = _repository.GetUserById(id);
            if(commandUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(commandUpdateDto, commandModelFromRepo);

            _repository.UpdateUser(commandModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/comands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<UserUpdateDto> pathDoc)
        {
            var commandModelFromRepo = _repository.GetUserById(id);
            if(commandModelFromRepo == null)
            {
                return NotFound();
            }

            var commandToPatch = _mapper.Map<UserUpdateDto>(commandModelFromRepo);
            pathDoc.ApplyTo(commandToPatch, ModelState);
            if(!TryValidateModel(commandToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(commandToPatch,commandModelFromRepo);

            _repository.UpdateUser(commandModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //DELETE api/comands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandModelFromRepo = _repository.GetUserById(id);
            if(commandModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteUser(commandModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}