using System;
using System.Collections.Generic;

namespace request_response_models.ServiceLibrary.Contracts
{
    public interface IFooService
    {

        List<string> GetCities();

        List<string> GetJobs();
    }
}
