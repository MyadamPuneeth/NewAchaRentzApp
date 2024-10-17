using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebPagesMvc.Data;

using WebPagesMvc.Models;

namespace WebPagesMvc.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AppDbContext _context;
        public int tempData;
        public RegistrationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("UserName, Password, AgreedToTerms")]User registrationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(registrationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("ExtraDetails", new {id = registrationModel.UserId});
            }            
            return View(registrationModel);
        }

        [HttpGet]

        public async Task<IActionResult> ExtraDetails(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> ExtraDetails([Bind("FirstName, LastName, PhoneNumber, Email, AlternatePhoneNumber, Address, AadharNumber")] User userModel)
        {

            var user = await _context.Users.FindAsync(userModel.UserId);
            if (user != null)
            {
                _context.Users.Update(user); // Update user in the database
                await _context.SaveChangesAsync();

                return RedirectToAction("Success"); // Redirect to a success page
            }
            return View(userModel);
        }

    }

}