using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using SingleFamProperties.Dtos;
using SingleFamProperties.Models;
using SingleFamProperties.ViewModels;

namespace SingleFamProperties.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly SingleFamPropertiesContext _context;

        public PropertiesController()
        {
            _context = new SingleFamPropertiesContext();
        }

        // GET: Properties
        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = new PropertiesPageViewModel();

            var properties = _context.Properties.ToList();

            var propertiesDtos = Mapper.Map<List<Property>, List<PropertySummaryDto>>(properties);
            viewModel.Properties = propertiesDtos;

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(PropertyForCreationDto newProperty)
        {
            if (newProperty == null)
            {
                return Json(new { Response = "Property is empty!" });
            }

            if (!ModelState.IsValid)
            {
                return Json(new { Response = "Invalid Property data" });
            }

            try
            {
                var propertyToSave = Mapper.Map<PropertyForCreationDto, Property>(newProperty);

                _context.Properties.Add(propertyToSave);
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                // TODO: Log Exception and notify devOps
                Console.WriteLine(exception);

                return Json(new { Response = "Error saving Property to database. Our DevOps has been notified. Sorry for the incovenience" });
            }

            return Json(new { Response = "Successfully saved Property!" });
        }
    }
}