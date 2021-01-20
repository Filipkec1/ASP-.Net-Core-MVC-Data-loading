using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Zadatak.DAL;
using Zadatak.Model;
using Zadatak.Web.Models;
using Zadatak.Web.Services;

namespace Zadatak.Web.Controllers
{
    public class ZadatakController : Controller
    {
        private ZadatakManagerDbContext _dbContext;
        private readonly IOptions<FilePathModel> _config;

        public ZadatakController(ZadatakManagerDbContext dbContext, IOptions<FilePathModel> config)
        {
            this._dbContext = dbContext;
            this._config = config;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAjax()
        {
            var peopleList = await this._dbContext.People.ToListAsync();

            return PartialView("TablePeopleView", peopleList);
        }

        public IActionResult Create()
        {
            return PartialView("_CreateOrEdit");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person model)
        {

            if (ModelState.IsValid)
            {
                this._dbContext.People.Add(model);
                await this._dbContext.SaveChangesAsync();

                return PartialView("TablePeopleView", await this._dbContext.People.ToListAsync());

                //return NoContent();

                //return PartialView("_IndexTable");

                //return PartialView("~\\View\\Zadatak\\_IndexTable.cshtml");

                //return Json("Reload");

                //return RedirectToAction("IndexAjax");

                //return Ok();
            }

            return NoContent();
        }

        [ActionName("Edit")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = this._dbContext.People
                                      .FirstOrDefault(m => m.ID == id);

            if (person == null)
            {
                return NotFound();
            }

            return PartialView("_CreateOrEdit", person);
        }

        [HttpPost]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPerson(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await this._dbContext.People
                                            .FirstOrDefaultAsync(m => m.ID == id);

            bool ok = await this.TryUpdateModelAsync(person);
            if (ok)
            {
                this._dbContext.SaveChanges();
                //return NoContent();
                return Ok();
                //return RedirectToAction(nameof(Index));
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = this._dbContext.People.FirstOrDefault(m => m.ID == id);

            if (person == null)
            {
                return NotFound();
            }

            this._dbContext.People.Remove(person);
            await this._dbContext.SaveChangesAsync();

            return View(nameof(Index));

            //return RedirectToAction(nameof(IndexAjaxGet));

            //return Ok("Success");
        }

        public IActionResult LoadData()
        {
            PeopleService peopleService = new PeopleService();
            var resultData = peopleService.ReadCSVFile(_config.Value.Path);

            return View(resultData);
        }

        public IActionResult LoadDataTable()
        {
            PeopleService peopleService = new PeopleService();
            var resultData = peopleService.ReadCSVFile(_config.Value.Path);

            return PartialView("_LoadDataTable", resultData);
        }

        [HttpPost]
        public IActionResult LoadDataTable([FromBody] List<PersonModel> peopleList)
        {
            List<Person> newPeopleList = new List<Person>();

            foreach (var person in peopleList) {

                Person newPerson = new Person() {

                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    CityName = person.CityName,
                    PostalCode = person.PostalCode,
                    MobileNumber = person.MobileNumber
                };

                var valid = TryValidateModel(newPerson);

            }

            return View(nameof(Index));
        }
    }
}
