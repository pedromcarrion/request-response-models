using System;
using System.Collections.Generic;
using request_response_models.ServiceLibrary.Contracts;

namespace request_response_models.ServiceLibrary.Implementations
{
    public class FooService : IFooService
    {
        public FooService()
        {
        }

        public List<string> GetCities()
        {
            return new List<string>
            {
                "Selecciona un valor","Barcelona", "Madrid"
            };
               
        }

        public List<string> GetJobs()
        {
            return new List<string>
            {
                "Selecciona un valor","Enginer", "Product Owner"
            };
        }
    }
}
