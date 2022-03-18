using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiTask.Models;
using RestApiTask.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ManageUsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok();
        }
        [HttpPost]
        [Route("CreateUsers")]
        public async Task<IActionResult> CreateUsers(Users model)
        {
            if (ModelState.IsValid)
            {
                _db.users.Add(model);
              await _db.SaveChangesAsync();
            }
            return Ok();
        }
    }
}
