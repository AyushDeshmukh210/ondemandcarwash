using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnDemandCarWash.DataContext;
using OnDemandCarWash.DTO;
using OnDemandCarWash.Model.cs;

namespace OnDemandCarWash.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : ControllerBase
        {
            private readonly    OnDemandDbContext _context;
            public UserController(OnDemandDbContext context)
            {
                _context = context;
            }
            [HttpGet]
            public async Task<ActionResult<IEnumerable<User>>> GetUser()
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }

                return await _context.Users.ToListAsync();
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<IEnumerable<User>>> GetUserById(int id)
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }

                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);
            }

            public static User users = new User();
            [HttpPost]
            public async Task<ActionResult<IEnumerable<User>>> PostUser(Createuser createuser)
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }
                users.FullName = createuser.FullName;
                users.Email = createuser.Email;
                users.Password = createuser.Password;
                users.Address = createuser.Address;
                users.Role = createuser.Role;
                await _context.Users.AddAsync(users);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetUser", new { id = users.Id }, users);
            }

            [HttpPut]
            public async Task<ActionResult> UpdateUser(int id, UserUpdated userUpdatedto)
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    user.FullName = userUpdatedto.FullName;
                    user.Email = userUpdatedto.Email;
                    user.Password = userUpdatedto.Password;
                    user.Address = userUpdatedto.Address;
                }

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return NoContent();
            }

            [HttpDelete("{id}")]

            public async Task<ActionResult> DeleteUser(int id)
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                // no asyn method for remove so no await for remove
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return Ok(user);
            }
        }   
    }
