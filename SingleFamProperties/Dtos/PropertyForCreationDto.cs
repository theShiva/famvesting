namespace SingleFamProperties.Dtos
{
    public class PropertyForCreationDto
    {
        public int Id { get; set; }

        public string FullAddress { get; set; }

        public int YearBuilt { get; set; }

        public decimal ListPrice { get; set; }

        public decimal MonthlyRent { get; set; }

        public decimal GrossYield { get; set; }
    }
}