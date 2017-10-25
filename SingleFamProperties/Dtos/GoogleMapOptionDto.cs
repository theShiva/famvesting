namespace SingleFamProperties.Dtos
{
    public class GoogleMapOptionDto
    {
        public bool HasStreetView { get; set; }
        public int PovHeading { get; set; }
        public int PovPitch { get; set; }
        public float PovLatitude { get; set; }
        public float PovLongitude { get; set; }
    }
}