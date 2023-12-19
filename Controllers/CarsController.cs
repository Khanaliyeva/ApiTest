using ApiIntro.DAL;
using ApiIntro.DTOs.CarDtos;
using ApiIntro.Entities;
using ApiIntro.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        private readonly IReposiroty _reposiroty;

        public CarsController( IReposiroty reposiroty)
        {
            _reposiroty = reposiroty;
        }

        [HttpGet]
        
        public async Task<IActionResult> GetAll()
        {
            var cars = await _reposiroty.GetAll(c=>c.Id>=5);

            return StatusCode(StatusCodes.Status200OK, cars);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var cars = await _reposiroty.GetById(id);
            if (cars == null) return StatusCode(StatusCodes.Status404NotFound);
            return StatusCode(StatusCodes.Status200OK, cars);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateCarDto cardto)
        {
            Car car = new Car()
            {
                Name=cardto.Name,
                Description=cardto.Description,
                BrandId=cardto.BrandId,
                ColorID=cardto.ColorID,
                DailyPrice=cardto.DailyPrice      

    };
            await _reposiroty.Create(car);
            await _reposiroty.SaceChangesAsync();

            return StatusCode(StatusCodes.Status200OK, car);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, string name, string description, DateTime time, string brand, string color)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);

            var cars = await _reposiroty.GetById(id);

            if (cars == null) return StatusCode(StatusCodes.Status404NotFound);

            cars.Name = name;
            cars.Description = description;
            cars.ModelYear = time;
            await _reposiroty.SaceChangesAsync();
            return StatusCode(StatusCodes.Status200OK, cars);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var cars = _reposiroty.GetById(id);
            // _reposiroty.Delete(cars);
            await _reposiroty.SaceChangesAsync();
            return StatusCode(StatusCodes.Status200OK, cars);

        }
    }
}