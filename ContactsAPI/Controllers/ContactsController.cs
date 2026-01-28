using ContactsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsDbContext db;
        public ContactsController(ContactsDbContext db) 
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            var contacts = await db.Contacts.ToListAsync();
            return Ok(contacts);
        }
        [HttpPost]
        public async Task<IActionResult >AddContacts(AddContactsRequest addreq)
        {
            var contacts = new Contact()
            {
                Id = Guid.NewGuid(),
                FullName = addreq.FullName,
                Address = addreq.Address,
                Email = addreq.Email,
                Phone = addreq.Phone
            };
            await db.Contacts.AddAsync(contacts);
            await db.SaveChangesAsync();
            return Ok(contacts);

        }
    }
}
