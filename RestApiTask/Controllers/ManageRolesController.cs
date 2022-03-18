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
    public class ManageRolesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ManageRolesController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(ManageRoles model)
        {
            if (ModelState.IsValid)
            {
                _db.manageRoles.Add(model);
                await _db.SaveChangesAsync();
            }
            return Ok();
        }
        [HttpPost]
        [Route("UpdateRole")]
        public async Task<IActionResult> UpdateRole(ManageRoles model)
        {
            if (ModelState.IsValid)
            {
                var role = await _db.manageRoles.FindAsync(model.Id);
                if(role == null)
                {
                    return NotFound();
                }
                if(model.RoleName == null)
                {
                    role.Description = model.Description;
                    role.DemoRequests = model.DemoRequests;
                    role.ManageTenants = model.ManageTenants;
                    role.Payments = model.Payments;
                    _db.manageRoles.Update(role);
                    await _db.SaveChangesAsync();
                }
                else
                {
                    return BadRequest("Cannot Update Name");
                }
          
               
            }
            return Ok();
        }
    }
}
