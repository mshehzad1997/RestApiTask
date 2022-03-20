using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet]
        [Route("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var payment = await _db.Payments.ToListAsync();
            var tenant = await _db.manageTenants.ToListAsync();
            var roles = await _db.manageRoles.ToListAsync();
            var manageUser = await _db.manageUsers.ToListAsync();
            var rolemanage = await _db.rolesManages.ToListAsync();
            var management = await _db.userManagements.ToListAsync();
            var demoRequest = await _db.demoRequests.ToListAsync();
            var role = (from mr in roles
                        join x in payment on mr.Id equals x.Id

                        join t in tenant on mr.Id equals t.Id
                        join d in demoRequest on mr.Id  equals d.Id
                        join m in management on mr.Id equals m.Id
                        join u in manageUser on m.Id equals u.Id
                        join re in rolemanage on m.Id equals re.Id
                        select new 
                        {
                           
                            mr.RoleName,
                            mr.Description,
                            x.ChangeStatus,
                            x.ViewPayment,
                            t.RegisterTenant,
                            t.RessetPassword,
                            t.UpdateTenant,
                            t.ViewTenant,
                            d.ViewRequest,
                            d.ApproveRequest,
                            u.Inactive,
                            u.CreateUser,
                            u.Reset,
                            re.UpdateRole,
                            re.ViewRole

                        }).ToList();
            return Ok(role);
        }
        [HttpGet]
        [Route("RoleDetails")]
        public async Task<IActionResult> RoleDetails(int id)
        {
            
            var detail =await _db.manageRoles.Where(x => x.Id == id).FirstOrDefaultAsync();
            if(detail == null)
            {
                return NotFound();
            }
            return Ok(detail);
        }
        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole( ManageRoles model)
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
                    role.UserManagements = model.UserManagements;
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
       [HttpPost]
       [Route("DeleteRole")]
       public async Task<IActionResult> DeleteRole(int id)
        {
            var role = _db.manageRoles.SingleOrDefault(x => x.Id == id);
            if(role == null)
            {
                NotFound();
            }
            try
            {
                _db.manageRoles.Remove(role);
                await _db.SaveChangesAsync();
            }
            catch
            {
                return BadRequest("Cannot delete Role is already in use");
            }
           
            return Ok();
        }
        
    }
}
