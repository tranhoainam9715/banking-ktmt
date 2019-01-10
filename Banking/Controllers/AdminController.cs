using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.CoreProcess;
using Banking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AdminManager _manager;
        public AdminController(AdminManager manager)
        {
            _manager = manager;
        }
        // POST: api/Admin/user
        
        [HttpPost]
        [Route("user")]
        public void Post([FromBody] [Bind("Id", "Username", "HashPassowrd", "Name", "Type", "Phone", "Balance")] User user)
        {
            _manager.createUser(user);
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
