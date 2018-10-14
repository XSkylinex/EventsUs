using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using EventsUs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EventsUs.Areas.Identity.Pages.Account
{
    // [Authorize(Roles = "Admin")]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;


        private readonly RoleManager<IdentityRole> _roleManager;
        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            //[Display(Name = "Full Name")]
            //public string Name { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [DataType(DataType.Upload)]
            [Display(Name = "AvatarImage")]
            public IFormFile files { get; set; }

            [Required]
            public string Name { get; set; }
            [Required]
            [Range(1, 125, ErrorMessage = "Please enter a value bigger than {1} and smaller than {125}")]
            public int Age { get; set; }
            [Required]
            public string Country { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Admin")]
            public bool isAdmin { get; set; }

        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)


            {

                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, Name = Input.Name, PhoneNumber = Input.PhoneNumber, Age = Input.Age, Country = Input.Country };

                if (Input.files != null) 
                using (var memoryStream = new MemoryStream())
                {
                    await Input.files.CopyToAsync(memoryStream);
                    user.AvatarImage = memoryStream.ToArray();
                } 
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {

                    if (!await _roleManager.RoleExistsAsync("CalendarUser"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("CalendarUser"));
                    }

                    if (!await _roleManager.RoleExistsAsync("Admin"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    }

                    if (Input.isAdmin)
                    {
                        await _userManager.AddToRoleAsync(user, "Admin");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, "CalendarUser");
                    }

                   


                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);

                    // return RedirectToAction("Index", "Admin", new {area = "Admin" });
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
              
                
            }
            return Page();

            // If we got this far, something failed, redisplay form

        }
    }
}

//[HttpPost("UploadFiles")]
//public async Task<IActionResult> Post(List<IFormFile> files)
//{
//    long size = files.Sum(f => f.Length);

//    // full path to file in temp location
//    var filePath = Path.GetTempFileName();

//    foreach (var formFile in files)
//    {
//        if (formFile.Length > 0)
//        {
//            using (var stream = new FileStream(filePath, FileMode.Create))
//            {
//                await formFile.CopyToAsync(stream);
//            }
//        }
//    }

//    // process uploaded files
//    // Don't rely on or trust the FileName property without validation.
    
//    //return Ok(new { count = files.Count, size, filePath });
//}



