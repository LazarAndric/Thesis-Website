using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using AutoMapper;
using WebAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepo _repository;
        private IMapper _mapper;

        public CategoryController(ICategoryRepo repostory, IMapper mapper)
        {
            _repository = repostory;
            _mapper= mapper;
        }
        //[Authorize]
        [HttpGet("")]
        public ActionResult <IEnumerable<CategoryReadDto>> GetAllCategories()
        {
            var categoryItems = _repository.GetAllCategories();
            return Ok(_mapper.Map<IEnumerable<CategoryReadDto>>(categoryItems));
        }

        //[Authorize]
        [HttpGet("/{id}", Name="GetCategoryById")]
        public ActionResult <CategoryReadDto> GetCategoryById(int id)
        {
            var categoryItem = _repository.GetCategoryById(id);
            if(categoryItem!=null)
            {
                return Ok(_mapper.Map<CategoryReadDto>(categoryItem));
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<CategoryReadDto> CreateCategory(CategoryCreateDto categoryCreateDto)
        {
            var categoryModel = _mapper.Map<Category>(categoryCreateDto);
            _repository.CreateCategory(categoryModel);
            _repository.SaveChanges();

            var categoryReadDto = _mapper.Map<CategoryReadDto>(categoryModel);

            return CreatedAtRoute(nameof(GetCategoryById), new {Id = categoryReadDto.Id}, categoryReadDto);
        }

        //[Authorize]
        [HttpPut("/{id}")]
        public ActionResult UpdateCategory(int id, CategoryUpdateDto categoryUpdateDto)
        {
            var categoryModelFromRepo = _repository.GetCategoryById(id);
            if(categoryUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(categoryUpdateDto, categoryModelFromRepo);

            _repository.UpdateCategory(categoryModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("/{id}")]
        public ActionResult PartialCategoryUpdate(int id, JsonPatchDocument<CategoryUpdateDto> pathDoc)
        {
            var categoryModelFromRepo = _repository.GetCategoryById(id);
            if(categoryModelFromRepo == null)
            {
                return NotFound();
            }

            var categoryToPatch = _mapper.Map<CategoryUpdateDto>(categoryModelFromRepo);
            pathDoc.ApplyTo(categoryToPatch, ModelState);
            if(!TryValidateModel(categoryToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(categoryToPatch,categoryModelFromRepo);

            _repository.UpdateCategory(categoryModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }
        
        //[Authorize]
        [HttpDelete("/{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var categoryModelFromRepo = _repository.GetCategoryById(id);
            if(categoryModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteCategory(categoryModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}