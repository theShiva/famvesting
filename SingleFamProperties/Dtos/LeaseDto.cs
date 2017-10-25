namespace SingleFamProperties.Dtos
{
    public class LeaseDto
    {
        public LeaseSummaryDto LeaseSummary { get; set; }
        public UtilitiesOwnershipDto UtilitiesOwnership { get; set; }
        public ApplianceOwnershipDto ApplianceOwnership { get; set; }
    }
}