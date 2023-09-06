using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;
using SuperHeroAPI.Models;
using System.Security.Principal;

namespace SuperHeroAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : Controller
    {
        private readonly SuperHeroAPIdbContext superHeroAPIdb;

        public IdentityController(SuperHeroAPIdbContext superHeroAPIdb) {
            this.superHeroAPIdb = superHeroAPIdb;
        }

        [HttpGet]
        public async Task<IActionResult> GetIdentity()
        {
            return Ok(await superHeroAPIdb.Identities.ToListAsync());
        }

        [HttpGet]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> GetIdentity([FromRoute] Guid Id)
        {
            var identity1 = await superHeroAPIdb.Identities.FindAsync(Id);

            if (identity1 == null)
            {
                return NotFound();
            }
            return Ok(identity1);
        }

        [HttpPost]
        public async Task<IActionResult> AddIdentity(AddIdentityRequest addIdentityRequest)
        {
            var identity = new Identity
            {
                IdentityId = Guid.NewGuid(),
                Name = addIdentityRequest.Name,
                Idade = addIdentityRequest.Idade,
                AlterEgo = addIdentityRequest.AlterEgo,
                Publicadora = addIdentityRequest.Publicadora,
                Power = addIdentityRequest.Power,
                Strength = addIdentityRequest.Strength,
                Intelligence = addIdentityRequest.Intelligence,
                Combat = addIdentityRequest.Combat,
                Altura = addIdentityRequest.Altura,
                Peso = addIdentityRequest.Peso,
                Genero = addIdentityRequest.Genero,
                Race = addIdentityRequest.Race,
                Afiliaçoes = addIdentityRequest.Afiliaçoes,
                Parentes = addIdentityRequest.Parentes
            };

            await superHeroAPIdb.Identities.AddAsync(identity);
            await superHeroAPIdb.SaveChangesAsync();

            return Ok(identity);
        }

        [HttpPut]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> UpdateIdentity([FromRoute] Guid Id,UpdateIdentityRequest updateIdentityRequest){
            var contact = await superHeroAPIdb.Identities.FindAsync(Id);

            if(contact!= null)
            {
                contact.Name = updateIdentityRequest.Name;
                contact.Idade = updateIdentityRequest.Idade;
                contact.AlterEgo = updateIdentityRequest.AlterEgo;
                contact.Publicadora = updateIdentityRequest.Publicadora;
                contact.Power = updateIdentityRequest.Power;
                contact.Strength = updateIdentityRequest.Strength;
                contact.Intelligence = updateIdentityRequest.Intelligence;
                contact.Combat = updateIdentityRequest.Combat;
                contact.Altura = updateIdentityRequest.Altura;
                contact.Peso = updateIdentityRequest.Peso;
                contact.Genero = updateIdentityRequest.Genero;
                contact.Race = updateIdentityRequest.Race;
                contact.Afiliaçoes = updateIdentityRequest.Afiliaçoes;
                contact.Parentes = updateIdentityRequest.Parentes;

                await superHeroAPIdb.SaveChangesAsync();

                return Ok(contact);
            }
            return NotFound();
        }
    }
}
