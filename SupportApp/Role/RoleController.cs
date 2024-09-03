using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportApp.Data;
using SupportApp.Role.Repository;

namespace SupportApp.Role
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private readonly RoleRepository _roleRepository;

        public RoleController(ApplicationDBContext context, IMapper mapper, RoleRepository roleRepository)
        {
            _context = context;
            _mapper = mapper;
            _roleRepository = roleRepository; 
        }
    }
}

