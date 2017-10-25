namespace SingleFamProperties.Dtos
{
    public class PhysicalDto
    {
        public float BathRooms { get; set; }
        public float BedRooms { get; set; }
        public string ParcelNumber { get; set; }
        public bool IsPool { get; set; }
        public int? LotSize { get; set; }
        public int SquareFeet { get; set; }
        public object Stories { get; set; }
        public object Units { get; set; }
        public int YearBuilt { get; set; }
        public object ZipYearBuilt { get; set; }
    }
}