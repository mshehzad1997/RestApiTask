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
    public class ManageUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ManageUsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var user = await (_db.users.Where(x => x.Status == true).Select(p => new
            {
                p.FullName,
                p.Email,
                p.Gender,
                p.ManageRoleId,
                p.Status
            })).ToListAsync();
            return Ok(user);
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
        [HttpPost]
        [Route("UpdateUsers")]
        public async Task<IActionResult> UpdateUser(Users model)
        {
            if (ModelState.IsValid)
            {
                var user = await _db.users.FindAsync(model.Id);
                if(user == null)
                {
                    return NotFound();
                }
                user.Email = model.Email;
                user.FullName = model.FullName;
                user.Gender = model.Gender;
                user.ManageRoleId = model.ManageRoleId;
                user.Status = model.Status;
                user.Password = model.Password;
                _db.users.Add(model);
               await _db.SaveChangesAsync();
                
            }
            return Ok();
        }
        [HttpPost]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _db.users.FirstOrDefaultAsync(x => x.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            
            if(user != null)
            {
                if(user.Status == true)
                {
                    user.Email = user.Email;
                    user.FullName = user.FullName;
                    user.Gender = user.Gender;
                    user.ManageRoleId = user.ManageRoleId;
                    user.Password = user.Password;
                    user.Status = false;
                    _db.users.Update(user);
                    await _db.SaveChangesAsync();
                }
                else
                {

                }
              
            }
            return Ok();

        }
    }
}
