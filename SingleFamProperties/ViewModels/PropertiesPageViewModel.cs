using System.Collections.Generic;
using SingleFamProperties.Dtos;

namespace SingleFamProperties.ViewModels
{
    public class PropertiesPageViewModel
    {
        public List<PropertySummaryDto> Properties { get; set; }

        public PropertiesPageViewModel()
        {
            Properties = new List<PropertySummaryDto>();
        }

    }
}