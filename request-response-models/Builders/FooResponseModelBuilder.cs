using request_response_models.ServiceLibrary.Contracts;
using requestresponsemodels.Models.CitiesAndJobs.Common;
using requestresponsemodels.Models.CitiesAndJobs.Response;

namespace request_response_models.Builders
{
    public class FooResponseModelBuilder
    {
        private IFooService _fooService;
        private FooResponseModel _fooResponseModel;

        public FooResponseModelBuilder(IFooService fooService)
        {
            _fooService = fooService;
            _fooResponseModel = new FooResponseModel();
        }

        public FooResponseModelBuilder WithJobs()
        {
            _fooResponseModel.Jobs = _fooService.GetJobs();
            return this;
        }

        public FooResponseModelBuilder WithCities()
        {
            _fooResponseModel.Cities = _fooService.GetCities();
            return this;
        }

        public FooResponseModelBuilder WithSelectedValues(CityAndJob selectedValues)
        {
            _fooResponseModel.SelectedValues = selectedValues;
            return this;
        }

        public FooResponseModel Build()
        {
            // TODO: Add necessary business validations in order to return a valid response model

            return _fooResponseModel;
        }
    }
}
