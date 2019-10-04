using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using ChecklistApp.API.Data;
using ChecklistApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChecklistApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IAppRepository _repo;
        private readonly IMapper _mapper;
        public ClientsController(IAppRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var clients = await _repo.GetClients(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
            var clientsToReturn= _mapper.Map<IEnumerable<ClientForListDto>>(clients);
            return Ok(clientsToReturn);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var client = await _repo.GetClient(id, int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
            return Ok(client);
        }
    }
}