using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Services;
using System;
using System.Threading.Tasks;

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _userService;
        public UsersController(IUsersService usersService)
        {
            _userService = usersService;
        }

        [HttpGet("{id}")]
        public async Task<UserModel> Get(int id)
        {
            return await _userService.GetById(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserModel model)
        {
            try
            {
                await _userService.Create(model);
            }
            catch (Exception ex)
            {
                // maybe we can log the exception
                return StatusCode(500, ex.Message);
            }

            return Created($"/api/Users/{model.Id}", model.Id);
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UserModel model)
        {
            try
            {
                await _userService.Update(model, id);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _userService.Delete(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            return NoContent();
        }
    }
}
