using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context){
            _context = context;
        }
        [HttpGet]       
        public ActionResult<IEnumerable<AppUser>> GetUser(){
            var user = _context.Users.ToList();
            return user;

        }
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id){
            return _context.Users.Find(id);

        }
    }
}