using System;
using System.Collections.Generic;

namespace SingleFamProperties.Dtos
{
    public class PropertyDto
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int? BuyerAccountId { get; set; }
        public int? BuyerUserId { get; set; }
        public object ExternalId { get; set; }
        public object ProgramId { get; set; }
        public bool IsDwellCertified { get; set; }
        public bool IsAllowOffer { get; set; }
        public bool IsAllowPreview { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsRentGuaranteed { get; set; }
        public bool AllowRentGuaranteedOptout { get; set; }
        public bool IsSecuritized { get; set; }
        public bool IsHot { get; set; }
        public bool IsNew { get; set; }
        public bool? IsBargain { get; set; }
        public bool IsDiligenceVaultUnlocked { get; set; }
        public bool? IsPropertyManagerOfferRetain { get; set; }
        public bool? IsHoa { get; set; }
        public bool HasAudio { get; set; }
        public bool HasDiligenceVaultDocuments { get; set; }
        public int Market { get; set; }
        public int? DaysOnMarket { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public object PropertyName { get; set; }
        public string Description { get; set; }
        public object Highlights { get; set; }
        public string MainImageUrl { get; set; }
        public object PersonalProperties { get; set; }
        public string DiligenceVaultSummary { get; set; }
        public object FeaturedReason { get; set; }
        public string Status { get; set; }
        public string AllowedFundingTypes { get; set; }
        public string AllowableSaleTypes { get; set; }
        public string Visibility { get; set; }
        public string PriceVisibility { get; set; }
        public string PropertyType { get; set; }
        public string CertificationLevel { get; set; }
        public DateTime? EscrowClosingDate { get; set; }
        public AddressDto Address { get; set; }
        public FinancialDto Financial { get; set; }
        public PhysicalDto Physical { get; set; }
        public ScoreDto Score { get; set; }
        public ValuationDto Valuation { get; set; }
        public ResourcesDto Resources { get; set; }
        public object Manager { get; set; }
        public object Seller { get; set; }
        public object SellerBroker { get; set; }
        public object Hoa { get; set; }
        public LeaseDto LeaseDto { get; set; }
        public List<object> Diligences { get; set; }
        public GoogleMapOptionDto GoogleMapOptionDto { get; set; }
        public object InspectionType { get; set; }
    }
}