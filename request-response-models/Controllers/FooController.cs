using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using request_response_models.ServiceLibrary.Contracts;
using requestresponsemodels.Models.CitiesAndJobs.Request;
using requestresponsemodels.Models.CitiesAndJobs.Response;

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
            var fooResponseModel = new FooResponseModel(_fooService);
            return View(fooResponseModel);
        }


        [HttpPost]
        public IActionResult Index(FooRequestModel fooRequestModel)
        {
            var fooResponseModel = new FooResponseModel(_fooService, fooRequestModel.SelectedValues);

            if (fooRequestModel.SelectedValues.City == "Selecciona un valor" 
               || fooRequestModel.SelectedValues.Job == "Selecciona un valor")
            {
                fooResponseModel.ErrorMessage = "Debe seleccionar valores en los dos campos";
            }
            else
            {
                //TODO Call a service to do somenthing with the values selected by user
                fooResponseModel.Message = "Todo correcto!";
            }

            return View(fooResponseModel);
        }


    }
}
