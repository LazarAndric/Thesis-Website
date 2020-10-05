using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using AutoMapper;
using WebAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using WebAPI.Utility;
using System;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;

namespace WebAPI.Conrollers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IConfiguration _config;
        Cryptography crypt = new Cryptography();
        private IUserRepo _repository;
        private IMapper _mapper;

        public UserController(IUserRepo repostory, IMapper mapper, IConfiguration config)
        {
            _config=config;
            _repository = repostory;
            _mapper= mapper;
        }
        

        [AllowAnonymous]
        [HttpGet("{action}")]
        public ActionResult<string> Login(LoginModel loginModel)
        {
            AuthRepository auth= new AuthRepository(_config);

            User user = _repository.LoginUser(loginModel.Email);
            if (user != null)
            {
                var dcrpt =crypt.Decrypt(user.Password);
                if ( dcrpt==loginModel.Password)
                {
                    var info=auth.CreateToken(user);
                    auth.ValidateToken(info);
                    return Ok(info);
                }
            }
            return NotFound();
        }
        [AllowAnonymous]
        [HttpGet("{action}")]
        public ActionResult<string> Validate(string token)
        {
            AuthRepository auth= new AuthRepository(_config);
            var info=auth.ValidateToken(token);
            if(info==null)
                return NotFound();
            return Ok(info);
        }
        
        
        //[Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItems));
        }

        //[Authorize]
        [HttpGet("{id}", Name="GetUserByIdd")]
        public ActionResult <UserReadDto> GetUserById(int id)
        {
            var userItem = _repository.GetUserById(id);
            if(userItem!=null)
            {
                var mappped=_mapper.Map<UserReadDto>(userItem);
                mappped.Password=crypt.Decrypt(mappped.Password);
                return Ok(mappped);
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            userCreateDto.Password = crypt.Encrypt(userCreateDto.Password);
            userCreateDto.DateOfRegistration=DateTime.Now;
            userCreateDto.LastLogin=DateTime.Now;
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return GetUserById(userReadDto.Id);
        }

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UserUpdateDto userUpdateDto)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if(userUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(userUpdateDto, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialUserUpdate(int id, JsonPatchDocument<UserUpdateDto> pathDoc)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if(userModelFromRepo == null)
            {
                return NotFound();
            }

            var userToPatch = _mapper.Map<UserUpdateDto>(userModelFromRepo);
            pathDoc.ApplyTo(userToPatch, ModelState);
            if(!TryValidateModel(userToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(userToPatch,userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if(userModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}