using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {


        private readonly IPersonRepository _personRepository;// An Interface type containing the methods for the person repository


        public ContactController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IActionResult Index()
        {


            return View(_personRepository.GetPerson(1)); // Returns a view with userId 1;
        }

    }
}
