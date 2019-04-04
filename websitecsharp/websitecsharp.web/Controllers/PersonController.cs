using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using websitecsharp.shared.Interface;
using websitecsharp.shared.orchestrators;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.web.Controllers
{
    public class PersonController : Controller
    {


        public ActionResult Update()
        {
            return View();
        }

        private readonly iPersonOrchestrator _personorchestrator;

        public PersonController(iPersonOrchestrator personorchestrator)
        {
            _personorchestrator = personorchestrator;
        }




        // GET: Person
        public async Task<ActionResult> Index()
        {
            var spdateUserViewModel = new PersonViewModel
            {
               Person  = await _personorchestrator.GetPeople()
            };
            return View(spdateUserViewModel);

        }

        public async Task<ActionResult> Create(UpdateUserViewModel person)
        {
            if (person.personID.Equals(null))
                return View();

            

            var updatedCount = await _personorchestrator.CreatePerson(new UpdateUserViewModel
            {
                personID = Guid.NewGuid(),
                FirstName = person.FirstName,
                LastName = person.LastName,
                PhoneNumber = person.PhoneNumber,
                Email = person.Email,
                DateCreated = person.DateCreated,
                PersonGender = person.PersonGender
            });

            
            

            return View();
        }


        public async Task<JsonResult> UpdatePerson(UpdateUserViewModel person)
        {
            if (person.personID == Guid.Empty)
                return Json(false, JsonRequestBehavior.AllowGet);


            var result = await _personorchestrator.UpdatePerson(new UpdateUserViewModel
            {
                personID = person.personID,
                FirstName = person.FirstName,
                LastName = person.LastName,
                PersonGender = person.PersonGender,
                DateCreated = person.DateCreated,
                PhoneNumber = person.PhoneNumber,
                Email = person.Email

                         

            });

            
            

            return Json(result, JsonRequestBehavior.AllowGet);
                     

        }

        public async Task<JsonResult> Search(string searchString)
        {
            string id = Session["userId"].ToString();
            


            if(searchString.Equals(id))
            {
                var viewmodel = await _personorchestrator.SearchStudent(id);

                return Json(viewmodel, JsonRequestBehavior.AllowGet);
            }else
            {
                var viewmodel = await _personorchestrator.SearchStudent(searchString);

                return Json(viewmodel, JsonRequestBehavior.AllowGet);
            }

           
        }



    }
}
