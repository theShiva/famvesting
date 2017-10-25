using System;

namespace SingleFamProperties.Dtos
{
    public class LeaseSummaryDto
    {
        public string Occupancy { get; set; }
        public object LeasingStatus { get; set; }
        public object MarketedRent { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
        public float MonthlyRent { get; set; }
        public float? SecurityDepositAmount { get; set; }
        public object HasPet { get; set; }
        public object PetFeeAmount { get; set; }
        public bool IsPetsDeposit { get; set; }
        public float? PetsDepositAmount { get; set; }
        public bool? IsLeaseConcessions { get; set; }
        public bool IsRentersInsuranceRequired { get; set; }
        public bool IsSection8 { get; set; }
        public bool IsTenantBackgroundChecked { get; set; }
        public bool IsTenantIncomeAbove3X { get; set; }
        public object IsTenantMayTerminateEarly { get; set; }
        public object IsTenantPurchaseOption { get; set; }
    }
}