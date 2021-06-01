using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConectionsController : ControllerBase
    {
        private readonly IUsersService _userService;
        public ConectionsController(IUsersService usersService)
        {
            _userService = usersService;
        }

        [HttpGet]
        public async Task<List<ConnectionModel>> Index(string homeWorld)
        {
            return await _userService.FindByHomeworld(homeWorld);
        }
    }
}
