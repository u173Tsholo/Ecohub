using EcoHub.Data;
using EcoHub.Models;
using EcoHub.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcoHub.Controllers
{
    [Route("controller")]
    [ApiController]
    public class UserManagementController : Controller
    {
        private readonly IUserManagementService _service;
        public UserManagementController(IUserManagementService service)
        {
            _service = service;
        }
        
        [HttpPost(Name = "AddNewUser")]
        public void AddNewUser(User user)
        {
             _service.CreateUser(user);
        }

    }
}
