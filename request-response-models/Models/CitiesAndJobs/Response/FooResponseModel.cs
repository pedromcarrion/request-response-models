using System.Collections.Generic;
using requestresponsemodels.Models.CitiesAndJobs.Common;

namespace requestresponsemodels.Models.CitiesAndJobs.Response
{
    public class FooResponseModel
    {

        public List<string> Cities { get; private set; }

        public List<string> Jobs { get; private set; }

        public CityAndJob SelectedValues { get; private set; }

        public string ErrorMessage {
            get
            {
                if (SelectedValues.City == "Selecciona un valor"
                   || SelectedValues.Job == "Selecciona un valor")
                {
                    return "Debe seleccionar valores en los dos campos";
                }
                else
                {
                    return "Todo correcto!";
                }
            }
        }

        public string Message { get; set; }


        public FooResponseModel(List<string> jobs, List<string> cities, CityAndJob selectedValues)
        {
            Cities = cities;
            Jobs = jobs;
            SelectedValues = selectedValues;
        }

        public FooResponseModel(List<string> jobs, List<string> cities)
        {
            Cities = cities;
            Jobs = jobs;
            SelectedValues = new CityAndJob();
        }

        public FooResponseModel()
        {
            SelectedValues = new CityAndJob();
        }

    }
}
