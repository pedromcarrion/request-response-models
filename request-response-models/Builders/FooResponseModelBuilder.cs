using System.Collections.Generic;
using request_response_models.ServiceLibrary.Contracts;
using requestresponsemodels.Models.CitiesAndJobs.Common;
using requestresponsemodels.Models.CitiesAndJobs.Response;

namespace request_response_models.Builders
{
    public sealed class FooResponseModelBuilder
    {
        private IFooService _fooService;
        private List<string> _jobs;
        private List<string> _cities;
        private CityAndJob _selectedValues;

        private FooResponseModelBuilder(IFooService fooService)
        {
            _fooService = fooService;
            _jobs = new List<string>();
            _cities = new List<string>();
            _selectedValues = new CityAndJob();
           
        }

        public static FooResponseModelBuilder CreateNew(IFooService fooService)
        {
            return new FooResponseModelBuilder(fooService);
        }

        public FooResponseModelBuilder WithJobs()
        {
            _jobs = _fooService.GetJobs();
            return this;
        }

        public FooResponseModelBuilder WithCities()
        {
            _cities = _fooService.GetCities();
            return this;
        }

        public FooResponseModelBuilder WithSelectedValues(CityAndJob selectedValues)
        {
            _selectedValues = selectedValues;
            return this;
        }

        public FooResponseModel Build()
        {
            // TODO: Add necessary business validations in order to return a valid response model

            return new FooResponseModel
            {
                Cities = _cities,
                Jobs = _jobs,
                SelectedValues = _selectedValues
            };
        }
    }
}
