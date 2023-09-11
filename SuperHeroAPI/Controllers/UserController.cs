using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;
using SuperHeroAPI.Models;
using System.Xml.Linq;

namespace SuperHeroAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly SuperHeroAPIdbContext superHeroAPIdb;

        public UserController(SuperHeroAPIdbContext superHeroAPIdb)
        {
            this.superHeroAPIdb = superHeroAPIdb;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await superHeroAPIdb.Users.ToListAsync());
        }

        [HttpGet]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> GetUser([FromRoute] Guid Id)
        {
            var User = await superHeroAPIdb.Users.FindAsync(Id);

            if (User == null)
            {
                return NotFound();
            }
            return Ok(User);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserRequest addUserRequest)
        {
            var User = new User
            {
                Id = Guid.NewGuid(),
                name = addUserRequest.name,
                email = addUserRequest.email,
                password = addUserRequest.password,
                FavHeroi = addUserRequest.FavHeroi
            };

            await superHeroAPIdb.Users.AddAsync(User);
            await superHeroAPIdb.SaveChangesAsync();

            return Ok(User);
        }

        [HttpPut]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid Id, UpdateUserRequest updateUserRequest)
        {
            var User = await superHeroAPIdb.Users.FindAsync(Id);

            if (User != null)
            {
                User.name = updateUserRequest.name;
                User.password = updateUserRequest.password;
                User.FavHeroi = updateUserRequest.FavHeroi;

                await superHeroAPIdb.SaveChangesAsync();

                return Ok(User);
            }
            return NotFound();
        }
    }
}
