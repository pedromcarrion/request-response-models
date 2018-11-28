using Microsoft.AspNetCore.Mvc;
using request_response_models.Mappers;
using request_response_models.ServiceLibrary.Contracts;
using requestresponsemodels.Models.CitiesAndJobs.Request;

namespace request_response_models.Controllers
{
    public class FooController : Controller
    {
        private readonly IFooService _fooService;


        public FooController(IFooService fooService)
        {
            _fooService = fooService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var jobs = _fooService.GetJobs();
            var cities = _fooService.GetCities();
            var fooResponseModel = FooMapper.Map(jobs, cities);
            return View(fooResponseModel);
        }


        [HttpPost]
        public IActionResult Index(FooRequestModel fooRequestModel)
        {
            var jobs = _fooService.GetJobs();
            var cities = _fooService.GetCities();

            //TODO Call a service to do somenthing with the values selected by user

            var fooResponseModel = FooMapper.Map(jobs, cities, fooRequestModel.SelectedValues);
            return View(fooResponseModel);
        }

    }
}
