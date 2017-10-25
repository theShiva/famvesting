using System;

namespace SingleFamProperties.Dtos
{
    public class FinancialDto
    {
        public object CapRate { get; set; }
        public string Occupancy { get; set; }
        public bool IsSection8 { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
        public float ListPrice { get; set; }
        public object SalePrice { get; set; }
        public object MarketValue { get; set; }
        public object MonthlyHoa { get; set; }
        public object MonthlyManagementFees { get; set; }
        public float MonthlyRent { get; set; }
        public object NetYield { get; set; }
        public object TurnOverFee { get; set; }
        public object RehabCosts { get; set; }
        public object RehabDate { get; set; }
        public float? YearlyInsuranceCost { get; set; }
        public float YearlyPropertyTaxes { get; set; }
        public bool IsCashOnly { get; set; }
    }
}