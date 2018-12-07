using Microsoft.AspNetCore.Mvc;
using request_response_models.Builders;
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
            var fooResponseModel = FooResponseModelBuilder.CreateNew(_fooService)
                .WithJobs()
                .WithCities()
                .Build();
                
            return View(fooResponseModel);
        }


        [HttpPost]
        public IActionResult Index(FooRequestModel fooRequestModel)
        {
            //TODO Call a service to do somenthing with the values selected by user
            var fooResponseModel = FooResponseModelBuilder.CreateNew(_fooService)
                .WithJobs()
                .WithCities()
                .WithSelectedValues(fooRequestModel.SelectedValues)
                .Build();

            return View(fooResponseModel);
        }

    }
}
