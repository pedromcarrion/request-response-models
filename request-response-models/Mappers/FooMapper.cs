using requestresponsemodels.Models.CitiesAndJobs.Common;
using requestresponsemodels.Models.CitiesAndJobs.Response;
using System.Collections.Generic;

namespace request_response_models.Mappers
{
    public class FooMapper
    {
        public static FooResponseModel Map(List<string> jobs, List<string> cities)
        {
            return new FooResponseModel(jobs, cities);
        }

        public static FooResponseModel Map(List<string> jobs, List<string> cities, CityAndJob selectedValues)
        {
            return new FooResponseModel(jobs, cities, selectedValues);
        }
    }
}
