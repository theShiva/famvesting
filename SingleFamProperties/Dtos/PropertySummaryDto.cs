using System.ComponentModel.DataAnnotations;

namespace SingleFamProperties.Dtos
{
    public class PropertySummaryDto
    {
        public int Id { get; set; }

        public string FullAddress { get; set; }

        public int YearBuilt { get; set; }

        [DisplayFormat(DataFormatString = "{0:$0,0.00}")]
        public decimal ListPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:$0,0.00}")]
        public decimal MonthlyRent { get; set; }

        /// <summary>
        /// Gross Yield will be stored as a fraction, but displayed as a %age value.
        /// Lot of people like to see 3 decimals in, hence I've formatted it like this :)
        /// </summary>
        /// <remarks>
        /// Formula for Gross Yield as a fraction = ('Monthly Rent' * 12 ) / 'List Price'
        /// </remarks>
        [DisplayFormat(DataFormatString = "{0:##0.000%}")]
        public decimal GrossYield
        {
            get
            {
                if (ListPrice == 0.0M || MonthlyRent == 0.0M)
                {
                    return 0.0M;
                }

                // NOTE: parenthesis not needed due to operator precedence
                // i.e. * over  / . But I like to leave it to make it 
                // explicitly clear to someone reading the code...
                return  (MonthlyRent * 12) / ListPrice ;
            }
        }
    }
}