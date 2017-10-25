using System.Collections.Generic;
using SingleFamProperties.Dtos;

namespace SingleFamProperties.ViewModels
{
    public class HomePageViewModel
    {
        public string StatusMessage { get; set; }

        public List<PropertySummaryDto> Properties { get; set; }

        public HomePageViewModel()
        {
            Properties = new List<PropertySummaryDto>();
        }
    }
}