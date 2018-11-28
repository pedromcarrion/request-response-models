using System;
using System.Collections.Generic;
using request_response_models.ServiceLibrary.Contracts;
using requestresponsemodels.Models.CitiesAndJobs.Common;

namespace requestresponsemodels.Models.CitiesAndJobs.Response
{
    public class FooResponseModel
    {

        public List<string> Cities { get; private set; }

        public List<string> Jobs { get; private set; }

        public CityAndJob SelectedValues { get; private set; }

        public string ErrorMessage { get; set; }

        public string Message { get; set; }


        public FooResponseModel(IFooService fooService, CityAndJob selectedValues)
        {
            Cities = fooService.GetCities();
            Jobs = fooService.GetJobs();
            SelectedValues = selectedValues;
        }

        public FooResponseModel(IFooService fooService)
        {
            Cities = fooService.GetCities();
            Jobs = fooService.GetJobs();
            SelectedValues = new CityAndJob();
        }

    }
}
