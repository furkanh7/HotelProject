using HotalProject.EntityLayer.Concrete;
using HotalProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotalProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        // Constructor ile UserManager injection
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: Kayıt formunu göstermek için
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Kayıt formu verilerini işlemek için
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            // Model doğrulaması başarısızsa, form tekrar gösterilir
            if (!ModelState.IsValid)
            {
                return View(createNewUserDto); // Formda hatalar varsa, form tekrar gösterilir
            }

            // Yeni kullanıcı oluşturma işlemi
            var appUser = new AppUser
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username
            };

            // Kullanıcı oluşturma işlemi, şifre ile birlikte
            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);

            // İşlem başarılı ise, kullanıcı giriş ekranına yönlendirilir
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                // Kayıt başarısızsa, hatalar kullanıcıya gösterilir
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description); // Hata mesajlarını ekler
                }

                return View(createNewUserDto); // Hatalar varsa form tekrar gösterilir
            }
        }
    }
}
