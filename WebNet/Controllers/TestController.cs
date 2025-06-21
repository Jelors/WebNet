using Microsoft.AspNetCore.Mvc;
using WebNet.Models;

namespace WebNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<User> Get()
        {
            var user = new User();
            user.Id = 37;
            user.Age = 21;
            user.Email = "wwwwww@gmail.com";
            user.Name = "John";
            user.Login = "TestLogin";
            user.Password = "password";

            return user;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"GET with id - {id}";
        }
        [HttpPost("{input}")]
        public string Post(string input)
        {
            return input;
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"This is DELETE with id - {id}";
        }
    }
}
