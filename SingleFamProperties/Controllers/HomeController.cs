using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using Newtonsoft.Json;
using SingleFamProperties.Dtos;
using SingleFamProperties.Models;
using SingleFamProperties.ViewModels;

namespace SingleFamProperties.Controllers
{
    public class HomeController : Controller
    {
        private readonly SingleFamPropertiesContext _context;

        public HomeController()
        {
            _context = new SingleFamPropertiesContext();
        }

        public async Task<ActionResult> Index()
        {
            var viewModel = new HomePageViewModel();

            PropertiesDto propertiesDto;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var propertiesEndpoint = ConfigurationManager.AppSettings["RoofStockNewHomesEndpoint"];

#if DEBUG
                    propertiesEndpoint = "http://localhost:65193/sample-properties.json";
#endif
                    var propertiesResponse = await client.GetAsync(propertiesEndpoint);

                    if (propertiesResponse.IsSuccessStatusCode)
                    {
                        string propertiesJson = await propertiesResponse.Content.ReadAsStringAsync();
                        propertiesDto = JsonConvert
                            .DeserializeObject<PropertiesDto>(propertiesJson);

                        if (propertiesDto != null)
                        {
                                // remove properties that are already in the database
                            var existingPropertyIds = _context.Properties.Select(p => p.Id).ToList();

                            propertiesDto.Properties.RemoveAll(p => existingPropertyIds.Contains(p.Id));

                                // set the new properties only, in the viewmodel    
                            viewModel.Properties = Mapper.Map<List<PropertyDto>, List<PropertySummaryDto>>(propertiesDto.Properties);

                            if (!viewModel.Properties.Any())
                            {
                                viewModel.StatusMessage = "No new properties were found.";
                            }
                        }
                    }
                    else
                    {
                        viewModel.StatusMessage =
                            "An unexpected error occurred. Our DevOps is investigating. Please try again in a few minutes.";
                        // Log Error
                        return View(viewModel);
                    }
                }
            }
            catch (Exception exception)
            {
                // TODO: Log Exception and notify devOps
                Console.WriteLine(exception);

                viewModel.StatusMessage =
                    "An unexpected error occurred. Our DevOps is investigating. Please try again in a few minutes.";

                return View(viewModel);
            }

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Single Fam Investments Project";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Shiva";

            return View();
        }
    }
}