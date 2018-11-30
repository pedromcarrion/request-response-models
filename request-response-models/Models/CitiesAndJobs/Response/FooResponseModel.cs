using System.Collections.Generic;
using requestresponsemodels.Models.CitiesAndJobs.Common;

namespace requestresponsemodels.Models.CitiesAndJobs.Response
{
    public class FooResponseModel
    {

        public List<string> Cities { get; set; }

        public List<string> Jobs { get; set; }

        public CityAndJob SelectedValues { get; set; }

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

        public FooResponseModel()
        {
            SelectedValues = new CityAndJob();
        }

    }
}
